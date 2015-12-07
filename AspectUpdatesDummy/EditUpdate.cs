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
    public partial class EditUpdate : Form
    {

        ExistingUpdates updatesPage;
        int currentPK;
        int currentCustomer;
        int currentVersion;

        public EditUpdate(ExistingUpdates eu)
        {
            InitializeComponent();
            updatesPage = eu;
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            updatesPage.Show();
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            DateTime expectedDate = Convert.ToDateTime(expectedDatePicker.Value.ToShortDateString() + ' ' + expectedTimePicker.Value.ToShortTimeString());
            DateTime actualDate = Convert.ToDateTime(actualDatePicker.Value.ToShortDateString() + ' ' + actualTimePicker.Value.ToShortTimeString());
            
            if (useActual.Checked)
            {
               Database.UpdateUpdate(currentPK, expectedDate, commentsTextBox.Text, actualDate);
               Database.UpdateCustomer(currentCustomer, currentVersion);
            }
            else
            {
                Database.UpdateUpdate(currentPK, expectedDate, commentsTextBox.Text);
            }
            
            MessageBox.Show("Completed!");

            DataGridView dgv = updatesPage.getUpdatesGrid();
            dgv.DataSource = Database.GetUpdateList();

            this.Hide();
            updatesPage.Show();
        }

        public void setFields(int versionPK, int customerPK, DateTime expectedDate, string comment, int pk)
        {
            currentPK = pk;
            currentCustomer = customerPK;
            currentVersion = versionPK;
            
            string versionID = Database.getVersionID(versionPK);

            string customerName = Database.getCustomerName(customerPK);

            versionLabel.Text = "Version: " + versionID;
            customerLabel.Text = "Customer: " + customerName;
            commentsTextBox.Text = comment;

            if (expectedDate != System.DateTime.MinValue)
            {
                expectedDatePicker.Text = expectedDate.ToShortDateString();
                expectedTimePicker.Text = expectedDate.ToLongTimeString();

                actualDatePicker.Text = expectedDate.ToShortDateString();
                actualTimePicker.Text = expectedDate.ToLongTimeString();
            }

        } 
    }
}
