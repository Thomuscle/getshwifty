namespace AspectUpdatesDummy
{
    partial class NewUpdateCustomers
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
            this.CustLbl = new System.Windows.Forms.Label();
            this.subtitle = new System.Windows.Forms.Label();
            this.CustomersGrid = new System.Windows.Forms.DataGridView();
            this.submitBtn = new System.Windows.Forms.Button();
            this.mainMenuBtn2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CustomersGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // CustLbl
            // 
            this.CustLbl.AutoSize = true;
            this.CustLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.CustLbl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.CustLbl.Location = new System.Drawing.Point(239, 9);
            this.CustLbl.Name = "CustLbl";
            this.CustLbl.Size = new System.Drawing.Size(151, 20);
            this.CustLbl.TabIndex = 14;
            this.CustLbl.Text = "Select Customers";
            // 
            // subtitle
            // 
            this.subtitle.AutoSize = true;
            this.subtitle.Location = new System.Drawing.Point(205, 31);
            this.subtitle.Name = "subtitle";
            this.subtitle.Size = new System.Drawing.Size(224, 13);
            this.subtitle.TabIndex = 15;
            this.subtitle.Text = "Select the customers who you wish to update:";
            // 
            // CustomersGrid
            // 
            this.CustomersGrid.AllowUserToAddRows = false;
            this.CustomersGrid.AllowUserToDeleteRows = false;
            this.CustomersGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CustomersGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CustomersGrid.Location = new System.Drawing.Point(25, 60);
            this.CustomersGrid.Name = "CustomersGrid";
            this.CustomersGrid.Size = new System.Drawing.Size(586, 191);
            this.CustomersGrid.TabIndex = 16;
            // 
            // submitBtn
            // 
            this.submitBtn.Location = new System.Drawing.Point(177, 269);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(127, 42);
            this.submitBtn.TabIndex = 18;
            this.submitBtn.Text = "Submit";
            this.submitBtn.UseVisualStyleBackColor = true;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // mainMenuBtn2
            // 
            this.mainMenuBtn2.Location = new System.Drawing.Point(335, 269);
            this.mainMenuBtn2.Name = "mainMenuBtn2";
            this.mainMenuBtn2.Size = new System.Drawing.Size(127, 42);
            this.mainMenuBtn2.TabIndex = 17;
            this.mainMenuBtn2.Text = "Back";
            this.mainMenuBtn2.UseVisualStyleBackColor = true;
            this.mainMenuBtn2.Click += new System.EventHandler(this.mainMenuBtn2_Click);
            // 
            // NewUpdateCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 330);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.mainMenuBtn2);
            this.Controls.Add(this.CustomersGrid);
            this.Controls.Add(this.subtitle);
            this.Controls.Add(this.CustLbl);
            this.Name = "NewUpdateCustomers";
            this.Text = "Aspect PT Version Database - New Update Customers";
            ((System.ComponentModel.ISupportInitialize)(this.CustomersGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CustLbl;
        private System.Windows.Forms.Label subtitle;
        private System.Windows.Forms.DataGridView CustomersGrid;
        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.Button mainMenuBtn2;
    }
}