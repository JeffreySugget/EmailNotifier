using System;
using System.Configuration;
using System.Data.SQLite;
using System.Windows.Forms;
using ApiLibrary.Classes;
using ApiLibrary.Interfaces;
using DatabaseInterface.Classes;

namespace DatabaseInterface
{
    public partial class EmailManager : Form
    {
        private static readonly IConfigurationHelper _configurationHelper = new ConfigurationHelper();
        private readonly IDataHelper _dataHelper = new DataHelper(_configurationHelper);

        public EmailManager()
        {
            InitializeComponent();
            cmbEmails.Text = "--Select Email--";
            AddEmails();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAddress.Text))
            {
                MessageBox.Show("Please enter an email address before continuing!", MessageHeading.Error);
                return;
            }

            var sql = $"INSERT INTO EmailInfo (Address) VALUES ('{txtAddress.Text}')";

            DatabaseHelper.ExecuteNonQuery(sql);

            MessageBox.Show($"Successfully added email {txtAddress.Text}");

            cmbEmails.Items.Add(txtAddress.Text);

            txtAddress.Clear();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            //TODO: Add these to list ?
            var selectIdSql = $"SELECT EmailId FROM ShowInfo WHERE EmailId = (SELECT Id FROM EmailInfo WHERE Address = '{cmbEmails.SelectedItem}')";
            var emailCheckSql = $"SELECT Address FROM EmailInfo WHERE Address = '{cmbEmails.SelectedItem}'";
            Object emailId = null;

            using (var sqlConn = new SQLiteConnection(_configurationHelper.ConnectionString))
            {
                sqlConn.Open();

                using (var sqlCmd = new SQLiteCommand(selectIdSql, sqlConn))
                {
                    var dr = sqlCmd.ExecuteReader();

                    while (dr.Read())
                    {
                        emailId = dr["EmailId"];
                    }
                }
            }

            if (emailId != null)
            {
                MessageBox.Show("Please remove this email from shows before deleting", MessageHeading.Error);
            }
            else
            {
                var deleteSql = $"DELETE FROM EmailInfo WHERE Address = '{cmbEmails.SelectedItem}'";

                DatabaseHelper.ExecuteNonQuery(deleteSql);

                cmbEmails.Items.Remove(cmbEmails.SelectedItem);

                MessageBox.Show($"Successfully deleted email {cmbEmails.SelectedItem}");
            }
        }

        private void AddEmails()
        {
            foreach (var email in _dataHelper.GetEmails())
            {
                cmbEmails.Items.Add(email);
            }
        }

        private void cmbEmails_SelectedIndexChanged(object sender, EventArgs e)
        {
            Delete.Enabled = true;
        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {
            btnAdd.Enabled = true;
        }
    }
}
