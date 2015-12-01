namespace AspectUpdatesDummy
{
    partial class NewCustomerPage
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
            this.mainMenuBtn1 = new System.Windows.Forms.Button();
            this.subLbl = new System.Windows.Forms.Label();
            this.newCustLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // mainMenuBtn1
            // 
            this.mainMenuBtn1.Location = new System.Drawing.Point(513, 262);
            this.mainMenuBtn1.Name = "mainMenuBtn1";
            this.mainMenuBtn1.Size = new System.Drawing.Size(109, 37);
            this.mainMenuBtn1.TabIndex = 0;
            this.mainMenuBtn1.Text = "Main Menu";
            this.mainMenuBtn1.UseVisualStyleBackColor = true;
            this.mainMenuBtn1.Click += new System.EventHandler(this.mainMenuBtn1_Click);
            // 
            // subLbl
            // 
            this.subLbl.AutoSize = true;
            this.subLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subLbl.Location = new System.Drawing.Point(219, 29);
            this.subLbl.Name = "subLbl";
            this.subLbl.Size = new System.Drawing.Size(224, 15);
            this.subLbl.TabIndex = 13;
            this.subLbl.Text = "Please enter new customer information:";
            this.subLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // newCustLbl
            // 
            this.newCustLbl.AutoSize = true;
            this.newCustLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newCustLbl.Location = new System.Drawing.Point(274, 9);
            this.newCustLbl.Name = "newCustLbl";
            this.newCustLbl.Size = new System.Drawing.Size(125, 20);
            this.newCustLbl.TabIndex = 12;
            this.newCustLbl.Text = "New Customer";
            // 
            // NewCustomerPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 330);
            this.Controls.Add(this.subLbl);
            this.Controls.Add(this.newCustLbl);
            this.Controls.Add(this.mainMenuBtn1);
            this.Name = "NewCustomerPage";
            this.Text = "Aspect PT Version Database - Add Customer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button mainMenuBtn1;
        private System.Windows.Forms.Label subLbl;
        private System.Windows.Forms.Label newCustLbl;
    }
}