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
    public partial class NewUpdateCustomers : Form
    {

        NewUpdatePage newUpdatePage;
        ExistingUpdates mainMenu;
        int versionPK;
        DateTime? actualDate;
        DateTime? expectedDate;
        string comment;

        public NewUpdateCustomers(NewUpdatePage nup, ExistingUpdates m)
        {
            InitializeComponent();
            newUpdatePage = nup;
            mainMenu = m;

            CustomersGrid.Columns.Clear();
            DataGridViewTextBoxColumn csPK = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn csName = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn csVersionPK = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn csVersionID = new DataGridViewTextBoxColumn();
            DataGridViewCheckBoxColumn csSelected = new DataGridViewCheckBoxColumn();
            DataGridViewTextBoxColumn csDetails = new DataGridViewTextBoxColumn();
            DataGridViewComboBoxColumn csAssigned = new DataGridViewComboBoxColumn();
            DataGridViewTextBoxColumn csPLC = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn csContacts = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn csLogonDetail = new DataGridViewTextBoxColumn();
            

            csSelected.HeaderText = "Selected";
            csSelected.Name = "Selected";
            CustomersGrid.Columns.Add(csSelected);

            csName.DataPropertyName = "Name";
            csName.HeaderText = "Name";
            CustomersGrid.Columns.Add(csName);

            csVersionID.DataPropertyName = "VersionID";
            csVersionID.HeaderText = "Current Version";
            CustomersGrid.Columns.Add(csVersionID);

            csAssigned.Name = "AssignedTo";
            csAssigned.HeaderText = "Assign To";
            csAssigned.ValueMember = "PK";
            csAssigned.DisplayMember = "Name";
            csAssigned.DataSource = Database.GetEmployeeList();
            csAssigned.ValueType = typeof(Employee);
           
            CustomersGrid.Columns.Add(csAssigned);

            csVersionPK.DataPropertyName = "VersionPK";
            csVersionPK.HeaderText = "Version PK";
            csVersionPK.Visible = false;
            CustomersGrid.Columns.Add(csVersionPK);

            csPK.DataPropertyName = "PK";
            csPK.HeaderText = "PK";
            csPK.Name = "PK";
            csPK.Visible = false;
            CustomersGrid.Columns.Add(csPK);

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

            foreach (DataGridViewColumn dc in CustomersGrid.Columns)
            {
                if (dc.Index.Equals(0) || dc.Index.Equals(3))
                {
                    dc.ReadOnly = false;
                }
                else
                {
                    dc.ReadOnly = true;
                }
            }
        }


        public DataGridView getCustomersGrid()
        {
            return CustomersGrid;
        }

        private void mainMenuBtn2_Click(object sender, EventArgs e)
        {
            this.Hide();
            newUpdatePage.Show();
        }

        public void GiveInfo(int versionPK, DateTime? expectedDate, DateTime? actualDate, string comment)
        {
            this.versionPK = versionPK;
            this.expectedDate = expectedDate;
            this.actualDate = actualDate;
            this.comment = comment;
            
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in CustomersGrid.Rows)
                {
                    if ((row.Cells["Selected"].Value != null) && ((bool)((DataGridViewCheckBoxCell)row.Cells["Selected"]).Value))
                    {

                        /*if (actualDate != null)
                        {
                            Database.UpdateCustomer(Convert.ToInt32(row.Cells["PK"].Value.ToString()), versionPK);
                            
                        }*/

                        int employeePK = Convert.ToInt32(row.Cells["AssignedTo"].Value);

                        Database.AddUpdate(versionPK, Convert.ToInt32(row.Cells["PK"].Value.ToString()), expectedDate, actualDate, comment, employeePK);
                    }
                }
            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex.StackTrace);
            }

            MessageBox.Show("Completed!");

            DataGridView dgv = mainMenu.getUpdatesGrid();
            dgv.DataSource = Database.GetUpdateList();

            mainMenu.getCurrentButton().Text = "All";

            this.Hide();
            mainMenu.Show();
        }

        private void selectButton_Click(object sender, EventArgs e)
        {
            if (selectButton.Text.Equals("Select All"))
            {
                foreach (DataGridViewRow row in CustomersGrid.Rows)
                {
                    // This will check the cell.
                    row.Cells["Selected"].Value = true;
                }
                selectButton.Text = "Deselect All";
            }
            else
            {
                foreach (DataGridViewRow row in CustomersGrid.Rows)
                {
                    // This will check the cell.
                    row.Cells["Selected"].Value = null;
                }
                selectButton.Text = "Select All";
            }
        }
    }
}
