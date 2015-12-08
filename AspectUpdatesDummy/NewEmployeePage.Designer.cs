namespace AspectUpdatesDummy
{
    partial class NewEmployeePage
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
            this.idLbl = new System.Windows.Forms.Label();
            this.nameTxtBx = new System.Windows.Forms.TextBox();
            this.submitBtn = new System.Windows.Forms.Button();
            this.subLbl = new System.Windows.Forms.Label();
            this.newCustLbl = new System.Windows.Forms.Label();
            this.mainMenuBtn1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // idLbl
            // 
            this.idLbl.AutoSize = true;
            this.idLbl.Location = new System.Drawing.Point(121, 87);
            this.idLbl.Name = "idLbl";
            this.idLbl.Size = new System.Drawing.Size(109, 13);
            this.idLbl.TabIndex = 26;
            this.idLbl.Text = "New Employee Name";
            // 
            // nameTxtBx
            // 
            this.nameTxtBx.Location = new System.Drawing.Point(68, 103);
            this.nameTxtBx.Name = "nameTxtBx";
            this.nameTxtBx.Size = new System.Drawing.Size(222, 20);
            this.nameTxtBx.TabIndex = 25;
            // 
            // submitBtn
            // 
            this.submitBtn.Location = new System.Drawing.Point(31, 182);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(127, 42);
            this.submitBtn.TabIndex = 24;
            this.submitBtn.Text = "Submit";
            this.submitBtn.UseVisualStyleBackColor = true;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // subLbl
            // 
            this.subLbl.AutoSize = true;
            this.subLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subLbl.Location = new System.Drawing.Point(75, 38);
            this.subLbl.Name = "subLbl";
            this.subLbl.Size = new System.Drawing.Size(206, 15);
            this.subLbl.TabIndex = 23;
            this.subLbl.Text = "Please enter new employee\'s name:";
            this.subLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // newCustLbl
            // 
            this.newCustLbl.AutoSize = true;
            this.newCustLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newCustLbl.Location = new System.Drawing.Point(120, 18);
            this.newCustLbl.Name = "newCustLbl";
            this.newCustLbl.Size = new System.Drawing.Size(126, 20);
            this.newCustLbl.TabIndex = 22;
            this.newCustLbl.Text = "New Employee";
            // 
            // mainMenuBtn1
            // 
            this.mainMenuBtn1.Location = new System.Drawing.Point(187, 182);
            this.mainMenuBtn1.Name = "mainMenuBtn1";
            this.mainMenuBtn1.Size = new System.Drawing.Size(127, 42);
            this.mainMenuBtn1.TabIndex = 21;
            this.mainMenuBtn1.Text = "Menu";
            this.mainMenuBtn1.UseVisualStyleBackColor = true;
            this.mainMenuBtn1.Click += new System.EventHandler(this.mainMenuBtn1_Click);
            // 
            // NewEmployeePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 253);
            this.Controls.Add(this.idLbl);
            this.Controls.Add(this.nameTxtBx);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.subLbl);
            this.Controls.Add(this.newCustLbl);
            this.Controls.Add(this.mainMenuBtn1);
            this.Name = "NewEmployeePage";
            this.Text = "Aspect PT Version Database - New Employee";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label idLbl;
        private System.Windows.Forms.TextBox nameTxtBx;
        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.Label subLbl;
        private System.Windows.Forms.Label newCustLbl;
        private System.Windows.Forms.Button mainMenuBtn1;
    }
}