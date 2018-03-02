using System;
using System.Configuration;
using System.Data.SQLite;
using System.Windows.Forms;
using DatabaseInterface.Classes;

namespace DatabaseInterface
{
    public partial class EmailManager : Form
    {
        public EmailManager()
        {
            InitializeComponent();
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

            txtAddress.Clear();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            var selectIdSql = $"SELECT EmailId FROM ShowInfo WHERE EmailId = (SELECT Id FROM EmailInfo WHERE Address = '{txtAddress.Text}')";
            var emailCheckSql = $"SELECT Address FROM EmailInfo WHERE Address = '{txtAddress.Text}'";
            Object emailId = null;
            Object email = null;

            using (var sqlConn = new SQLiteConnection($"Data Source={ConfigurationManager.AppSettings["SonarrDatabasePath"]};Version=3;"))
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

                using (var sqlCmd = new SQLiteCommand(emailCheckSql, sqlConn))
                {
                    var dr = sqlCmd.ExecuteReader();

                    while (dr.Read())
                    {
                        email = dr["Address"];
                    }
                }
            }

            if (emailId != null)
            {
                MessageBox.Show("Please remove this email from shows before deleting", MessageHeading.Error);
            }
            else
            {
                if (email != null)
                {
                    var deleteSql = $"DELETE FROM EmailInfo WHERE Address = '{txtAddress.Text}'";

                    DatabaseHelper.ExecuteNonQuery(deleteSql);

                    MessageBox.Show($"Successfully deleted email {txtAddress.Text}");
                }
                else
                {
                    MessageBox.Show("Email doesn't exist", MessageHeading.Error);
                }
            }
        }
    }
}
