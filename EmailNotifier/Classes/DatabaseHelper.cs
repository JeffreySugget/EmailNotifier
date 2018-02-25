using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmailNotifier.Interfaces;
using System.Data.SQLite;
using System.IO;

namespace EmailNotifier.Classes
{
    public class DatabaseHelper : IDatabaseHelper
    {
        public void CreateDatabase()
        {
            if (!File.Exists($"{Environment.CurrentDirectory}\\SonarrInfoDatabase"))
            {
                SQLiteConnection.CreateFile("SonarrInfoDatabase");
                CreateTables();
                AddSonarrData();
            }
        }

        private void CreateTables()
        {
            var sql = @"CREATE TABLE SonarrInfo (Id INTEGER PRIMARY KEY AUTOINCREMENT, ApiKey TEXT, IpAddress TEXT);
                        CREATE TABLE EmailInfo (Id INTEGER PRIMARY KEY AUTOINCREMENT, Address Text);
                        CREATE TABLE ShowInfo (Id INTEGER PRIMARY KEY AUTOINCREMENT, ShowName TEXT, EmailId INTEGER, FOREIGN KEY(EmailId) REFERENCES EmailInfo(Id));";

            //TODO: Move sql code to stand alone method
            //using (var sqlConn = new SQLiteConnection("Data Source=SonarrInfoDatabase;Version=3;"))
            //{
            //    sqlConn.Open();

            //    using (var sqlCmd = new SQLiteCommand(sql, sqlConn))
            //    {
            //        sqlCmd.ExecuteNonQuery();
            //    }
            //}

            ExecuteNonQuery(sql);
        }

        private void AddSonarrData()
        {
            ShowOutput("Please enter your Sonarr API Key: ");

            var apiKey = GetUserInput();

            ShowOutput("Please enter your Sonarr IP and Port (e.g. https:\\\\x.x.x.x:xxxx)");

            var ipAddress = GetUserInput();

            var sql = $@"INSERT INTO SonarrInfo (ApiKey, IpAddress) VALUES ('{apiKey}', '{ipAddress}')";

            //using (var sqlConn = new SQLiteConnection("Data Source=SonarrInfoDatabase;Version=3;"))
            //{
            //    sqlConn.Open();

            //    using (var sqlCmd = new SQLiteCommand(sql, sqlConn))
            //    {
            //        sqlCmd.ExecuteNonQuery();
            //    }
            //}

            ExecuteNonQuery(sql);
        }

        private void AddEmailAddress()
        {
            var addresses = new List<string>();

            ShowOutput("How many email addresses do you want to add: ");
            var number = int.Parse(GetUserInput());

            for (var i = 0; i < number; i++)
            {
                ShowOutput("Please enter an email address for messages to be sent to: ");
                addresses.Add(GetUserInput());
            }

            foreach (var a in addresses)
            {
                //TODO: insert into database
            }
        }

        private void ExecuteNonQuery(string sql)
        {
            using (var sqlConn = new SQLiteConnection("Data Source=SonarrInfoDatabase;Version=3;"))
            {
                sqlConn.Open();

                using (var sqlCmd = new SQLiteCommand(sql, sqlConn))
                {
                    sqlCmd.ExecuteNonQuery();
                }
            }
        }

        private void AddShowData()
        {
            //TODO: get email addressess and add to list
            //TODO: create a list of shows and ask user which email address is attached to them
        }

        private string GetUserInput()
        {
            return Console.ReadLine();
        }

        private void ShowOutput(string message)
        {
            Console.WriteLine(message);
        }
    }
}
