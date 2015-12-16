namespace AspectUpdatesDummy
{
    partial class NewVersionCustomers
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
            this.CustomersGrid = new System.Windows.Forms.DataGridView();
            this.newVersUpdatesLbl = new System.Windows.Forms.Label();
            this.subLbl = new System.Windows.Forms.Label();
            this.submitBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.actualTimePicker = new System.Windows.Forms.DateTimePicker();
            this.actualDatePicker = new System.Windows.Forms.DateTimePicker();
            this.selectButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CustomersGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // CustomersGrid
            // 
            this.CustomersGrid.AllowUserToAddRows = false;
            this.CustomersGrid.AllowUserToDeleteRows = false;
            this.CustomersGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CustomersGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CustomersGrid.Location = new System.Drawing.Point(77, 58);
            this.CustomersGrid.MultiSelect = false;
            this.CustomersGrid.Name = "CustomersGrid";
            this.CustomersGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CustomersGrid.Size = new System.Drawing.Size(485, 147);
            this.CustomersGrid.TabIndex = 0;
            // 
            // newVersUpdatesLbl
            // 
            this.newVersUpdatesLbl.AutoSize = true;
            this.newVersUpdatesLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newVersUpdatesLbl.Location = new System.Drawing.Point(282, 9);
            this.newVersUpdatesLbl.Name = "newVersUpdatesLbl";
            this.newVersUpdatesLbl.Size = new System.Drawing.Size(77, 20);
            this.newVersUpdatesLbl.TabIndex = 4;
            this.newVersUpdatesLbl.Text = "Updates";
            // 
            // subLbl
            // 
            this.subLbl.AutoSize = true;
            this.subLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subLbl.Location = new System.Drawing.Point(154, 29);
            this.subLbl.Name = "subLbl";
            this.subLbl.Size = new System.Drawing.Size(331, 15);
            this.subLbl.TabIndex = 12;
            this.subLbl.Text = "Please select customers that will update to this new version:";
            this.subLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // submitBtn
            // 
            this.submitBtn.Location = new System.Drawing.Point(252, 267);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(127, 42);
            this.submitBtn.TabIndex = 13;
            this.submitBtn.Text = "Submit";
            this.submitBtn.UseVisualStyleBackColor = true;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(233, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Expected Date and Time of Update Application:";
            // 
            // actualTimePicker
            // 
            this.actualTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.actualTimePicker.Location = new System.Drawing.Point(232, 231);
            this.actualTimePicker.Name = "actualTimePicker";
            this.actualTimePicker.ShowUpDown = true;
            this.actualTimePicker.Size = new System.Drawing.Size(111, 20);
            this.actualTimePicker.TabIndex = 25;
            // 
            // actualDatePicker
            // 
            this.actualDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.actualDatePicker.Location = new System.Drawing.Point(77, 231);
            this.actualDatePicker.Name = "actualDatePicker";
            this.actualDatePicker.Size = new System.Drawing.Size(150, 20);
            this.actualDatePicker.TabIndex = 24;
            // 
            // selectButton
            // 
            this.selectButton.Location = new System.Drawing.Point(435, 215);
            this.selectButton.Name = "selectButton";
            this.selectButton.Size = new System.Drawing.Size(127, 27);
            this.selectButton.TabIndex = 27;
            this.selectButton.Text = "Select All";
            this.selectButton.UseVisualStyleBackColor = true;
            this.selectButton.Click += new System.EventHandler(this.selectButton_Click);
            // 
            // NewVersionCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 330);
            this.Controls.Add(this.selectButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.actualTimePicker);
            this.Controls.Add(this.actualDatePicker);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.subLbl);
            this.Controls.Add(this.newVersUpdatesLbl);
            this.Controls.Add(this.CustomersGrid);
            this.Name = "NewVersionCustomers";
            this.Text = "Aspect PT Version Database - New Version Updates";
            ((System.ComponentModel.ISupportInitialize)(this.CustomersGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView CustomersGrid;
        private System.Windows.Forms.Label newVersUpdatesLbl;
        private System.Windows.Forms.Label subLbl;
        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker actualTimePicker;
        private System.Windows.Forms.DateTimePicker actualDatePicker;
        private System.Windows.Forms.Button selectButton;
    }
}