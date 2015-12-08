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
    public partial class NewEmployeePage : Form
    {

        ExistingEmployees mainMenu;

        public NewEmployeePage(ExistingEmployees m)
        {
            InitializeComponent();
            mainMenu = m;
        }

        private void mainMenuBtn1_Click(object sender, EventArgs e)
        {
            this.Close();
            mainMenu.Show();
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            string name = nameTxtBx.Text;

            Database.InsertEmployee(name);

            MessageBox.Show("Completed!");

            DataGridView dgv = mainMenu.getEmployeesGrid();
            dgv.DataSource = Database.GetEmployeeList();

            this.Hide();
            mainMenu.Show();
        }
    }
}
