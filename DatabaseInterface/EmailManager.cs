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
        }
    }
}
