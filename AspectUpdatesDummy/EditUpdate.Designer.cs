namespace AspectUpdatesDummy
{
    partial class EditUpdate
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
            this.submitBtn = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.subLbl = new System.Windows.Forms.Label();
            this.editCustLbl = new System.Windows.Forms.Label();
            this.versionLabel = new System.Windows.Forms.Label();
            this.customerLabel = new System.Windows.Forms.Label();
            this.commentsTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.expectedDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.useActual = new System.Windows.Forms.CheckBox();
            this.actualTimePicker = new System.Windows.Forms.DateTimePicker();
            this.actualDatePicker = new System.Windows.Forms.DateTimePicker();
            this.expectedTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.employeeComboBox = new System.Windows.Forms.ComboBox();
            this.contactedCB = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // submitBtn
            // 
            this.submitBtn.Location = new System.Drawing.Point(328, 289);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(127, 42);
            this.submitBtn.TabIndex = 37;
            this.submitBtn.Text = "Submit";
            this.submitBtn.UseVisualStyleBackColor = true;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(486, 289);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(127, 42);
            this.backBtn.TabIndex = 36;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // subLbl
            // 
            this.subLbl.AutoSize = true;
            this.subLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subLbl.Location = new System.Drawing.Point(222, 39);
            this.subLbl.Name = "subLbl";
            this.subLbl.Size = new System.Drawing.Size(177, 15);
            this.subLbl.TabIndex = 35;
            this.subLbl.Text = "Please edit update information:";
            this.subLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // editCustLbl
            // 
            this.editCustLbl.AutoSize = true;
            this.editCustLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editCustLbl.Location = new System.Drawing.Point(262, 19);
            this.editCustLbl.Name = "editCustLbl";
            this.editCustLbl.Size = new System.Drawing.Size(105, 20);
            this.editCustLbl.TabIndex = 34;
            this.editCustLbl.Text = "Edit Update";
            // 
            // versionLabel
            // 
            this.versionLabel.AutoSize = true;
            this.versionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.versionLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.versionLabel.Location = new System.Drawing.Point(58, 120);
            this.versionLabel.Name = "versionLabel";
            this.versionLabel.Size = new System.Drawing.Size(75, 18);
            this.versionLabel.TabIndex = 44;
            this.versionLabel.Text = "Version: ";
            // 
            // customerLabel
            // 
            this.customerLabel.AutoSize = true;
            this.customerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.customerLabel.Location = new System.Drawing.Point(58, 79);
            this.customerLabel.Name = "customerLabel";
            this.customerLabel.Size = new System.Drawing.Size(92, 18);
            this.customerLabel.TabIndex = 43;
            this.customerLabel.Text = "Customer: ";
            // 
            // commentsTextBox
            // 
            this.commentsTextBox.Location = new System.Drawing.Point(61, 191);
            this.commentsTextBox.Multiline = true;
            this.commentsTextBox.Name = "commentsTextBox";
            this.commentsTextBox.Size = new System.Drawing.Size(223, 140);
            this.commentsTextBox.TabIndex = 46;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 47;
            this.label1.Text = "Comments";
            // 
            // expectedDatePicker
            // 
            this.expectedDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.expectedDatePicker.Location = new System.Drawing.Point(327, 167);
            this.expectedDatePicker.Name = "expectedDatePicker";
            this.expectedDatePicker.Size = new System.Drawing.Size(150, 20);
            this.expectedDatePicker.TabIndex = 48;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(325, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(266, 13);
            this.label2.TabIndex = 54;
            this.label2.Text = "Actual Date and Time (Use if update has been applied)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(325, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 13);
            this.label3.TabIndex = 53;
            this.label3.Text = "Expected Date and Time";
            // 
            // useActual
            // 
            this.useActual.AutoSize = true;
            this.useActual.Location = new System.Drawing.Point(328, 251);
            this.useActual.Name = "useActual";
            this.useActual.Size = new System.Drawing.Size(100, 17);
            this.useActual.TabIndex = 52;
            this.useActual.Text = "Update is Done";
            this.useActual.UseVisualStyleBackColor = true;
            this.useActual.CheckedChanged += new System.EventHandler(this.useActual_CheckedChanged);
            // 
            // actualTimePicker
            // 
            this.actualTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.actualTimePicker.Location = new System.Drawing.Point(483, 225);
            this.actualTimePicker.Name = "actualTimePicker";
            this.actualTimePicker.ShowUpDown = true;
            this.actualTimePicker.Size = new System.Drawing.Size(111, 20);
            this.actualTimePicker.TabIndex = 51;
            // 
            // actualDatePicker
            // 
            this.actualDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.actualDatePicker.Location = new System.Drawing.Point(328, 225);
            this.actualDatePicker.Name = "actualDatePicker";
            this.actualDatePicker.Size = new System.Drawing.Size(150, 20);
            this.actualDatePicker.TabIndex = 50;
            // 
            // expectedTimePicker
            // 
            this.expectedTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.expectedTimePicker.Location = new System.Drawing.Point(483, 167);
            this.expectedTimePicker.Name = "expectedTimePicker";
            this.expectedTimePicker.ShowUpDown = true;
            this.expectedTimePicker.Size = new System.Drawing.Size(111, 20);
            this.expectedTimePicker.TabIndex = 49;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(324, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 55;
            this.label4.Text = "Assigned To";
            // 
            // employeeComboBox
            // 
            this.employeeComboBox.FormattingEnabled = true;
            this.employeeComboBox.Location = new System.Drawing.Point(396, 116);
            this.employeeComboBox.Name = "employeeComboBox";
            this.employeeComboBox.Size = new System.Drawing.Size(195, 21);
            this.employeeComboBox.TabIndex = 56;
            // 
            // contactedCB
            // 
            this.contactedCB.AutoSize = true;
            this.contactedCB.Location = new System.Drawing.Point(61, 149);
            this.contactedCB.Name = "contactedCB";
            this.contactedCB.Size = new System.Drawing.Size(168, 17);
            this.contactedCB.TabIndex = 57;
            this.contactedCB.Text = "Customer has been contacted";
            this.contactedCB.UseVisualStyleBackColor = true;
            this.contactedCB.CheckedChanged += new System.EventHandler(this.contactedCB_CheckedChanged);
            // 
            // EditUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 357);
            this.Controls.Add(this.contactedCB);
            this.Controls.Add(this.employeeComboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.useActual);
            this.Controls.Add(this.actualTimePicker);
            this.Controls.Add(this.actualDatePicker);
            this.Controls.Add(this.expectedTimePicker);
            this.Controls.Add(this.expectedDatePicker);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.commentsTextBox);
            this.Controls.Add(this.versionLabel);
            this.Controls.Add(this.customerLabel);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.subLbl);
            this.Controls.Add(this.editCustLbl);
            this.Name = "EditUpdate";
            this.Text = "Aspect PT Version Database - Edit Update";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Label subLbl;
        private System.Windows.Forms.Label editCustLbl;
        private System.Windows.Forms.Label versionLabel;
        private System.Windows.Forms.Label customerLabel;
        private System.Windows.Forms.TextBox commentsTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker expectedDatePicker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox useActual;
        private System.Windows.Forms.DateTimePicker actualTimePicker;
        private System.Windows.Forms.DateTimePicker actualDatePicker;
        private System.Windows.Forms.DateTimePicker expectedTimePicker;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox employeeComboBox;
        private System.Windows.Forms.CheckBox contactedCB;
    }
}