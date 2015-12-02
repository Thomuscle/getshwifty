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

        public ExistingCustomers(MainMenu m)
        {
            InitializeComponent();
            mainMenu = m;

            CustomersGrid.Columns.Clear();
            DataGridViewTextBoxColumn csPK = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn csName = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn csVersionPK = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn csVersionID = new DataGridViewTextBoxColumn();

            csName.DataPropertyName = "Name";
            csName.HeaderText = "Name";
            CustomersGrid.Columns.Add(csName);

            csVersionPK.DataPropertyName = "VersionPK";
            csVersionPK.HeaderText = "Version PK";
            CustomersGrid.Columns.Add(csVersionPK);

            csPK.DataPropertyName = "PK";
            csPK.HeaderText = "PK";
            CustomersGrid.Columns.Add(csPK);

            csVersionID.DataPropertyName = "VersionID";
            csVersionID.Visible = false;
            CustomersGrid.Columns.Add(csVersionID);

        }

        private void mainMenuBtn3_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainMenu.Show();
        }

        public DataGridView getVersionGrid()
        {
            return CustomersGrid;
        }
    }
}
