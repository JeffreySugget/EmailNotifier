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
            var currentDir = System.Environment.CurrentDirectory;

            if (!File.Exists($"{Environment.CurrentDirectory}\\SonarrInfoDatabase"))
            {
                SQLiteConnection.CreateFile("SonarrInfoDatabase");
            }
        }
    }
}
