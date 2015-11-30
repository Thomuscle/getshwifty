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
        }

        private void mainMenuBtn1_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainMenu.Show();
        }
    }
}
