﻿namespace AspectUpdatesDummy
{
    partial class MainMenu
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
            this.mainMenuTitle = new System.Windows.Forms.Label();
            this.mainAddCustBtn = new System.Windows.Forms.Button();
            this.mainAddVersBtn = new System.Windows.Forms.Button();
            this.customersBtn = new System.Windows.Forms.Button();
            this.versionsBtn = new System.Windows.Forms.Button();
            this.mainUpdatesBtn = new System.Windows.Forms.Button();
            this.mainAddUpdateBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mainMenuTitle
            // 
            this.mainMenuTitle.AutoSize = true;
            this.mainMenuTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainMenuTitle.Location = new System.Drawing.Point(121, 9);
            this.mainMenuTitle.Name = "mainMenuTitle";
            this.mainMenuTitle.Size = new System.Drawing.Size(276, 24);
            this.mainMenuTitle.TabIndex = 0;
            this.mainMenuTitle.Text = "Aspect PT Version Database";
            // 
            // mainAddCustBtn
            // 
            this.mainAddCustBtn.Location = new System.Drawing.Point(53, 65);
            this.mainAddCustBtn.Name = "mainAddCustBtn";
            this.mainAddCustBtn.Size = new System.Drawing.Size(191, 46);
            this.mainAddCustBtn.TabIndex = 1;
            this.mainAddCustBtn.Text = "Add Customer";
            this.mainAddCustBtn.UseVisualStyleBackColor = true;
            this.mainAddCustBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // mainAddVersBtn
            // 
            this.mainAddVersBtn.Location = new System.Drawing.Point(53, 128);
            this.mainAddVersBtn.Name = "mainAddVersBtn";
            this.mainAddVersBtn.Size = new System.Drawing.Size(191, 46);
            this.mainAddVersBtn.TabIndex = 2;
            this.mainAddVersBtn.Text = "Add Version";
            this.mainAddVersBtn.UseVisualStyleBackColor = true;
            this.mainAddVersBtn.Click += new System.EventHandler(this.mainAddVersBtn_Click);
            // 
            // customersBtn
            // 
            this.customersBtn.Location = new System.Drawing.Point(279, 65);
            this.customersBtn.Name = "customersBtn";
            this.customersBtn.Size = new System.Drawing.Size(191, 46);
            this.customersBtn.TabIndex = 3;
            this.customersBtn.Text = "Customers";
            this.customersBtn.UseVisualStyleBackColor = true;
            this.customersBtn.Click += new System.EventHandler(this.customersBtn_Click);
            // 
            // versionsBtn
            // 
            this.versionsBtn.Location = new System.Drawing.Point(279, 128);
            this.versionsBtn.Name = "versionsBtn";
            this.versionsBtn.Size = new System.Drawing.Size(191, 46);
            this.versionsBtn.TabIndex = 4;
            this.versionsBtn.Text = "Versions";
            this.versionsBtn.UseVisualStyleBackColor = true;
            this.versionsBtn.Click += new System.EventHandler(this.versionsBtn_Click);
            // 
            // mainUpdatesBtn
            // 
            this.mainUpdatesBtn.Location = new System.Drawing.Point(279, 192);
            this.mainUpdatesBtn.Name = "mainUpdatesBtn";
            this.mainUpdatesBtn.Size = new System.Drawing.Size(191, 46);
            this.mainUpdatesBtn.TabIndex = 6;
            this.mainUpdatesBtn.Text = "Updates";
            this.mainUpdatesBtn.UseVisualStyleBackColor = true;
            this.mainUpdatesBtn.Click += new System.EventHandler(this.mainUpdatesBtn_Click);
            // 
            // mainAddUpdateBtn
            // 
            this.mainAddUpdateBtn.Location = new System.Drawing.Point(53, 192);
            this.mainAddUpdateBtn.Name = "mainAddUpdateBtn";
            this.mainAddUpdateBtn.Size = new System.Drawing.Size(191, 46);
            this.mainAddUpdateBtn.TabIndex = 5;
            this.mainAddUpdateBtn.Text = "Add Update";
            this.mainAddUpdateBtn.UseVisualStyleBackColor = true;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(526, 278);
            this.Controls.Add(this.mainUpdatesBtn);
            this.Controls.Add(this.mainAddUpdateBtn);
            this.Controls.Add(this.versionsBtn);
            this.Controls.Add(this.customersBtn);
            this.Controls.Add(this.mainAddVersBtn);
            this.Controls.Add(this.mainAddCustBtn);
            this.Controls.Add(this.mainMenuTitle);
            this.Name = "MainMenu";
            this.Text = "Aspect PT Version Database";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label mainMenuTitle;
        private System.Windows.Forms.Button mainAddCustBtn;
        private System.Windows.Forms.Button mainAddVersBtn;
        private System.Windows.Forms.Button customersBtn;
        private System.Windows.Forms.Button versionsBtn;
        private System.Windows.Forms.Button mainUpdatesBtn;
        private System.Windows.Forms.Button mainAddUpdateBtn;
    }
}

