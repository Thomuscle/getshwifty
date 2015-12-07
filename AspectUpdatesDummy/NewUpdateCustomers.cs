﻿using System;
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
    public partial class NewUpdateCustomers : Form
    {

        NewUpdatePage newUpdatePage;
        MainMenu mainMenu;
        int versionPK;
        DateTime? actualDate;
        DateTime expectedDate;
        string comment;

        public NewUpdateCustomers(NewUpdatePage nup, MainMenu m)
        {
            InitializeComponent();
            newUpdatePage = nup;
            mainMenu = m;

            CustomersGrid.Columns.Clear();
            DataGridViewTextBoxColumn csPK = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn csName = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn csVersionPK = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn csVersionID = new DataGridViewTextBoxColumn();
            DataGridViewCheckBoxColumn csSelected = new DataGridViewCheckBoxColumn();
            DataGridViewCheckBoxColumn csDetails = new DataGridViewCheckBoxColumn();
            

            csSelected.HeaderText = "Selected";
            csSelected.Name = "Selected";
            CustomersGrid.Columns.Add(csSelected);

            csName.DataPropertyName = "Name";
            csName.HeaderText = "Name";
            CustomersGrid.Columns.Add(csName);

            csVersionID.DataPropertyName = "VersionID";
            csVersionID.HeaderText = "Current Version";
            CustomersGrid.Columns.Add(csVersionID);

            csVersionPK.DataPropertyName = "VersionPK";
            csVersionPK.HeaderText = "Version PK";
            CustomersGrid.Columns.Add(csVersionPK);

            csPK.DataPropertyName = "PK";
            csPK.HeaderText = "PK";
            csPK.Name = "PK";
            csPK.Visible = false;
            CustomersGrid.Columns.Add(csPK);

            csDetails.DataPropertyName = "Details";
            csDetails.Visible = false;
            CustomersGrid.Columns.Add(csDetails);

            foreach (DataGridViewColumn dc in CustomersGrid.Columns)
            {
                if (dc.Index.Equals(0))
                {
                    dc.ReadOnly = false;
                }
                else
                {
                    dc.ReadOnly = true;
                }
            }
        }


        public DataGridView getCustomersGrid()
        {
            return CustomersGrid;
        }

        private void mainMenuBtn2_Click(object sender, EventArgs e)
        {
            this.Hide();
            newUpdatePage.Show();
        }

        public void GiveInfo(int versionPK, DateTime expectedDate, DateTime? actualDate, string comment)
        {
            this.versionPK = versionPK;
            this.expectedDate = expectedDate;
            this.actualDate = actualDate;
            this.comment = comment;
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in CustomersGrid.Rows)
                {
                    if ((row.Cells["Selected"].Value != null) && ((bool)((DataGridViewCheckBoxCell)row.Cells["Selected"]).Value))
                    {

                        if (actualDate != null)
                        {
                            Database.UpdateCustomer(Convert.ToInt32(row.Cells["PK"].Value.ToString()), versionPK);
                        }
                        Database.AddUpdate(versionPK, Convert.ToInt32(row.Cells["PK"].Value.ToString()), expectedDate, actualDate, comment);
                    }
                }
            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex.StackTrace);
            }

            MessageBox.Show("Completed!");
            this.Hide();
            mainMenu.Show();
        }
    }
}
