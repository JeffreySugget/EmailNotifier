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
            if (string.IsNullOrWhiteSpace(txtWorkingDir.Text))
            {
                MessageBox.Show("Please enter your working directory before continuing!", MessageHeading.Error);
                return;
            }
            else if (!File.Exists(txtWorkingDir.Text))
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
        }
    }
}
