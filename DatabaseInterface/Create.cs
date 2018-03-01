using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DatabaseInterface.Classes;
using System.IO;
using System.Data.SQLite;
using System.Configuration;

namespace DatabaseInterface
{
    public partial class Create : Form
    {
        public Create()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                CheckTextBoxes();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, MessageHeading.Error);
                return;
            }

            if (!Directory.Exists("C:\\SonarrDatabase"))
            {
                Directory.CreateDirectory("C:\\SonarrDatabase");
            }

            SQLiteConnection.CreateFile(ConfigurationManager.AppSettings["SonarrDatabasePath"]);
            CreateTables();
            AddSonarrData();
        }

        private void btnAddEmails_Click(object sender, EventArgs e)
        {
            if (!File.Exists(ConfigurationManager.AppSettings["SonarrDatabasePath"]))
            {
                MessageBox.Show("Please create a database before creating emails.", MessageHeading.Error);
                return;
            }

            var emailForm = new EmailManager();

            emailForm.Show();
        }

        private void CreateTables()
        {
            var sql = @"CREATE TABLE SonarrInfo (Id INTEGER PRIMARY KEY AUTOINCREMENT, ApiKey TEXT, IpAddress TEXT, Email TEXT, Password TEXT);
                        CREATE TABLE EmailInfo (Id INTEGER PRIMARY KEY AUTOINCREMENT, Address Text);
                        CREATE TABLE ShowInfo (Id INTEGER PRIMARY KEY AUTOINCREMENT, ShowName TEXT, EmailId INTEGER, FOREIGN KEY(EmailId) REFERENCES EmailInfo(Id));";

            DatabaseHelper.ExecuteNonQuery(sql);
        }

        private void CheckTextBoxes()
        {
            if (string.IsNullOrWhiteSpace(txtApiKey.Text))
            {
                throw new Exception("Please enter an API Key before continuing!");
            }

            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                throw new Exception("Please enter an Email before continuing!");
            }

            if (string.IsNullOrWhiteSpace(txtEmailPassword.Text))
            {
                throw new Exception("Please enter an Email Password before continuing!");
            }

            if (string.IsNullOrWhiteSpace(txtIpAddress.Text))
            {
                throw new Exception("Please enter your Sonarr ip address before continuing!");
            }
        }

        private void AddSonarrData()
        {
            var sql = $"INSERT INTO SonarrInfo (ApiKey, IpAddress, Email, Password) VALUES ('{txtApiKey.Text}', '{txtIpAddress.Text}', '{txtEmail.Text}', '{txtEmailPassword.Text}')";

            DatabaseHelper.ExecuteNonQuery(sql);
        }
    }
}
