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
    public partial class EditVersion : Form
    {

        ExistingVersions versionsPage;
        int currentPK;

        public EditVersion(ExistingVersions ev)
        {
            InitializeComponent();
            versionsPage = ev;
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            versionsPage.Show();
            this.Hide();
        }

        public void setFields(string id, int type, string description, DateTime releaseDate, int pk)
        {
            idTxtBx.Text = id;
            typeCmboBx.SelectedItem = type.ToString();
            descriptionTxtBx.Text = description;
            releaseDateCal.SetDate(releaseDate);
            this.currentPK = pk;
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            Database.UpdateVersion(currentPK, idTxtBx.Text, descriptionTxtBx.Text, Convert.ToInt32(typeCmboBx.SelectedItem), Convert.ToDateTime(releaseDateCal.SelectionRange.Start.ToShortDateString()));

            MessageBox.Show("Completed!");

            DataGridView dgv = versionsPage.getVersionGrid();
            dgv.DataSource = Database.GetVersionList();

            versionsPage.Show();
            this.Hide();
        }
    }
}
