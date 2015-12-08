namespace AspectUpdatesDummy
{
    partial class EditVersion
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
            this.subLbl = new System.Windows.Forms.Label();
            this.submitBtn = new System.Windows.Forms.Button();
            this.releaseDateLbl = new System.Windows.Forms.Label();
            this.releaseDateCal = new System.Windows.Forms.MonthCalendar();
            this.typeLbl = new System.Windows.Forms.Label();
            this.typeCmboBx = new System.Windows.Forms.ComboBox();
            this.idLbl = new System.Windows.Forms.Label();
            this.idTxtBx = new System.Windows.Forms.TextBox();
            this.editVersLbl = new System.Windows.Forms.Label();
            this.descLbl = new System.Windows.Forms.Label();
            this.descriptionTxtBx = new System.Windows.Forms.TextBox();
            this.backBtn = new System.Windows.Forms.Button();
            this.webServiceCB = new System.Windows.Forms.CheckBox();
            this.webAppCB = new System.Windows.Forms.CheckBox();
            this.redAspectCB = new System.Windows.Forms.CheckBox();
            this.blueAspectCB = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // subLbl
            // 
            this.subLbl.AutoSize = true;
            this.subLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subLbl.Location = new System.Drawing.Point(232, 29);
            this.subLbl.Name = "subLbl";
            this.subLbl.Size = new System.Drawing.Size(178, 15);
            this.subLbl.TabIndex = 23;
            this.subLbl.Text = "Please edit version information:";
            this.subLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // submitBtn
            // 
            this.submitBtn.Location = new System.Drawing.Point(331, 252);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(127, 42);
            this.submitBtn.TabIndex = 22;
            this.submitBtn.Text = "Submit";
            this.submitBtn.UseVisualStyleBackColor = true;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // releaseDateLbl
            // 
            this.releaseDateLbl.AutoSize = true;
            this.releaseDateLbl.Location = new System.Drawing.Point(386, 61);
            this.releaseDateLbl.Name = "releaseDateLbl";
            this.releaseDateLbl.Size = new System.Drawing.Size(72, 13);
            this.releaseDateLbl.TabIndex = 21;
            this.releaseDateLbl.Text = "Release Date";
            // 
            // releaseDateCal
            // 
            this.releaseDateCal.Location = new System.Drawing.Point(389, 77);
            this.releaseDateCal.MaxSelectionCount = 1;
            this.releaseDateCal.Name = "releaseDateCal";
            this.releaseDateCal.TabIndex = 20;
            // 
            // typeLbl
            // 
            this.typeLbl.AutoSize = true;
            this.typeLbl.Location = new System.Drawing.Point(25, 121);
            this.typeLbl.Name = "typeLbl";
            this.typeLbl.Size = new System.Drawing.Size(117, 13);
            this.typeLbl.TabIndex = 19;
            this.typeLbl.Text = "Version Type (Optional)";
            // 
            // typeCmboBx
            // 
            this.typeCmboBx.FormattingEnabled = true;
            this.typeCmboBx.Items.AddRange(new object[] {
            "Release",
            "Hotfix"});
            this.typeCmboBx.Location = new System.Drawing.Point(28, 137);
            this.typeCmboBx.Name = "typeCmboBx";
            this.typeCmboBx.Size = new System.Drawing.Size(189, 21);
            this.typeCmboBx.TabIndex = 18;
            // 
            // idLbl
            // 
            this.idLbl.AutoSize = true;
            this.idLbl.Location = new System.Drawing.Point(25, 61);
            this.idLbl.Name = "idLbl";
            this.idLbl.Size = new System.Drawing.Size(56, 13);
            this.idLbl.TabIndex = 17;
            this.idLbl.Text = "Version ID";
            // 
            // idTxtBx
            // 
            this.idTxtBx.Location = new System.Drawing.Point(28, 77);
            this.idTxtBx.Name = "idTxtBx";
            this.idTxtBx.Size = new System.Drawing.Size(189, 20);
            this.idTxtBx.TabIndex = 16;
            // 
            // editVersLbl
            // 
            this.editVersLbl.AutoSize = true;
            this.editVersLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editVersLbl.Location = new System.Drawing.Point(272, 9);
            this.editVersLbl.Name = "editVersLbl";
            this.editVersLbl.Size = new System.Drawing.Size(107, 20);
            this.editVersLbl.TabIndex = 15;
            this.editVersLbl.Text = "Edit Version";
            // 
            // descLbl
            // 
            this.descLbl.AutoSize = true;
            this.descLbl.Location = new System.Drawing.Point(25, 188);
            this.descLbl.Name = "descLbl";
            this.descLbl.Size = new System.Drawing.Size(108, 13);
            this.descLbl.TabIndex = 14;
            this.descLbl.Text = "Description (Optional)";
            // 
            // descriptionTxtBx
            // 
            this.descriptionTxtBx.Location = new System.Drawing.Point(28, 204);
            this.descriptionTxtBx.Multiline = true;
            this.descriptionTxtBx.Name = "descriptionTxtBx";
            this.descriptionTxtBx.Size = new System.Drawing.Size(280, 90);
            this.descriptionTxtBx.TabIndex = 13;
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(489, 252);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(127, 42);
            this.backBtn.TabIndex = 12;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // webServiceCB
            // 
            this.webServiceCB.AutoSize = true;
            this.webServiceCB.Location = new System.Drawing.Point(243, 144);
            this.webServiceCB.Name = "webServiceCB";
            this.webServiceCB.Size = new System.Drawing.Size(126, 17);
            this.webServiceCB.TabIndex = 27;
            this.webServiceCB.Text = "Include Web Service";
            this.webServiceCB.UseVisualStyleBackColor = true;
            // 
            // webAppCB
            // 
            this.webAppCB.AutoSize = true;
            this.webAppCB.Location = new System.Drawing.Point(243, 121);
            this.webAppCB.Name = "webAppCB";
            this.webAppCB.Size = new System.Drawing.Size(109, 17);
            this.webAppCB.TabIndex = 26;
            this.webAppCB.Text = "Include Web App";
            this.webAppCB.UseVisualStyleBackColor = true;
            // 
            // redAspectCB
            // 
            this.redAspectCB.AutoSize = true;
            this.redAspectCB.Location = new System.Drawing.Point(243, 98);
            this.redAspectCB.Name = "redAspectCB";
            this.redAspectCB.Size = new System.Drawing.Size(120, 17);
            this.redAspectCB.TabIndex = 25;
            this.redAspectCB.Text = "Include Red Aspect";
            this.redAspectCB.UseVisualStyleBackColor = true;
            // 
            // blueAspectCB
            // 
            this.blueAspectCB.AutoSize = true;
            this.blueAspectCB.Location = new System.Drawing.Point(243, 75);
            this.blueAspectCB.Name = "blueAspectCB";
            this.blueAspectCB.Size = new System.Drawing.Size(121, 17);
            this.blueAspectCB.TabIndex = 24;
            this.blueAspectCB.Text = "Include Blue Aspect";
            this.blueAspectCB.UseVisualStyleBackColor = true;
            // 
            // EditVersion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 330);
            this.Controls.Add(this.webServiceCB);
            this.Controls.Add(this.webAppCB);
            this.Controls.Add(this.redAspectCB);
            this.Controls.Add(this.blueAspectCB);
            this.Controls.Add(this.subLbl);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.releaseDateLbl);
            this.Controls.Add(this.releaseDateCal);
            this.Controls.Add(this.typeLbl);
            this.Controls.Add(this.typeCmboBx);
            this.Controls.Add(this.idLbl);
            this.Controls.Add(this.idTxtBx);
            this.Controls.Add(this.editVersLbl);
            this.Controls.Add(this.descLbl);
            this.Controls.Add(this.descriptionTxtBx);
            this.Controls.Add(this.backBtn);
            this.Name = "EditVersion";
            this.Text = "Aspect PT Version Database - Edit Version";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label subLbl;
        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.Label releaseDateLbl;
        private System.Windows.Forms.MonthCalendar releaseDateCal;
        private System.Windows.Forms.Label typeLbl;
        private System.Windows.Forms.ComboBox typeCmboBx;
        private System.Windows.Forms.Label idLbl;
        private System.Windows.Forms.TextBox idTxtBx;
        private System.Windows.Forms.Label editVersLbl;
        private System.Windows.Forms.Label descLbl;
        private System.Windows.Forms.TextBox descriptionTxtBx;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.CheckBox webServiceCB;
        private System.Windows.Forms.CheckBox webAppCB;
        private System.Windows.Forms.CheckBox redAspectCB;
        private System.Windows.Forms.CheckBox blueAspectCB;
    }
}