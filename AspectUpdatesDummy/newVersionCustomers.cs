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
        MainMenu mainMenu;
        string versionID;
        int versionPK;

        public NewVersionCustomers(MainMenu m)
        {
            InitializeComponent();
            mainMenu = m;

            CustomersGrid.Columns.Clear();
            DataGridViewTextBoxColumn csPK = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn csName = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn csVersionPK = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn csVersionID = new DataGridViewTextBoxColumn();
            DataGridViewCheckBoxColumn csSelected = new DataGridViewCheckBoxColumn();

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
            CustomersGrid.Columns.Add(csVersionPK);

            csPK.DataPropertyName = "PK";
            csPK.HeaderText = "PK";
            csPK.Name = "PK";
            csPK.Visible = false;
            CustomersGrid.Columns.Add(csPK);

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
                        Database.AddUpdate(versionPK, Convert.ToInt32(row.Cells["PK"].Value.ToString()), date, date, "");
                    }
                }
            }catch(Exception ex){
                System.Console.WriteLine(ex.StackTrace);
            }

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
    }
}
