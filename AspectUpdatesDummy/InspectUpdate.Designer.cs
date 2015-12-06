namespace AspectUpdatesDummy
{
    partial class InspectUpdate
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
            this.backBtn = new System.Windows.Forms.Button();
            this.commentsTextBox = new System.Windows.Forms.TextBox();
            this.commentsLabel = new System.Windows.Forms.Label();
            this.versionLabel = new System.Windows.Forms.Label();
            this.customerLabel = new System.Windows.Forms.Label();
            this.UpdateLbl = new System.Windows.Forms.Label();
            this.expLbl = new System.Windows.Forms.Label();
            this.actLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // backBtn
            // 
            this.backBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.backBtn.Location = new System.Drawing.Point(464, 267);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(134, 40);
            this.backBtn.TabIndex = 40;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // commentsTextBox
            // 
            this.commentsTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.commentsTextBox.Location = new System.Drawing.Point(40, 230);
            this.commentsTextBox.Multiline = true;
            this.commentsTextBox.Name = "commentsTextBox";
            this.commentsTextBox.ReadOnly = true;
            this.commentsTextBox.Size = new System.Drawing.Size(294, 77);
            this.commentsTextBox.TabIndex = 39;
            // 
            // commentsLabel
            // 
            this.commentsLabel.AutoSize = true;
            this.commentsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.commentsLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.commentsLabel.Location = new System.Drawing.Point(37, 209);
            this.commentsLabel.Name = "commentsLabel";
            this.commentsLabel.Size = new System.Drawing.Size(100, 18);
            this.commentsLabel.TabIndex = 38;
            this.commentsLabel.Text = "Comments: ";
            // 
            // versionLabel
            // 
            this.versionLabel.AutoSize = true;
            this.versionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.versionLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.versionLabel.Location = new System.Drawing.Point(37, 145);
            this.versionLabel.Name = "versionLabel";
            this.versionLabel.Size = new System.Drawing.Size(75, 18);
            this.versionLabel.TabIndex = 37;
            this.versionLabel.Text = "Version: ";
            // 
            // customerLabel
            // 
            this.customerLabel.AutoSize = true;
            this.customerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.customerLabel.Location = new System.Drawing.Point(37, 79);
            this.customerLabel.Name = "customerLabel";
            this.customerLabel.Size = new System.Drawing.Size(92, 18);
            this.customerLabel.TabIndex = 36;
            this.customerLabel.Text = "Customer: ";
            // 
            // UpdateLbl
            // 
            this.UpdateLbl.AutoSize = true;
            this.UpdateLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.UpdateLbl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.UpdateLbl.Location = new System.Drawing.Point(239, 24);
            this.UpdateLbl.Name = "UpdateLbl";
            this.UpdateLbl.Size = new System.Drawing.Size(133, 20);
            this.UpdateLbl.TabIndex = 35;
            this.UpdateLbl.Text = "Inspect Update";
            // 
            // expLbl
            // 
            this.expLbl.AutoSize = true;
            this.expLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expLbl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.expLbl.Location = new System.Drawing.Point(301, 109);
            this.expLbl.Name = "expLbl";
            this.expLbl.Size = new System.Drawing.Size(127, 18);
            this.expLbl.TabIndex = 41;
            this.expLbl.Text = "Expected Date: ";
            // 
            // actLbl
            // 
            this.actLbl.AutoSize = true;
            this.actLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actLbl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.actLbl.Location = new System.Drawing.Point(301, 174);
            this.actLbl.Name = "actLbl";
            this.actLbl.Size = new System.Drawing.Size(104, 18);
            this.actLbl.TabIndex = 42;
            this.actLbl.Text = "Actual Date: ";
            // 
            // InspectUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 330);
            this.Controls.Add(this.actLbl);
            this.Controls.Add(this.expLbl);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.commentsTextBox);
            this.Controls.Add(this.commentsLabel);
            this.Controls.Add(this.versionLabel);
            this.Controls.Add(this.customerLabel);
            this.Controls.Add(this.UpdateLbl);
            this.Name = "InspectUpdate";
            this.Text = "Aspect PT Version Database - Inspect Update";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.TextBox commentsTextBox;
        private System.Windows.Forms.Label commentsLabel;
        private System.Windows.Forms.Label versionLabel;
        private System.Windows.Forms.Label customerLabel;
        private System.Windows.Forms.Label UpdateLbl;
        private System.Windows.Forms.Label expLbl;
        private System.Windows.Forms.Label actLbl;
    }
}