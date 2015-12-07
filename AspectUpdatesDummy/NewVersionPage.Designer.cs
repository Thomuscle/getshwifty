namespace AspectUpdatesDummy
{
    partial class NewVersionPage
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
            this.mainMenuBtn2 = new System.Windows.Forms.Button();
            this.descriptionTxtBx = new System.Windows.Forms.TextBox();
            this.descLbl = new System.Windows.Forms.Label();
            this.newVersLbl = new System.Windows.Forms.Label();
            this.idTxtBx = new System.Windows.Forms.TextBox();
            this.idLbl = new System.Windows.Forms.Label();
            this.typeCmboBx = new System.Windows.Forms.ComboBox();
            this.typeLbl = new System.Windows.Forms.Label();
            this.releaseDateCal = new System.Windows.Forms.MonthCalendar();
            this.releaseDateLbl = new System.Windows.Forms.Label();
            this.submitBtn = new System.Windows.Forms.Button();
            this.subLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // mainMenuBtn2
            // 
            this.mainMenuBtn2.Location = new System.Drawing.Point(489, 252);
            this.mainMenuBtn2.Name = "mainMenuBtn2";
            this.mainMenuBtn2.Size = new System.Drawing.Size(127, 42);
            this.mainMenuBtn2.TabIndex = 0;
            this.mainMenuBtn2.Text = "Menu";
            this.mainMenuBtn2.UseVisualStyleBackColor = true;
            this.mainMenuBtn2.Click += new System.EventHandler(this.mainMenuBtn2_Click);
            // 
            // descriptionTxtBx
            // 
            this.descriptionTxtBx.Location = new System.Drawing.Point(28, 204);
            this.descriptionTxtBx.Multiline = true;
            this.descriptionTxtBx.Name = "descriptionTxtBx";
            this.descriptionTxtBx.Size = new System.Drawing.Size(280, 90);
            this.descriptionTxtBx.TabIndex = 1;
            // 
            // descLbl
            // 
            this.descLbl.AutoSize = true;
            this.descLbl.Location = new System.Drawing.Point(25, 188);
            this.descLbl.Name = "descLbl";
            this.descLbl.Size = new System.Drawing.Size(108, 13);
            this.descLbl.TabIndex = 2;
            this.descLbl.Text = "Description (Optional)";
            // 
            // newVersLbl
            // 
            this.newVersLbl.AutoSize = true;
            this.newVersLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newVersLbl.Location = new System.Drawing.Point(271, 9);
            this.newVersLbl.Name = "newVersLbl";
            this.newVersLbl.Size = new System.Drawing.Size(109, 20);
            this.newVersLbl.TabIndex = 3;
            this.newVersLbl.Text = "New Version";
            this.newVersLbl.Click += new System.EventHandler(this.newVersLbl_Click);
            // 
            // idTxtBx
            // 
            this.idTxtBx.Location = new System.Drawing.Point(28, 77);
            this.idTxtBx.Name = "idTxtBx";
            this.idTxtBx.Size = new System.Drawing.Size(189, 20);
            this.idTxtBx.TabIndex = 4;
            // 
            // idLbl
            // 
            this.idLbl.AutoSize = true;
            this.idLbl.Location = new System.Drawing.Point(25, 61);
            this.idLbl.Name = "idLbl";
            this.idLbl.Size = new System.Drawing.Size(81, 13);
            this.idLbl.TabIndex = 5;
            this.idLbl.Text = "New Version ID";
            // 
            // typeCmboBx
            // 
            this.typeCmboBx.FormattingEnabled = true;
            this.typeCmboBx.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.typeCmboBx.Location = new System.Drawing.Point(28, 137);
            this.typeCmboBx.Name = "typeCmboBx";
            this.typeCmboBx.Size = new System.Drawing.Size(189, 21);
            this.typeCmboBx.TabIndex = 6;
            // 
            // typeLbl
            // 
            this.typeLbl.AutoSize = true;
            this.typeLbl.Location = new System.Drawing.Point(25, 121);
            this.typeLbl.Name = "typeLbl";
            this.typeLbl.Size = new System.Drawing.Size(69, 13);
            this.typeLbl.TabIndex = 7;
            this.typeLbl.Text = "Version Type";
            // 
            // releaseDateCal
            // 
            this.releaseDateCal.Location = new System.Drawing.Point(389, 77);
            this.releaseDateCal.MaxSelectionCount = 1;
            this.releaseDateCal.Name = "releaseDateCal";
            this.releaseDateCal.TabIndex = 8;
            // 
            // releaseDateLbl
            // 
            this.releaseDateLbl.AutoSize = true;
            this.releaseDateLbl.Location = new System.Drawing.Point(386, 61);
            this.releaseDateLbl.Name = "releaseDateLbl";
            this.releaseDateLbl.Size = new System.Drawing.Size(72, 13);
            this.releaseDateLbl.TabIndex = 9;
            this.releaseDateLbl.Text = "Release Date";
            // 
            // submitBtn
            // 
            this.submitBtn.Location = new System.Drawing.Point(331, 252);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(127, 42);
            this.submitBtn.TabIndex = 10;
            this.submitBtn.Text = "Submit";
            this.submitBtn.UseVisualStyleBackColor = true;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // subLbl
            // 
            this.subLbl.AutoSize = true;
            this.subLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subLbl.Location = new System.Drawing.Point(215, 29);
            this.subLbl.Name = "subLbl";
            this.subLbl.Size = new System.Drawing.Size(212, 15);
            this.subLbl.TabIndex = 11;
            this.subLbl.Text = "Please enter new version information:";
            this.subLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.subLbl.Click += new System.EventHandler(this.subLbl_Click);
            // 
            // NewVersionPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 330);
            this.Controls.Add(this.subLbl);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.releaseDateLbl);
            this.Controls.Add(this.releaseDateCal);
            this.Controls.Add(this.typeLbl);
            this.Controls.Add(this.typeCmboBx);
            this.Controls.Add(this.idLbl);
            this.Controls.Add(this.idTxtBx);
            this.Controls.Add(this.newVersLbl);
            this.Controls.Add(this.descLbl);
            this.Controls.Add(this.descriptionTxtBx);
            this.Controls.Add(this.mainMenuBtn2);
            this.Name = "NewVersionPage";
            this.Text = "Aspect PT Version Database - Add Version";
            this.Load += new System.EventHandler(this.NewVersionPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button mainMenuBtn2;
        private System.Windows.Forms.TextBox descriptionTxtBx;
        private System.Windows.Forms.Label descLbl;
        private System.Windows.Forms.Label newVersLbl;
        private System.Windows.Forms.TextBox idTxtBx;
        private System.Windows.Forms.Label idLbl;
        private System.Windows.Forms.ComboBox typeCmboBx;
        private System.Windows.Forms.Label typeLbl;
        private System.Windows.Forms.MonthCalendar releaseDateCal;
        private System.Windows.Forms.Label releaseDateLbl;
        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.Label subLbl;
    }
}