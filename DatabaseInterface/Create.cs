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
            CheckTextBoxes();

            SQLiteConnection.CreateFile($"{txtWorkingDir.Text}\\SonarrInfoDatabase");
            CreateTables();
            AddSonarrData();
        }

        private void CreateTables()
        {
            var sql = @"CREATE TABLE SonarrInfo (Id INTEGER PRIMARY KEY AUTOINCREMENT, ApiKey TEXT, IpAddress TEXT, Email TEXT, Password TEXT);
                        CREATE TABLE EmailInfo (Id INTEGER PRIMARY KEY AUTOINCREMENT, Address Text);
                        CREATE TABLE ShowInfo (Id INTEGER PRIMARY KEY AUTOINCREMENT, ShowName TEXT, EmailId INTEGER, FOREIGN KEY(EmailId) REFERENCES EmailInfo(Id));";

            ExecuteNonQuery(sql);
        }

        private void CheckTextBoxes()
        {
            if (string.IsNullOrWhiteSpace(txtWorkingDir.Text))
            {
                MessageBox.Show("Please enter your working directory before continuing!", MessageHeading.Error);
                return;
            }
            else if (!Directory.Exists(txtWorkingDir.Text))
            {
                MessageBox.Show("Working directory not found!", MessageHeading.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtApiKey.Text))
            {
                MessageBox.Show("Please enter an API Key before continuing!", MessageHeading.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Please enter an Email before continuing!", MessageHeading.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtEmailPassword.Text))
            {
                MessageBox.Show("Please enter an Email Password before continuing!", MessageHeading.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtIpAddress.Text))
            {
                MessageBox.Show("Please enter your Sonarr ip address");
                return;
            }
        }

        private void AddSonarrData()
        {
            var sql = $"INSERT INTO SonarrInfo (ApiKey, IpAddress, Email, Password) VALUES ('{txtApiKey.Text}', '{txtIpAddress.Text}', '{txtEmail.Text}', '{txtEmailPassword.Text}')";

            ExecuteNonQuery(sql);
        }

        private void ExecuteNonQuery(string sql)
        {
            using (var sqlConn = new SQLiteConnection($"Data Source={txtWorkingDir.Text}\\SonarrInfoDatabase;Version=3;"))
            {
                sqlConn.Open();

                using (var sqlCmd = new SQLiteCommand(sql, sqlConn))
                {
                    sqlCmd.ExecuteNonQuery();
                }
            }
        }
    }
}
