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
            this.CustLbl = new System.Windows.Forms.Label();
            this.CustomersGrid = new System.Windows.Forms.DataGridView();
            this.inspectBtn = new System.Windows.Forms.Button();
            this.editBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.mainMenuBtn3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CustomersGrid)).BeginInit();
            this.SuspendLayout();
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
            // inspectBtn
            // 
            resources.ApplyResources(this.inspectBtn, "inspectBtn");
            this.inspectBtn.Name = "inspectBtn";
            this.inspectBtn.UseVisualStyleBackColor = true;
            // 
            // editBtn
            // 
            resources.ApplyResources(this.editBtn, "editBtn");
            this.editBtn.Name = "editBtn";
            this.editBtn.UseVisualStyleBackColor = true;
            // 
            // deleteBtn
            // 
            resources.ApplyResources(this.deleteBtn, "deleteBtn");
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.UseVisualStyleBackColor = true;
            // 
            // mainMenuBtn3
            // 
            resources.ApplyResources(this.mainMenuBtn3, "mainMenuBtn3");
            this.mainMenuBtn3.Name = "mainMenuBtn3";
            this.mainMenuBtn3.UseVisualStyleBackColor = true;
            this.mainMenuBtn3.Click += new System.EventHandler(this.mainMenuBtn3_Click);
            // 
            // ExistingCustomers
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mainMenuBtn3);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.inspectBtn);
            this.Controls.Add(this.CustomersGrid);
            this.Controls.Add(this.CustLbl);
            this.Name = "ExistingCustomers";
            ((System.ComponentModel.ISupportInitialize)(this.CustomersGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CustLbl;
        private System.Windows.Forms.DataGridView CustomersGrid;
        private System.Windows.Forms.Button inspectBtn;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button mainMenuBtn3;
    }
}