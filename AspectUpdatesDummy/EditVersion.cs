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
            typeCmboBx.DataSource = Enum.GetValues(typeof(Version.TypeEnum));
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            versionsPage.Show();
            this.Hide();
        }

        public void setFields(string id, int? type, string description, DateTime releaseDate, int? pk, bool blueAspect, bool redAspect, bool webApp, bool webService)
        {
            idTxtBx.Text = id;
            typeCmboBx.SelectedItem = type.ToString();
            descriptionTxtBx.Text = description;
            releaseDateCal.SetDate(releaseDate);
            if(pk != null){
                this.currentPK = (int)pk;
            }
            blueAspectCB.Checked = blueAspect;
            redAspectCB.Checked = redAspect;
            webAppCB.Checked = webApp;
            webServiceCB.Checked = webService;
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            bool blueAspect = blueAspectCB.Checked;
            bool redAspect = redAspectCB.Checked;
            bool webApp = webAppCB.Checked;
            bool webService = webServiceCB.Checked;

            if (blueAspect || redAspect || webApp || webService)
            {

                Database.UpdateVersion(currentPK, idTxtBx.Text, descriptionTxtBx.Text, Convert.ToInt32(typeCmboBx.SelectedItem), Convert.ToDateTime(releaseDateCal.SelectionRange.Start.ToShortDateString()), blueAspect, redAspect, webApp, webService);

                MessageBox.Show("Completed!");

                DataGridView dgv = versionsPage.getVersionGrid();
                dgv.DataSource = Database.GetVersionList();

                versionsPage.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Version must include at least one piece of software.");
            }
        }
    }
}
