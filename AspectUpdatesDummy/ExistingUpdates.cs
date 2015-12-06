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
    public partial class ExistingUpdates : Form
    {

        MainMenu mainMenu;
        InspectUpdate inspectUpdate;

        public ExistingUpdates(MainMenu m)
        {
            InitializeComponent();
            mainMenu = m;

            inspectUpdate = new InspectUpdate(this);

            UpdatesGrid.Columns.Clear();
            DataGridViewTextBoxColumn csPK = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn csCustomerPK = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn csVersionPK = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn csVersionExpDate = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn csVersionActDate = new DataGridViewTextBoxColumn();
            DataGridViewCheckBoxColumn csDeleted = new DataGridViewCheckBoxColumn();
            DataGridViewTextBoxColumn csComment = new DataGridViewTextBoxColumn();

            csCustomerPK.Name = "CustomerPK";
            csCustomerPK.DataPropertyName = "CustomerPK";
            csCustomerPK.HeaderText = "Customer PK";
            UpdatesGrid.Columns.Add(csCustomerPK);

            csVersionPK.Name = "VersionPK";
            csVersionPK.DataPropertyName = "VersionPK";
            csVersionPK.HeaderText = "Version PK";
            UpdatesGrid.Columns.Add(csVersionPK);

            csVersionExpDate.Name = "ExpectedDate";
            csVersionExpDate.DataPropertyName = "ExpectedDate";
            csVersionExpDate.HeaderText = "Expected Date";
            UpdatesGrid.Columns.Add(csVersionExpDate);

            csVersionActDate.Name = "ActualDate";
            csVersionActDate.DataPropertyName = "ActualDate";
            csVersionActDate.HeaderText = "Actual Date";
            UpdatesGrid.Columns.Add(csVersionActDate);

            csPK.Name = "PK";
            csPK.DataPropertyName = "PK";
            csPK.Visible = false;
            UpdatesGrid.Columns.Add(csPK);

            csComment.Name = "Comment";
            csComment.DataPropertyName = "Comment";
            csComment.Visible = false;
            UpdatesGrid.Columns.Add(csComment);

            csDeleted.Name = "isDeleted";
            csDeleted.DataPropertyName = "isDeleted";
            csDeleted.HeaderText = "Deleted";
            UpdatesGrid.Columns.Add(csDeleted);

        }

        private void mainMenuBtn5_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainMenu.Show();
        }

        public DataGridView getUpdatesGrid()
        {
            return UpdatesGrid;
        }

        private void inspectBtn_Click(object sender, EventArgs e)
        {
            string comment = UpdatesGrid.SelectedRows[0].Cells["Comment"].Value.ToString();
            int versionPK = (int)UpdatesGrid.SelectedRows[0].Cells["VersionPK"].Value;
            int customerPK = (int)UpdatesGrid.SelectedRows[0].Cells["CustomerPK"].Value;
            int pk = (int)UpdatesGrid.SelectedRows[0].Cells["PK"].Value;
            DateTime expectedDate = Convert.ToDateTime(UpdatesGrid.SelectedRows[0].Cells["ExpectedDate"].Value);
            DateTime? actualDate = Convert.ToDateTime(UpdatesGrid.SelectedRows[0].Cells["ActualDate"].Value);

            inspectUpdate.setFields(versionPK, customerPK, expectedDate, actualDate, comment);

            inspectUpdate.Show();
            this.Hide();
        }
    }
}
