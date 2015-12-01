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
    public partial class NewCustomerPage : Form
    {

        MainMenu mainMenu;

        public NewCustomerPage(MainMenu m)
        {
            InitializeComponent();
            mainMenu = m;

            versionGrid.Columns.Clear();
            DataGridViewTextBoxColumn csPK = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn csID = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn csType = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn csReleaseDate = new DataGridViewTextBoxColumn();

            csID.DataPropertyName = "ID"; 
            csID.HeaderText = "Version ID";
            versionGrid.Columns.Add(csID);

            csType.DataPropertyName = "Type";
            csType.HeaderText = "Type";
            versionGrid.Columns.Add(csType);

            csReleaseDate.DataPropertyName = "ReleaseDate";
            csReleaseDate.HeaderText = "Release Date";
            versionGrid.Columns.Add(csReleaseDate);

            csPK.DataPropertyName = "PK";
            csPK.HeaderText = "PK";
            versionGrid.Columns.Add(csPK);

        }

        private void mainMenuBtn1_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainMenu.Show();
        }

        private void NewCustomerPage_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'versionDatabase1DataSet1.Version' table. You can move, or remove it, as needed.
            this.versionTableAdapter.Fill(this.versionDatabase1DataSet1.Version);
            // TODO: This line of code loads data into the 'versionDatabase1DataSet1.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.versionDatabase1DataSet1.Customer);

        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            string name = nameTxtBx.Text;
            string details = descriptionTxtBx.Text;
            int versionPK = (int)versionGrid.SelectedCells[0].Value;
            Database.InsertCustomer(name, details, versionPK);
        }

        public DataGridView getVersionGrid()
        {
            return versionGrid;
        }
    }
}
