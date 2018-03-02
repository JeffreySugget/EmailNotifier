using ApiLibrary.Classes;
using ApiLibrary.Interfaces;
using ApiLibrary.Models;
using DatabaseInterface.Classes;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Configuration;

namespace DatabaseInterface
{
    public partial class Shows : Form
    {
        private readonly IDataHelper _dataHelper = new DataHelper();
        private readonly IApiHelper _apiHelper = new ApiHelper(new DataHelper());

        public Shows()
        {
            InitializeComponent();
            CreateGridView();
        }

        private void FillDataView()
        {
            var sql = "SELECT ShowName, Address FROM ShowInfo INNER JOIN EmailInfo on ShowInfo.EmailId = EmailInfo.Id";
            var shows = new List<Show>();

            using (var sqlConn = new SQLiteConnection($"Data Source={ConfigurationManager.AppSettings["SonarrDatabasePath"]};Version=3;"))
            {
                sqlConn.Open();

                using (var sqlCmd = new SQLiteCommand(sql, sqlConn))
                {
                    var dr = sqlCmd.ExecuteReader();

                    while (dr.Read())
                    {
                        shows.Add(new Show
                        {
                            Name = dr["ShowName"].ToString(),
                            EmailAddress = dr["Address"].ToString()
                        });
                    }
                }
            }

            if (shows.Count > 0)
            {
                //fill data view
            }
        }

        private void btnRefreshShows_Click(object sender, EventArgs e)
        {
            try
            {
                DatabaseHelper.CheckForDatabase();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, MessageHeading.Error);
                return;
            }

            var json = _apiHelper.Get(_dataHelper.GetApiCall("api/series"));

            var data = JsonConvert.DeserializeObject<List<SeriesRoot>>(json);

            var col = new DataGridViewComboBoxColumn
            {
                HeaderText = "EmailAddress",
                Name = "emailAddress"
            };

            foreach (var email in GetEmails())
            {
                col.Items.Add(email);
            }

            dgShows.Columns.Add(col);

            dgShows.Rows.Add(data.Count);

            for (var i = 0; i < dgShows.Rows.Count - 1; i++)
            {
                dgShows.Rows[i].Cells[0].Value = data[i].Title;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var sql = "INSERT INTO ShowInfo (ShowName, EmailId) VALUES (@ShowName, (SELECT Id FROM EmailInfo WHERE Address = @Address))";

            foreach (DataGridViewRow r in dgShows.Rows)
            {
                if (r.Cells[1].Value == null)
                {
                    MessageBox.Show("Not all shows have emails selected.", MessageHeading.Error);
                    return;
                }

                using (var sqlConn = new SQLiteConnection($"Data Source={ConfigurationManager.AppSettings["SonarrDatabasePath"]};Version=3;"))
                {
                    sqlConn.Open();

                    using (var sqlCmd = new SQLiteCommand(sql, sqlConn))
                    {
                        sqlCmd.Parameters.AddWithValue("@ShowName", r.Cells[0].Value);
                        sqlCmd.Parameters.AddWithValue("@Address", r.Cells[1].Value);

                        sqlCmd.ExecuteNonQuery();
                    }
                }
            }
        }

        private void CreateGridView()
        {
            dgShows.Columns.Add("showTitle", "ShowTitle");
        }

        private IEnumerable<string> GetEmails()
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
