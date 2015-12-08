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
    public partial class EditCustomer : Form
    {

        ExistingCustomers customersPage;
        int currentPK;

        public EditCustomer(ExistingCustomers ec)
        {
            InitializeComponent();
            customersPage = ec;
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            customersPage.Show();
        }

        public void setFields(string name, string details, string versionID, int currentPK, string plc, string contacts, string logon)
        {
            nameTxtBx.Text = name;
            versionTextBox.Text = versionID;
            detailsTxtBx.Text = details;
            plcTB.Text = plc;
            contactsTB.Text = contacts;
            logonTB.Text = logon;
            this.currentPK = currentPK;
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            Database.UpdateCustomer(currentPK, nameTxtBx.Text, detailsTxtBx.Text, plcTB.Text, contactsTB.Text, logonTB.Text);
            
            MessageBox.Show("Completed!");

            DataGridView dgv = customersPage.getCustomersGrid();
            dgv.DataSource = Database.GetCustomerList();

            this.Hide();
            customersPage.Show();
        }
    }
}
