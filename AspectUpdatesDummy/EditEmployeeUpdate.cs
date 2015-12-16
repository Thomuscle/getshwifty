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
    public partial class EditEmployeeUpdate : Form
    {

        InspectEmployee inspectEmployee;
        int currentPK;
        int currentEmployee;
        int currentCustomer;
        int currentVersion;
        bool wasContacted;
        bool wasDone;

        public EditEmployeeUpdate(InspectEmployee ie)
        {
            InitializeComponent();
            inspectEmployee = ie;
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            inspectEmployee.Show();
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            DateTime expectedDate = Convert.ToDateTime(expectedDatePicker.Value.ToShortDateString() + ' ' + expectedTimePicker.Value.ToShortTimeString());
            DateTime actualDate = Convert.ToDateTime(actualDatePicker.Value.ToShortDateString() + ' ' + actualTimePicker.Value.ToShortTimeString());
            int employee = Convert.ToInt32(employeeComboBox.SelectedValue);

           
                bool contacted = contactedCB.Checked;

                if (useActual.Checked)
                {
                    Database.UpdateUpdate(currentPK, expectedDate, commentsTextBox.Text, actualDate, employee, contacted, wasContacted, true, wasDone);
                    Database.UpdateCustomer(currentCustomer, currentVersion);
                }
                else
                {
                    Database.UpdateUpdate(currentPK, expectedDate, commentsTextBox.Text, employee, contacted, wasContacted, false);
                }
           

            MessageBox.Show("Completed!");

            DataGridView dgv = inspectEmployee.getUpdatesGrid();
            if (inspectEmployee.ToggleText.Equals("All"))
            {
                dgv.DataSource = Database.GetAllUpdatesAssignedTo(currentEmployee);
            }
            else
            {
                dgv.DataSource = Database.GetIncompleteUpdatesAssignedTo(currentEmployee);
            }

            this.Hide();
            inspectEmployee.Show();
        }

        public void setFields(int versionPK, int customerPK, DateTime expectedDate, string comment, int pk, int employeePK, bool? contacted, bool done)
        {
            currentPK = pk;
            currentEmployee = employeePK;
            currentCustomer = customerPK;
            currentVersion = versionPK;

            useActual.Checked = done;

            if (done)
            {
                wasDone = true;
            }
            else
            {
                wasDone = false;
            }

            string versionID = Database.getVersionID(versionPK);

            string customerName = Database.getCustomerName(customerPK);

            List<Employee> employeeList = Database.GetEmployeeList();

            employeeComboBox.ValueMember = "PK";
            employeeComboBox.DisplayMember = "Name";
            employeeComboBox.DataSource = employeeList;
            employeeComboBox.SelectedIndex = employeeList.FindIndex(k => k.PK == employeePK);

            versionLabel.Text = "Version: " + versionID;
            customerLabel.Text = "Customer: " + customerName;
            commentsTextBox.Text = comment;

            if (expectedDate != System.DateTime.MinValue)
            {
                expectedDatePicker.Text = expectedDate.ToShortDateString();
                expectedTimePicker.Text = expectedDate.ToLongTimeString();

                actualDatePicker.Text = DateTime.Now.ToShortDateString();
                actualTimePicker.Text = DateTime.Now.ToLongTimeString();
            }

            if (contacted == true)
            {
                contactedCB.Checked = true;
                wasContacted = true;
            }
            else
            {
                contactedCB.Checked = false;
                wasContacted = false;
            }
        }

        private void contactedCB_CheckedChanged(object sender, EventArgs e)
        {
            wasContacted = false;
        }

        private void useActual_CheckedChanged(object sender, EventArgs e)
        {
            actualDatePicker.Text = DateTime.Now.ToShortDateString();
            actualTimePicker.Text = DateTime.Now.ToLongTimeString();
            wasDone = false;
        }
       
    }
}
