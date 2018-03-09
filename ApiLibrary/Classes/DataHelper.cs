using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SQLite;
using System.Text;
using ApiLibrary.Interfaces;

namespace ApiLibrary.Classes
{
    public class DataHelper : IDataHelper
    {
        public string GetApiCall(string endPoint, string parameters = null)
        {
            var getSonarrInfoSql = "SELECT ApiKey, IpAddress FROM SonarrInfo";
            var apiCall = new StringBuilder();
            var sonarrInfo = new List<string>();

            using (var sqlConn = new SQLiteConnection("Data Source=C:\\SonarrDatabase\\SonarrInfoDatabase;Version=3;"))
            {
                sqlConn.Open();

                using (var sqlCmd = new SQLiteCommand(getSonarrInfoSql, sqlConn))
                {
                    SQLiteDataReader dr = sqlCmd.ExecuteReader();

                    while (dr.Read())
                    {
                        sonarrInfo.Add(dr["IpAddress"].ToString());
                        sonarrInfo.Add(dr["ApiKey"].ToString());
                    }
                }
            }

            if (!string.IsNullOrWhiteSpace(parameters))
            {
                apiCall.Append($"{sonarrInfo[0]}/{endPoint}?apiKey={sonarrInfo[1]}&{parameters}");
            }
            else
            {
                apiCall.Append($"{sonarrInfo[0]}/{endPoint}?apiKey={sonarrInfo[1]}");
            }

            return apiCall.ToString();
        }

        public string GetBaseUrl()
        {
            var sql = "SELECT IpAddress FROM SonarrInfo";
            var baseUrl = string.Empty;

            using (var sqlConn = new SQLiteConnection("Data Source=C:\\SonarrDatabase\\SonarrInfoDatabase;Version=3;"))
            {
                sqlConn.Open();

                using (var sqlCmd = new SQLiteCommand(sql, sqlConn))
                {
                    SQLiteDataReader dr = sqlCmd.ExecuteReader();

                    while (dr.Read())
                    {
                        baseUrl = dr["IpAddress"].ToString();
                    }
                }
            }

            return baseUrl;
        }

        public IEnumerable<string> GetEmails()
        {
            var sql = "SELECT Address FROM EmailInfo";
            var emails = new List<string>();

            using (var sqlConn = new SQLiteConnection($"Data Source={ConfigurationManager.AppSettings["SonarrDatabasePath"]};Version=3;"))
            {
                sqlConn.Open();

                using (var sqlCmd = new SQLiteCommand(sql, sqlConn))
                {
                    var dr = sqlCmd.ExecuteReader();

                    while (dr.Read())
                    {
                        emails.Add(dr["Address"].ToString());
                    }
                }
            }

            return emails;
        }
    }
}
