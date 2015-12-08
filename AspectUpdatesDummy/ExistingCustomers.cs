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
    public partial class ExistingCustomers : Form
    {

        MainMenu mainMenu;
        EditCustomer editCustomer;
        InspectCustomer inspectCustomer;
        NewCustomerPage newCustomerPage;

        public ExistingCustomers(MainMenu m)
        {
            InitializeComponent();
            mainMenu = m;

            editCustomer = new EditCustomer(this);
            inspectCustomer = new InspectCustomer(this);

            CustomersGrid.Columns.Clear();
            DataGridViewTextBoxColumn csPK = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn csName = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn csVersionPK = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn csVersionID = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn csDetails = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn csPLC = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn csContacts = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn csLogonDetail = new DataGridViewTextBoxColumn();

            csName.Name = "Name";
            csName.DataPropertyName = "Name";
            csName.HeaderText = "Name";
            CustomersGrid.Columns.Add(csName);

            csVersionPK.Name = "VersionPK";
            csVersionPK.DataPropertyName = "VersionPK";
            csVersionPK.HeaderText = "Version PK";
            csVersionPK.Visible = false;
            CustomersGrid.Columns.Add(csVersionPK);

            csPK.Name = "PK";
            csPK.DataPropertyName = "PK";
            csPK.HeaderText = "PK";
            csPK.Visible = false;
            CustomersGrid.Columns.Add(csPK);

            csVersionID.Name = "VersionID";
            csVersionID.HeaderText = "Version";
            csVersionID.DataPropertyName = "VersionID";
            CustomersGrid.Columns.Add(csVersionID);

            csDetails.Name = "Details";
            csDetails.DataPropertyName = "Details";
            csDetails.Visible = false;
            CustomersGrid.Columns.Add(csDetails);

            csPLC.Name = "PLC";
            csPLC.DataPropertyName = "PLC";
            csPLC.HeaderText = "PLC";
            csPLC.Visible = false;
            CustomersGrid.Columns.Add(csPLC);

            csContacts.Name = "Contacts";
            csContacts.DataPropertyName = "Contacts";
            csContacts.HeaderText = "Contacts";
            csContacts.Visible = false;
            CustomersGrid.Columns.Add(csContacts);

            csLogonDetail.Name = "LogonDetail";
            csLogonDetail.DataPropertyName = "LogonDetails";
            csLogonDetail.HeaderText = "Logon Details";
            csLogonDetail.Visible = false;
            CustomersGrid.Columns.Add(csLogonDetail);

        }

        private void mainMenuBtn3_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainMenu.Show();
        }

        public DataGridView getCustomersGrid()
        {
            return CustomersGrid;
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            string name = CustomersGrid.SelectedRows[0].Cells["Name"].Value.ToString();
            string details = CustomersGrid.SelectedRows[0].Cells["Details"].Value.ToString();
            int versionPK = Convert.ToInt32(CustomersGrid.SelectedRows[0].Cells["VersionPK"].Value);
            int pk = Convert.ToInt32(CustomersGrid.SelectedRows[0].Cells["PK"].Value);
            string versionID = CustomersGrid.SelectedRows[0].Cells["VersionID"].Value.ToString();
            string plc = CustomersGrid.SelectedRows[0].Cells["PLC"].Value.ToString();
            string contacts = CustomersGrid.SelectedRows[0].Cells["Contacts"].Value.ToString();
            string logon = CustomersGrid.SelectedRows[0].Cells["LogonDetail"].Value.ToString();
            
            editCustomer.setFields(name, details, versionID, pk, plc, contacts, logon);

            editCustomer.Show();
            this.Hide();
        }

        private void inspectBtn_Click(object sender, EventArgs e)
        {
            string name = CustomersGrid.SelectedRows[0].Cells["Name"].Value.ToString();
            string details = CustomersGrid.SelectedRows[0].Cells["Details"].Value.ToString();
            int versionPK = Convert.ToInt32(CustomersGrid.SelectedRows[0].Cells["VersionPK"].Value);
            string plc = CustomersGrid.SelectedRows[0].Cells["PLC"].Value.ToString();
            string contacts = CustomersGrid.SelectedRows[0].Cells["Contacts"].Value.ToString();
            string logon = CustomersGrid.SelectedRows[0].Cells["LogonDetail"].Value.ToString();

            string versionID = Database.getVersionID(versionPK);

            inspectCustomer.setFields(name, details, versionID, plc, contacts, logon);

            inspectCustomer.Show();
            this.Hide();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure you want to delete this customer?",
                                     "Confirm Deletion",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                int pk = (int)CustomersGrid.SelectedRows[0].Cells["PK"].Value;
                Database.deleteCustomer(pk);

                CustomersGrid.DataSource = Database.GetCustomerList();
            }
        }

        private void mainAddCustBtn_Click(object sender, EventArgs e)
        {
            newCustomerPage = new NewCustomerPage(this);
            DataGridView dgv = newCustomerPage.getVersionGrid();
            dgv.DataSource = Database.GetVersionList();
            newCustomerPage.Show();
            this.Hide();
        }
    }
}
