namespace AspectUpdatesDummy
{
    partial class EditCustomer
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
            this.nameTxtBx = new System.Windows.Forms.TextBox();
            this.detailsTxtBx = new System.Windows.Forms.TextBox();
            this.subLbl = new System.Windows.Forms.Label();
            this.editCustLbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.versionTextBox = new System.Windows.Forms.TextBox();
            this.submitBtn = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.plcTB = new System.Windows.Forms.TextBox();
            this.contactsTB = new System.Windows.Forms.TextBox();
            this.logonTB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nameTxtBx
            // 
            this.nameTxtBx.Location = new System.Drawing.Point(25, 105);
            this.nameTxtBx.Name = "nameTxtBx";
            this.nameTxtBx.Size = new System.Drawing.Size(356, 20);
            this.nameTxtBx.TabIndex = 20;
            // 
            // detailsTxtBx
            // 
            this.detailsTxtBx.Location = new System.Drawing.Point(25, 145);
            this.detailsTxtBx.Multiline = true;
            this.detailsTxtBx.Name = "detailsTxtBx";
            this.detailsTxtBx.Size = new System.Drawing.Size(360, 90);
            this.detailsTxtBx.TabIndex = 19;
            // 
            // subLbl
            // 
            this.subLbl.AutoSize = true;
            this.subLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subLbl.Location = new System.Drawing.Point(222, 39);
            this.subLbl.Name = "subLbl";
            this.subLbl.Size = new System.Drawing.Size(190, 15);
            this.subLbl.TabIndex = 25;
            this.subLbl.Text = "Please edit customer information:";
            this.subLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // editCustLbl
            // 
            this.editCustLbl.AutoSize = true;
            this.editCustLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editCustLbl.Location = new System.Drawing.Point(262, 19);
            this.editCustLbl.Name = "editCustLbl";
            this.editCustLbl.Size = new System.Drawing.Size(123, 20);
            this.editCustLbl.TabIndex = 24;
            this.editCustLbl.Text = "Edit Customer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Details";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(414, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(193, 26);
            this.label3.TabIndex = 29;
            this.label3.Text = "Note: To change a customer\'s version, \r\nplease create a new update.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(414, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "Current Version:";
            // 
            // versionTextBox
            // 
            this.versionTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.versionTextBox.Location = new System.Drawing.Point(417, 105);
            this.versionTextBox.Name = "versionTextBox";
            this.versionTextBox.ReadOnly = true;
            this.versionTextBox.Size = new System.Drawing.Size(276, 20);
            this.versionTextBox.TabIndex = 31;
            // 
            // submitBtn
            // 
            this.submitBtn.Location = new System.Drawing.Point(423, 410);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(127, 42);
            this.submitBtn.TabIndex = 33;
            this.submitBtn.Text = "Submit";
            this.submitBtn.UseVisualStyleBackColor = true;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(581, 410);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(127, 42);
            this.backBtn.TabIndex = 32;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // plcTB
            // 
            this.plcTB.Location = new System.Drawing.Point(25, 264);
            this.plcTB.Name = "plcTB";
            this.plcTB.Size = new System.Drawing.Size(360, 20);
            this.plcTB.TabIndex = 39;
            // 
            // contactsTB
            // 
            this.contactsTB.Location = new System.Drawing.Point(417, 264);
            this.contactsTB.Multiline = true;
            this.contactsTB.Name = "contactsTB";
            this.contactsTB.Size = new System.Drawing.Size(276, 130);
            this.contactsTB.TabIndex = 38;
            // 
            // logonTB
            // 
            this.logonTB.Location = new System.Drawing.Point(25, 310);
            this.logonTB.Multiline = true;
            this.logonTB.Name = "logonTB";
            this.logonTB.Size = new System.Drawing.Size(360, 158);
            this.logonTB.TabIndex = 37;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 294);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 13);
            this.label5.TabIndex = 36;
            this.label5.Text = "Logon Details (Optional)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 248);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 13);
            this.label6.TabIndex = 35;
            this.label6.Text = "PLC Address (Optional)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(414, 248);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 13);
            this.label7.TabIndex = 34;
            this.label7.Text = "Contacts (Optional)";
            // 
            // EditCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 480);
            this.Controls.Add(this.plcTB);
            this.Controls.Add(this.contactsTB);
            this.Controls.Add(this.logonTB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.versionTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.subLbl);
            this.Controls.Add(this.editCustLbl);
            this.Controls.Add(this.nameTxtBx);
            this.Controls.Add(this.detailsTxtBx);
            this.Name = "EditCustomer";
            this.Text = "Aspect PT Version Database - Edit Customer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameTxtBx;
        private System.Windows.Forms.TextBox detailsTxtBx;
        private System.Windows.Forms.Label subLbl;
        private System.Windows.Forms.Label editCustLbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox versionTextBox;
        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.TextBox plcTB;
        private System.Windows.Forms.TextBox contactsTB;
        private System.Windows.Forms.TextBox logonTB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}