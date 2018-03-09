using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ApiLibrary.Interfaces;
using ApiLibrary.Classes;

namespace DatabaseInterface.Classes
{
    public static class DatabaseHelper
    {
        private static readonly IConfigurationHelper _configurationHelper = new ConfigurationHelper();

        public static void ExecuteNonQuery(string sql)
        {
            using (var sqlConn = new SQLiteConnection(_configurationHelper.ConnectionString))
            {
                sqlConn.Open();

                using (var sqlCmd = new SQLiteCommand(sql, sqlConn))
                {
                    sqlCmd.ExecuteNonQuery();
                }
            }
        }

        public static bool CheckForDatabase()
        {
            if (!File.Exists(ConfigurationManager.AppSettings["SonarrDatabasePath"]))
            {
                return false;
            }

            return true;
        }
    }
}
