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
            this.versionGrid = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.commentsTxtBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
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
            this.submitBtn.Location = new System.Drawing.Point(335, 252);
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
            this.mainMenuBtn6.Text = "Menu";
            this.mainMenuBtn6.UseVisualStyleBackColor = true;
            this.mainMenuBtn6.Click += new System.EventHandler(this.mainMenuBtn6_Click);
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(332, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Version Being Updated To";
            // 
            // commentsTxtBox
            // 
            this.commentsTxtBox.Location = new System.Drawing.Point(24, 90);
            this.commentsTxtBox.Multiline = true;
            this.commentsTxtBox.Name = "commentsTxtBox";
            this.commentsTxtBox.Size = new System.Drawing.Size(262, 139);
            this.commentsTxtBox.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Comments (Optional)";
            // 
            // NewUpdatePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 330);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.commentsTxtBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.versionGrid);
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
        private System.Windows.Forms.DataGridView versionGrid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox commentsTxtBox;
        private System.Windows.Forms.Label label4;
    }
}