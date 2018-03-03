using System;
using System.Configuration;
using System.Windows.Forms;
using System.IO;
using DatabaseInterface.Classes;

namespace DatabaseInterface
{
    public partial class DatabaseInterface : Form
    {
        public DatabaseInterface()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (File.Exists(ConfigurationManager.AppSettings["SonarrDatabasePath"]))
            {
                MessageBox.Show("Database already created, please use update", MessageHeading.Error);
                return;
            }

            var createForm = new Create();

            createForm.Show();

            Hide();
        }
    }
}
