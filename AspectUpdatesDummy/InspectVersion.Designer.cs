namespace AspectUpdatesDummy
{
    partial class InspectVersion
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
            this.versionsLbl = new System.Windows.Forms.Label();
            this.idLabel = new System.Windows.Forms.Label();
            this.typeLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.descrLabel = new System.Windows.Forms.Label();
            this.descrTextBox = new System.Windows.Forms.TextBox();
            this.CustomerGrid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.backBtn = new System.Windows.Forms.Button();
            this.webServiceCB = new System.Windows.Forms.CheckBox();
            this.webAppCB = new System.Windows.Forms.CheckBox();
            this.redAspectCB = new System.Windows.Forms.CheckBox();
            this.blueAspectCB = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // versionsLbl
            // 
            this.versionsLbl.AutoSize = true;
            this.versionsLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.versionsLbl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.versionsLbl.Location = new System.Drawing.Point(245, 19);
            this.versionsLbl.Name = "versionsLbl";
            this.versionsLbl.Size = new System.Drawing.Size(135, 20);
            this.versionsLbl.TabIndex = 20;
            this.versionsLbl.Text = "Inspect Version";
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.idLabel.Location = new System.Drawing.Point(43, 78);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(96, 18);
            this.idLabel.TabIndex = 21;
            this.idLabel.Text = "Version ID: ";
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.typeLabel.Location = new System.Drawing.Point(43, 116);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(54, 18);
            this.typeLabel.TabIndex = 22;
            this.typeLabel.Text = "Type: ";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dateLabel.Location = new System.Drawing.Point(43, 153);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(119, 18);
            this.dateLabel.TabIndex = 23;
            this.dateLabel.Text = "Release Date: ";
            // 
            // descrLabel
            // 
            this.descrLabel.AutoSize = true;
            this.descrLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descrLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.descrLabel.Location = new System.Drawing.Point(43, 195);
            this.descrLabel.Name = "descrLabel";
            this.descrLabel.Size = new System.Drawing.Size(99, 18);
            this.descrLabel.TabIndex = 24;
            this.descrLabel.Text = "Description:";
            // 
            // descrTextBox
            // 
            this.descrTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.descrTextBox.Location = new System.Drawing.Point(46, 225);
            this.descrTextBox.Multiline = true;
            this.descrTextBox.Name = "descrTextBox";
            this.descrTextBox.ReadOnly = true;
            this.descrTextBox.Size = new System.Drawing.Size(253, 77);
            this.descrTextBox.TabIndex = 25;
            // 
            // CustomerGrid
            // 
            this.CustomerGrid.AllowUserToAddRows = false;
            this.CustomerGrid.AllowUserToDeleteRows = false;
            this.CustomerGrid.AllowUserToResizeColumns = false;
            this.CustomerGrid.AllowUserToResizeRows = false;
            this.CustomerGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CustomerGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CustomerGrid.Location = new System.Drawing.Point(337, 137);
            this.CustomerGrid.MultiSelect = false;
            this.CustomerGrid.Name = "CustomerGrid";
            this.CustomerGrid.ReadOnly = true;
            this.CustomerGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.CustomerGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CustomerGrid.Size = new System.Drawing.Size(268, 110);
            this.CustomerGrid.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(334, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 18);
            this.label1.TabIndex = 27;
            this.label1.Text = "Customers with Version:";
            // 
            // backBtn
            // 
            this.backBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.backBtn.Location = new System.Drawing.Point(470, 262);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(134, 40);
            this.backBtn.TabIndex = 28;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // webServiceCB
            // 
            this.webServiceCB.AutoCheck = false;
            this.webServiceCB.AutoSize = true;
            this.webServiceCB.Location = new System.Drawing.Point(478, 81);
            this.webServiceCB.Name = "webServiceCB";
            this.webServiceCB.Size = new System.Drawing.Size(131, 17);
            this.webServiceCB.TabIndex = 32;
            this.webServiceCB.Text = "Includes Web Service";
            this.webServiceCB.UseVisualStyleBackColor = true;
            // 
            // webAppCB
            // 
            this.webAppCB.AutoCheck = false;
            this.webAppCB.AutoSize = true;
            this.webAppCB.Location = new System.Drawing.Point(478, 58);
            this.webAppCB.Name = "webAppCB";
            this.webAppCB.Size = new System.Drawing.Size(114, 17);
            this.webAppCB.TabIndex = 31;
            this.webAppCB.Text = "Includes Web App";
            this.webAppCB.UseVisualStyleBackColor = true;
            // 
            // redAspectCB
            // 
            this.redAspectCB.AutoCheck = false;
            this.redAspectCB.AutoSize = true;
            this.redAspectCB.Location = new System.Drawing.Point(337, 81);
            this.redAspectCB.Name = "redAspectCB";
            this.redAspectCB.Size = new System.Drawing.Size(125, 17);
            this.redAspectCB.TabIndex = 30;
            this.redAspectCB.Text = "Includes Red Aspect";
            this.redAspectCB.UseVisualStyleBackColor = true;
            // 
            // blueAspectCB
            // 
            this.blueAspectCB.AutoCheck = false;
            this.blueAspectCB.AutoSize = true;
            this.blueAspectCB.Location = new System.Drawing.Point(337, 58);
            this.blueAspectCB.Name = "blueAspectCB";
            this.blueAspectCB.Size = new System.Drawing.Size(126, 17);
            this.blueAspectCB.TabIndex = 29;
            this.blueAspectCB.Text = "Includes Blue Aspect";
            this.blueAspectCB.UseVisualStyleBackColor = true;
            // 
            // InspectVersion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 330);
            this.Controls.Add(this.webServiceCB);
            this.Controls.Add(this.webAppCB);
            this.Controls.Add(this.redAspectCB);
            this.Controls.Add(this.blueAspectCB);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CustomerGrid);
            this.Controls.Add(this.descrTextBox);
            this.Controls.Add(this.descrLabel);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.typeLabel);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.versionsLbl);
            this.Name = "InspectVersion";
            this.Text = "Aspect PT Version Database - Inspect Version";
            ((System.ComponentModel.ISupportInitialize)(this.CustomerGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label versionsLbl;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label descrLabel;
        private System.Windows.Forms.TextBox descrTextBox;
        private System.Windows.Forms.DataGridView CustomerGrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.CheckBox webServiceCB;
        private System.Windows.Forms.CheckBox webAppCB;
        private System.Windows.Forms.CheckBox redAspectCB;
        private System.Windows.Forms.CheckBox blueAspectCB;
    }
}