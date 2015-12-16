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
        EditUpdate editUpdate;
        NewUpdatePage newUpdatePage;
        DataGridViewCheckBoxColumn csDone;

        public ExistingUpdates(MainMenu m)
        {
            InitializeComponent();
            mainMenu = m;

            inspectUpdate = new InspectUpdate(this);
            editUpdate = new EditUpdate(this);

            UpdatesGrid.Columns.Clear();
            DataGridViewTextBoxColumn csPK = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn csCustomerPK = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn csVersionPK = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn csCustomerName = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn csVersionID = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn csEmployee = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn csVersionExpDate = new DataGridViewTextBoxColumn();
            DataGridViewCheckBoxColumn csDeleted = new DataGridViewCheckBoxColumn();
            DataGridViewTextBoxColumn csComment = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn csContactedDate = new DataGridViewTextBoxColumn();
            DataGridViewCheckBoxColumn csContacted = new DataGridViewCheckBoxColumn();
            DataGridViewTextBoxColumn csVersionActDate = new DataGridViewTextBoxColumn();
            csDone = new DataGridViewCheckBoxColumn();

            csPK.Name = "PK";
            csPK.DataPropertyName = "PK";
            csPK.Visible = false;
            UpdatesGrid.Columns.Add(csPK);

            csCustomerPK.Name = "CustomerPK";
            csCustomerPK.DataPropertyName = "CustomerPK";
            csCustomerPK.HeaderText = "Customer PK";
            csCustomerPK.Visible = false;
            UpdatesGrid.Columns.Add(csCustomerPK);

            csCustomerName.Name = "CustomerName";
            csCustomerName.DataPropertyName = "CustomerName";
            csCustomerName.HeaderText = "Customer Name";
            UpdatesGrid.Columns.Add(csCustomerName);

            csVersionPK.Name = "VersionPK";
            csVersionPK.DataPropertyName = "VersionPK";
            csVersionPK.HeaderText = "Version PK";
            csVersionPK.Visible = false;
            UpdatesGrid.Columns.Add(csVersionPK);

            csVersionID.Name = "VersionID";
            csVersionID.DataPropertyName = "VersionID";
            csVersionID.HeaderText = "Version";
            UpdatesGrid.Columns.Add(csVersionID);

            csVersionExpDate.Name = "ExpectedDate";
            csVersionExpDate.DataPropertyName = "ExpectedDate";
            csVersionExpDate.HeaderText = "Expected Date";
            UpdatesGrid.Columns.Add(csVersionExpDate);

            csComment.Name = "Comment";
            csComment.DataPropertyName = "Comment";
            csComment.Visible = false;
            UpdatesGrid.Columns.Add(csComment);

            csDeleted.Name = "isDeleted";
            csDeleted.DataPropertyName = "isDeleted";
            csDeleted.HeaderText = "Deleted";
            csDeleted.Visible = false;
            UpdatesGrid.Columns.Add(csDeleted);

            csEmployee.Name = "AssignedTo"; 
            csEmployee.HeaderText = "Assigned To";
            csEmployee.DataPropertyName = "Employee";
            csEmployee.Visible = false;
            UpdatesGrid.Columns.Add(csEmployee);

            csContactedDate.Name = "ContactedDate";
            csContactedDate.DataPropertyName = "ContactedDate";
            csContactedDate.HeaderText = "Contacted Date";
            UpdatesGrid.Columns.Add(csContactedDate);

            csContacted.Name = "Contacted";
            csContacted.HeaderText = "Has Been Contacted";
            csContacted.DataPropertyName = "Contacted";
            UpdatesGrid.Columns.Add(csContacted);

            csVersionActDate.Name = "ActualDate";
            csVersionActDate.DataPropertyName = "ActualDate";
            csVersionActDate.HeaderText = "Actual Date";
            UpdatesGrid.Columns.Add(csVersionActDate);

            csDone.Name = "isDone";
            csDone.HeaderText = "Done";
            csDone.DataPropertyName = "Done";
            UpdatesGrid.Columns.Add(csDone);

            foreach (DataGridViewColumn dc in UpdatesGrid.Columns)
            {
                if (dc.Index.Equals(10) || dc.Index.Equals(12))
                {
                    dc.ReadOnly = false;
                }
                else
                {
                    dc.ReadOnly = true;
                }
            }

        }

        private void mainMenuBtn5_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainMenu.Show();
            currentVersionBtn.Text = "All";
        }

        public DataGridView getUpdatesGrid()
        {
            return UpdatesGrid;
        }

        public Button getCurrentButton()
        {
            return currentVersionBtn;
        }

        private void inspectBtn_Click(object sender, EventArgs e)
        {
            string comment = UpdatesGrid.SelectedRows[0].Cells["Comment"].Value.ToString();
            int versionPK = (int)UpdatesGrid.SelectedRows[0].Cells["VersionPK"].Value;
            int customerPK = (int)UpdatesGrid.SelectedRows[0].Cells["CustomerPK"].Value;
            int pk = (int)UpdatesGrid.SelectedRows[0].Cells["PK"].Value;
            DateTime expectedDate = Convert.ToDateTime(UpdatesGrid.SelectedRows[0].Cells["ExpectedDate"].Value);
            DateTime? actualDate = Convert.ToDateTime(UpdatesGrid.SelectedRows[0].Cells["ActualDate"].Value);
            bool contacted = (bool)UpdatesGrid.SelectedRows[0].Cells["Contacted"].Value;
            int employeePK;
            if (UpdatesGrid.SelectedRows[0].Cells["AssignedTo"].Value == null)
            {
                employeePK = 0;
            }
            else
            {
                employeePK = (int)UpdatesGrid.SelectedRows[0].Cells["AssignedTo"].Value;
            }
            
            inspectUpdate.setFields(versionPK, customerPK, expectedDate, actualDate, comment, employeePK, contacted);

            inspectUpdate.Show();
            this.Hide();
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            string comment = UpdatesGrid.SelectedRows[0].Cells["Comment"].Value.ToString();
            int versionPK = (int)UpdatesGrid.SelectedRows[0].Cells["VersionPK"].Value;
            int customerPK = (int)UpdatesGrid.SelectedRows[0].Cells["CustomerPK"].Value;
            int pk = (int)UpdatesGrid.SelectedRows[0].Cells["PK"].Value;
            DateTime expectedDate = Convert.ToDateTime(UpdatesGrid.SelectedRows[0].Cells["ExpectedDate"].Value);
            DateTime? actualDate = Convert.ToDateTime(UpdatesGrid.SelectedRows[0].Cells["ActualDate"].Value);
            bool contacted = (bool)UpdatesGrid.SelectedRows[0].Cells["Contacted"].Value;
            bool done = (bool)UpdatesGrid.SelectedRows[0].Cells["isDone"].Value;
            int employeePK;
            if (UpdatesGrid.SelectedRows[0].Cells["AssignedTo"].Value == null)
            {
                employeePK = 0;
            }
            else
            {
                employeePK = (int)UpdatesGrid.SelectedRows[0].Cells["AssignedTo"].Value;
            }

                editUpdate.setFields(versionPK, customerPK, expectedDate, comment, pk, employeePK, contacted, done);

                editUpdate.Show();
                this.Hide();
           
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure you want to delete this update?",
                                    "Confirm Deletion",
                                    MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                int pk = (int)UpdatesGrid.SelectedRows[0].Cells["PK"].Value;
                Database.deleteUpdate(pk);

                UpdatesGrid.DataSource = Database.GetUpdateList();
                currentVersionBtn.Text = "All";
            }
        }

        private void mainAddVersBtn_Click(object sender, EventArgs e)
        {
            newUpdatePage = new NewUpdatePage(this);
            DataGridView dgv = newUpdatePage.getVersionGrid();
            dgv.DataSource = Database.GetVersionList();
            dgv.Columns[2].Visible = false;
            dgv.Columns[0].Visible = false;
            newUpdatePage.Show();
            this.Hide();
        }

        private void currentVersionBtn_Click(object sender, EventArgs e)
        {
            if (currentVersionBtn.Text.Equals("All"))
            {
                int currentPK = Database.getLatestVersion();
                UpdatesGrid.DataSource = Database.GetUpdatesWithVersion(currentPK);
                currentVersionBtn.Text = "Current Version";
            }
            else
            {
                UpdatesGrid.DataSource = Database.GetUpdateList();
                currentVersionBtn.Text = "All";
            }
        }

        private void UpdatesGrid_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 11 && e.RowIndex != -1)
            {
                Database.changeUpdateDone(Convert.ToInt32(UpdatesGrid.Rows[e.RowIndex].Cells[0].Value), Convert.ToBoolean(UpdatesGrid.Rows[e.RowIndex].Cells[11].Value));
                UpdatesGrid.DataSource = Database.GetUpdateList();
                UpdatesGrid.Rows[e.RowIndex].Selected = true;
            }
            if (e.ColumnIndex == 9 && e.RowIndex != -1)
            {
                Database.changeUpdateContacted(Convert.ToInt32(UpdatesGrid.Rows[e.RowIndex].Cells[0].Value), Convert.ToBoolean(UpdatesGrid.Rows[e.RowIndex].Cells[9].Value));
                UpdatesGrid.DataSource = Database.GetUpdateList();
                UpdatesGrid.Rows[e.RowIndex].Selected = true;
            }
        }

        private void UpdatesGrid_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            // End of edition on each click on column of checkbox
            if (e.ColumnIndex == 11 && e.RowIndex != -1)
            {
                UpdatesGrid.EndEdit();
            }
            if (e.ColumnIndex == 9 && e.RowIndex != -1)
            {
                UpdatesGrid.EndEdit();
            }
        }
    }
}
