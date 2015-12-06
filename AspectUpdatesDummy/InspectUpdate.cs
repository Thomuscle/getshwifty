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
    public partial class InspectUpdate : Form
    {

        ExistingUpdates updatesPage;

        public InspectUpdate(ExistingUpdates eu)
        {
            InitializeComponent();
            updatesPage = eu;
        }

        public void setFields(int versionPK, int customerPK, DateTime expectedDate, DateTime? actualDate, string comment)
        {
            string versionID = Database.getVersionID(versionPK);

            string customerName = Database.getCustomerName(customerPK);
            
            versionLabel.Text = "Version: " + versionID;
            customerLabel.Text = "Customer: " + customerName;
            commentsTextBox.Text = comment;
            if (expectedDate == System.DateTime.MinValue)
            {
                expLbl.Text = "Expected Date: ";
            }
            else
            {
                expLbl.Text = "Expected Date: " + expectedDate;
            }

            if (actualDate == System.DateTime.MinValue)
            {
                actLbl.Text = "Actual Date: ";
            }
            else
            {
                actLbl.Text = "Actual Date: " + actualDate;
            }
            

        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            updatesPage.Show();
        }
    }
}
