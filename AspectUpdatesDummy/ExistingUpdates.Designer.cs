﻿namespace AspectUpdatesDummy
{
    partial class ExistingUpdates
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
            this.mainMenuBtn5 = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.editBtn = new System.Windows.Forms.Button();
            this.inspectBtn = new System.Windows.Forms.Button();
            this.UpdatesGrid = new System.Windows.Forms.DataGridView();
            this.UpdtLbl = new System.Windows.Forms.Label();
            this.mainAddVersBtn = new System.Windows.Forms.Button();
            this.currentVersionBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.UpdatesGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // mainMenuBtn5
            // 
            this.mainMenuBtn5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.mainMenuBtn5.Location = new System.Drawing.Point(582, 323);
            this.mainMenuBtn5.Name = "mainMenuBtn5";
            this.mainMenuBtn5.Size = new System.Drawing.Size(134, 40);
            this.mainMenuBtn5.TabIndex = 24;
            this.mainMenuBtn5.Text = "Main Menu";
            this.mainMenuBtn5.UseVisualStyleBackColor = true;
            this.mainMenuBtn5.Click += new System.EventHandler(this.mainMenuBtn5_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.deleteBtn.Location = new System.Drawing.Point(442, 323);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(134, 40);
            this.deleteBtn.TabIndex = 23;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // editBtn
            // 
            this.editBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.editBtn.Location = new System.Drawing.Point(302, 323);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(134, 40);
            this.editBtn.TabIndex = 22;
            this.editBtn.Text = "Edit";
            this.editBtn.UseVisualStyleBackColor = true;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // inspectBtn
            // 
            this.inspectBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.inspectBtn.Location = new System.Drawing.Point(162, 323);
            this.inspectBtn.Name = "inspectBtn";
            this.inspectBtn.Size = new System.Drawing.Size(134, 40);
            this.inspectBtn.TabIndex = 21;
            this.inspectBtn.Text = "Inspect";
            this.inspectBtn.UseVisualStyleBackColor = true;
            this.inspectBtn.Click += new System.EventHandler(this.inspectBtn_Click);
            // 
            // UpdatesGrid
            // 
            this.UpdatesGrid.AllowUserToAddRows = false;
            this.UpdatesGrid.AllowUserToDeleteRows = false;
            this.UpdatesGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.UpdatesGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.UpdatesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UpdatesGrid.Location = new System.Drawing.Point(22, 65);
            this.UpdatesGrid.MultiSelect = false;
            this.UpdatesGrid.Name = "UpdatesGrid";
            this.UpdatesGrid.ReadOnly = true;
            this.UpdatesGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.UpdatesGrid.Size = new System.Drawing.Size(694, 239);
            this.UpdatesGrid.TabIndex = 20;
            // 
            // UpdtLbl
            // 
            this.UpdtLbl.AutoSize = true;
            this.UpdtLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.UpdtLbl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.UpdtLbl.Location = new System.Drawing.Point(330, 9);
            this.UpdtLbl.Name = "UpdtLbl";
            this.UpdtLbl.Size = new System.Drawing.Size(77, 20);
            this.UpdtLbl.TabIndex = 19;
            this.UpdtLbl.Text = "Updates";
            // 
            // mainAddVersBtn
            // 
            this.mainAddVersBtn.Location = new System.Drawing.Point(22, 323);
            this.mainAddVersBtn.Name = "mainAddVersBtn";
            this.mainAddVersBtn.Size = new System.Drawing.Size(134, 40);
            this.mainAddVersBtn.TabIndex = 25;
            this.mainAddVersBtn.Text = "Add Update";
            this.mainAddVersBtn.UseVisualStyleBackColor = true;
            this.mainAddVersBtn.Click += new System.EventHandler(this.mainAddVersBtn_Click);
            // 
            // currentVersionBtn
            // 
            this.currentVersionBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.currentVersionBtn.Location = new System.Drawing.Point(22, 36);
            this.currentVersionBtn.Name = "currentVersionBtn";
            this.currentVersionBtn.Size = new System.Drawing.Size(134, 23);
            this.currentVersionBtn.TabIndex = 26;
            this.currentVersionBtn.Text = "All";
            this.currentVersionBtn.UseVisualStyleBackColor = true;
            this.currentVersionBtn.Click += new System.EventHandler(this.currentVersionBtn_Click);
            // 
            // ExistingUpdates
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 375);
            this.Controls.Add(this.currentVersionBtn);
            this.Controls.Add(this.mainAddVersBtn);
            this.Controls.Add(this.mainMenuBtn5);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.inspectBtn);
            this.Controls.Add(this.UpdatesGrid);
            this.Controls.Add(this.UpdtLbl);
            this.Name = "ExistingUpdates";
            this.Text = "Aspect PT Version Database - Updates";
            ((System.ComponentModel.ISupportInitialize)(this.UpdatesGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button mainMenuBtn5;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.Button inspectBtn;
        private System.Windows.Forms.DataGridView UpdatesGrid;
        private System.Windows.Forms.Label UpdtLbl;
        private System.Windows.Forms.Button mainAddVersBtn;
        private System.Windows.Forms.Button currentVersionBtn;
    }
}