namespace AspectUpdatesDummy
{
    partial class NewUpdatePage
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
            this.newVersLbl = new System.Windows.Forms.Label();
            this.submitBtn = new System.Windows.Forms.Button();
            this.mainMenuBtn6 = new System.Windows.Forms.Button();
            this.expectedDatePicker = new System.Windows.Forms.DateTimePicker();
            this.expectedTimePicker = new System.Windows.Forms.DateTimePicker();
            this.versionGrid = new System.Windows.Forms.DataGridView();
            this.actualTimePicker = new System.Windows.Forms.DateTimePicker();
            this.actualDatePicker = new System.Windows.Forms.DateTimePicker();
            this.useActual = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.versionGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // subLbl
            // 
            this.subLbl.AutoSize = true;
            this.subLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subLbl.Location = new System.Drawing.Point(215, 29);
            this.subLbl.Name = "subLbl";
            this.subLbl.Size = new System.Drawing.Size(211, 15);
            this.subLbl.TabIndex = 13;
            this.subLbl.Text = "Please enter new update information:";
            this.subLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // newVersLbl
            // 
            this.newVersLbl.AutoSize = true;
            this.newVersLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newVersLbl.Location = new System.Drawing.Point(265, 9);
            this.newVersLbl.Name = "newVersLbl";
            this.newVersLbl.Size = new System.Drawing.Size(116, 20);
            this.newVersLbl.TabIndex = 12;
            this.newVersLbl.Text = "New Updates";
            // 
            // submitBtn
            // 
            this.submitBtn.Location = new System.Drawing.Point(331, 252);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(127, 42);
            this.submitBtn.TabIndex = 15;
            this.submitBtn.Text = "Select Customers";
            this.submitBtn.UseVisualStyleBackColor = true;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // mainMenuBtn6
            // 
            this.mainMenuBtn6.Location = new System.Drawing.Point(489, 252);
            this.mainMenuBtn6.Name = "mainMenuBtn6";
            this.mainMenuBtn6.Size = new System.Drawing.Size(127, 42);
            this.mainMenuBtn6.TabIndex = 14;
            this.mainMenuBtn6.Text = "Main Menu";
            this.mainMenuBtn6.UseVisualStyleBackColor = true;
            this.mainMenuBtn6.Click += new System.EventHandler(this.mainMenuBtn6_Click);
            // 
            // expectedDatePicker
            // 
            this.expectedDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.expectedDatePicker.Location = new System.Drawing.Point(35, 111);
            this.expectedDatePicker.Name = "expectedDatePicker";
            this.expectedDatePicker.Size = new System.Drawing.Size(150, 20);
            this.expectedDatePicker.TabIndex = 16;
            // 
            // expectedTimePicker
            // 
            this.expectedTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.expectedTimePicker.Location = new System.Drawing.Point(190, 111);
            this.expectedTimePicker.Name = "expectedTimePicker";
            this.expectedTimePicker.ShowUpDown = true;
            this.expectedTimePicker.Size = new System.Drawing.Size(111, 20);
            this.expectedTimePicker.TabIndex = 17;
            // 
            // versionGrid
            // 
            this.versionGrid.AllowUserToAddRows = false;
            this.versionGrid.AllowUserToDeleteRows = false;
            this.versionGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.versionGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.versionGrid.Location = new System.Drawing.Point(335, 90);
            this.versionGrid.MultiSelect = false;
            this.versionGrid.Name = "versionGrid";
            this.versionGrid.ReadOnly = true;
            this.versionGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.versionGrid.Size = new System.Drawing.Size(281, 139);
            this.versionGrid.TabIndex = 18;
            // 
            // actualTimePicker
            // 
            this.actualTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.actualTimePicker.Location = new System.Drawing.Point(190, 192);
            this.actualTimePicker.Name = "actualTimePicker";
            this.actualTimePicker.ShowUpDown = true;
            this.actualTimePicker.Size = new System.Drawing.Size(111, 20);
            this.actualTimePicker.TabIndex = 20;
            // 
            // actualDatePicker
            // 
            this.actualDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.actualDatePicker.Location = new System.Drawing.Point(35, 192);
            this.actualDatePicker.Name = "actualDatePicker";
            this.actualDatePicker.Size = new System.Drawing.Size(150, 20);
            this.actualDatePicker.TabIndex = 19;
            // 
            // useActual
            // 
            this.useActual.AutoSize = true;
            this.useActual.Location = new System.Drawing.Point(35, 218);
            this.useActual.Name = "useActual";
            this.useActual.Size = new System.Drawing.Size(151, 17);
            this.useActual.TabIndex = 21;
            this.useActual.Text = "Use Actual Date and Time";
            this.useActual.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Expected Date and Time";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(266, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Actual Date and Time (Use if update has been applied)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(332, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Version Being Updated To";
            // 
            // NewUpdatePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 330);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.useActual);
            this.Controls.Add(this.actualTimePicker);
            this.Controls.Add(this.actualDatePicker);
            this.Controls.Add(this.versionGrid);
            this.Controls.Add(this.expectedTimePicker);
            this.Controls.Add(this.expectedDatePicker);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.mainMenuBtn6);
            this.Controls.Add(this.subLbl);
            this.Controls.Add(this.newVersLbl);
            this.Name = "NewUpdatePage";
            this.Text = "Aspect PT Version Database - Add Updates";
            ((System.ComponentModel.ISupportInitialize)(this.versionGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label subLbl;
        private System.Windows.Forms.Label newVersLbl;
        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.Button mainMenuBtn6;
        private System.Windows.Forms.DateTimePicker expectedDatePicker;
        private System.Windows.Forms.DateTimePicker expectedTimePicker;
        private System.Windows.Forms.DataGridView versionGrid;
        private System.Windows.Forms.DateTimePicker actualTimePicker;
        private System.Windows.Forms.DateTimePicker actualDatePicker;
        private System.Windows.Forms.CheckBox useActual;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}