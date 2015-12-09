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
    public partial class NewVersionCustomers : Form
    {
        ExistingVersions mainMenu;
        NewVersionPage versionPage;
        string versionID;
        int versionPK;

        public NewVersionCustomers(ExistingVersions m, NewVersionPage nvp)
        {
            InitializeComponent();
            mainMenu = m;
            versionPage = nvp;

            CustomersGrid.Columns.Clear();
            DataGridViewTextBoxColumn csPK = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn csName = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn csVersionPK = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn csVersionID = new DataGridViewTextBoxColumn();
            DataGridViewCheckBoxColumn csSelected = new DataGridViewCheckBoxColumn();
            DataGridViewTextBoxColumn csPLC = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn csContacts = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn csLogonDetail = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn csDetail = new DataGridViewTextBoxColumn();

            csSelected.Name = "Selected";
            csSelected.HeaderText = "Selected";
            CustomersGrid.Columns.Add(csSelected);

            csName.DataPropertyName = "Name";
            csName.HeaderText = "Name";
            CustomersGrid.Columns.Add(csName);

            csVersionID.DataPropertyName = "VersionID";
            csVersionID.HeaderText = "Current Version";
            CustomersGrid.Columns.Add(csVersionID);

            csVersionPK.DataPropertyName = "VersionPK";
            csVersionPK.HeaderText = "Version PK";
            csVersionPK.Visible = false;
            CustomersGrid.Columns.Add(csVersionPK);

            csPK.DataPropertyName = "PK";
            csPK.HeaderText = "PK";
            csPK.Name = "PK";
            csPK.Visible = false;
            CustomersGrid.Columns.Add(csPK);

            csDetail.DataPropertyName = "Details";
            csDetail.Visible = false;
            CustomersGrid.Columns.Add(csDetail);

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
                if (dc.Index.Equals(0))
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

        private void submitBtn_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in CustomersGrid.Rows)
                {
                    if ((row.Cells[0].Value != null) && ((bool)((DataGridViewCheckBoxCell)row.Cells[0]).Value))
                    {
                        int versionPK = Database.UpdateCustomer(Convert.ToInt32(row.Cells["PK"].Value.ToString()));
                        
                        DateTime date = Convert.ToDateTime(actualDatePicker.Value.ToShortDateString() + ' ' + actualTimePicker.Value.ToShortTimeString());
                        Database.AddUpdate(versionPK, Convert.ToInt32(row.Cells["PK"].Value.ToString()), date, date, "", 0);
                    }
                }
            }catch(Exception ex){
                System.Console.WriteLine(ex.StackTrace);
            }

            DataGridView dgv = mainMenu.getVersionGrid();
            dgv.DataSource = Database.GetVersionList();

            MessageBox.Show("Completed!");
            this.Hide();
            mainMenu.Show();
        }

        public string VersionID{
            get { return versionID; }
            set { versionID = value; }
        }

        public int VersionPK
        {
            get { return versionPK; }
            set { versionPK = value; }
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
