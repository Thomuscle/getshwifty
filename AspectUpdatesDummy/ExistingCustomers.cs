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

        public ExistingCustomers(MainMenu m)
        {
            InitializeComponent();
            mainMenu = m;

            editCustomer = new EditCustomer(this);

            CustomersGrid.Columns.Clear();
            DataGridViewTextBoxColumn csPK = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn csName = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn csVersionPK = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn csVersionID = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn csDetails = new DataGridViewTextBoxColumn();

            csName.Name = "Name";
            csName.DataPropertyName = "Name";
            csName.HeaderText = "Name";
            CustomersGrid.Columns.Add(csName);

            csVersionPK.Name = "VersionPK";
            csVersionPK.DataPropertyName = "VersionPK";
            csVersionPK.HeaderText = "Version PK";
            CustomersGrid.Columns.Add(csVersionPK);

            csPK.Name = "PK";
            csPK.DataPropertyName = "PK";
            csPK.HeaderText = "PK";
            CustomersGrid.Columns.Add(csPK);

            csVersionID.DataPropertyName = "VersionID";
            csVersionID.Visible = false;
            csVersionID.DataPropertyName = "VersionID";
            CustomersGrid.Columns.Add(csVersionID);

            csDetails.Name = "Details";
            csDetails.DataPropertyName = "Details";
            csDetails.Visible = false;
            CustomersGrid.Columns.Add(csDetails);

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

            string versionID = Database.getVersionID(versionPK);
            
            editCustomer.setFields(name, details, versionID, pk);

            editCustomer.Show();
            this.Hide();
        }
    }
}
