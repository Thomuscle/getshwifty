using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AspectUpdatesDummy
{
    public partial class InspectCustomer : Form
    {

        ExistingCustomers customersPage;

        public InspectCustomer(ExistingCustomers ec)
        {
            InitializeComponent();
            customersPage = ec;

        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            customersPage.Show();
        }

        public void setFields(string name, string details, string version)
        {
            nameLabel.Text = "Name: " + name;
            detailsTextBox.Text = details;
            versionLabel.Text = "Current Version: " + version;

        }
    }
}
