namespace AspectUpdatesDummy
{
    partial class ExistingCustomers
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExistingCustomers));
            this.inspectBtn = new System.Windows.Forms.Button();
            this.editBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.mainMenuBtn3 = new System.Windows.Forms.Button();
            this.CustLbl = new System.Windows.Forms.Label();
            this.CustomersGrid = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.mainAddCustBtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.CustomersGrid)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // inspectBtn
            // 
            resources.ApplyResources(this.inspectBtn, "inspectBtn");
            this.inspectBtn.Name = "inspectBtn";
            this.inspectBtn.UseVisualStyleBackColor = true;
            this.inspectBtn.Click += new System.EventHandler(this.inspectBtn_Click);
            // 
            // editBtn
            // 
            resources.ApplyResources(this.editBtn, "editBtn");
            this.editBtn.Name = "editBtn";
            this.editBtn.UseVisualStyleBackColor = true;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // deleteBtn
            // 
            resources.ApplyResources(this.deleteBtn, "deleteBtn");
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // mainMenuBtn3
            // 
            resources.ApplyResources(this.mainMenuBtn3, "mainMenuBtn3");
            this.mainMenuBtn3.Name = "mainMenuBtn3";
            this.mainMenuBtn3.UseVisualStyleBackColor = true;
            this.mainMenuBtn3.Click += new System.EventHandler(this.mainMenuBtn3_Click);
            // 
            // CustLbl
            // 
            resources.ApplyResources(this.CustLbl, "CustLbl");
            this.CustLbl.Name = "CustLbl";
            // 
            // CustomersGrid
            // 
            this.CustomersGrid.AllowUserToAddRows = false;
            this.CustomersGrid.AllowUserToDeleteRows = false;
            this.CustomersGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CustomersGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.CustomersGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.CustomersGrid, "CustomersGrid");
            this.CustomersGrid.MultiSelect = false;
            this.CustomersGrid.Name = "CustomersGrid";
            this.CustomersGrid.ReadOnly = true;
            this.CustomersGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.CustomersGrid, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // tableLayoutPanel2
            // 
            resources.ApplyResources(this.tableLayoutPanel2, "tableLayoutPanel2");
            this.tableLayoutPanel2.Controls.Add(this.mainMenuBtn3, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.mainAddCustBtn, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.inspectBtn, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.editBtn, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.deleteBtn, 3, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            // 
            // mainAddCustBtn
            // 
            resources.ApplyResources(this.mainAddCustBtn, "mainAddCustBtn");
            this.mainAddCustBtn.Name = "mainAddCustBtn";
            this.mainAddCustBtn.UseVisualStyleBackColor = true;
            this.mainAddCustBtn.Click += new System.EventHandler(this.mainAddCustBtn_Click);
            // 
            // tableLayoutPanel3
            // 
            resources.ApplyResources(this.tableLayoutPanel3, "tableLayoutPanel3");
            this.tableLayoutPanel3.Controls.Add(this.CustLbl, 1, 1);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            // 
            // ExistingCustomers
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ExistingCustomers";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.CustomersGrid)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button inspectBtn;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button mainMenuBtn3;
        private System.Windows.Forms.Label CustLbl;
        private System.Windows.Forms.DataGridView CustomersGrid;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button mainAddCustBtn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
    }
}