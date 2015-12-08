namespace AspectUpdatesDummy
{
    partial class ExistingEmployees
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
            this.mainAddEmpBtn = new System.Windows.Forms.Button();
            this.mainMenuBtn3 = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.editBtn = new System.Windows.Forms.Button();
            this.inspectBtn = new System.Windows.Forms.Button();
            this.EmployeesGrid = new System.Windows.Forms.DataGridView();
            this.CustLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeesGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // mainAddEmpBtn
            // 
            this.mainAddEmpBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.mainAddEmpBtn.Location = new System.Drawing.Point(48, 74);
            this.mainAddEmpBtn.Name = "mainAddEmpBtn";
            this.mainAddEmpBtn.Size = new System.Drawing.Size(132, 40);
            this.mainAddEmpBtn.TabIndex = 26;
            this.mainAddEmpBtn.Text = "Add Employee";
            this.mainAddEmpBtn.UseVisualStyleBackColor = true;
            this.mainAddEmpBtn.Click += new System.EventHandler(this.mainAddEmpBtn_Click);
            // 
            // mainMenuBtn3
            // 
            this.mainMenuBtn3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.mainMenuBtn3.Location = new System.Drawing.Point(46, 258);
            this.mainMenuBtn3.Name = "mainMenuBtn3";
            this.mainMenuBtn3.Size = new System.Drawing.Size(134, 40);
            this.mainMenuBtn3.TabIndex = 25;
            this.mainMenuBtn3.Text = "Main Menu";
            this.mainMenuBtn3.UseVisualStyleBackColor = true;
            this.mainMenuBtn3.Click += new System.EventHandler(this.mainMenuBtn3_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.deleteBtn.Location = new System.Drawing.Point(46, 212);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(134, 40);
            this.deleteBtn.TabIndex = 24;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            // 
            // editBtn
            // 
            this.editBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.editBtn.Location = new System.Drawing.Point(46, 166);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(134, 40);
            this.editBtn.TabIndex = 23;
            this.editBtn.Text = "Edit";
            this.editBtn.UseVisualStyleBackColor = true;
            // 
            // inspectBtn
            // 
            this.inspectBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.inspectBtn.Location = new System.Drawing.Point(46, 120);
            this.inspectBtn.Name = "inspectBtn";
            this.inspectBtn.Size = new System.Drawing.Size(134, 40);
            this.inspectBtn.TabIndex = 22;
            this.inspectBtn.Text = "Inspect";
            this.inspectBtn.UseVisualStyleBackColor = true;
            this.inspectBtn.Click += new System.EventHandler(this.inspectBtn_Click);
            // 
            // EmployeesGrid
            // 
            this.EmployeesGrid.AllowUserToAddRows = false;
            this.EmployeesGrid.AllowUserToDeleteRows = false;
            this.EmployeesGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.EmployeesGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.EmployeesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EmployeesGrid.Location = new System.Drawing.Point(237, 75);
            this.EmployeesGrid.MultiSelect = false;
            this.EmployeesGrid.Name = "EmployeesGrid";
            this.EmployeesGrid.ReadOnly = true;
            this.EmployeesGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.EmployeesGrid.Size = new System.Drawing.Size(297, 224);
            this.EmployeesGrid.TabIndex = 21;
            // 
            // CustLbl
            // 
            this.CustLbl.AutoSize = true;
            this.CustLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.CustLbl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.CustLbl.Location = new System.Drawing.Point(241, 18);
            this.CustLbl.Name = "CustLbl";
            this.CustLbl.Size = new System.Drawing.Size(96, 20);
            this.CustLbl.TabIndex = 20;
            this.CustLbl.Text = "Employees";
            // 
            // ExistingEmployees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 330);
            this.Controls.Add(this.mainAddEmpBtn);
            this.Controls.Add(this.mainMenuBtn3);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.inspectBtn);
            this.Controls.Add(this.EmployeesGrid);
            this.Controls.Add(this.CustLbl);
            this.Name = "ExistingEmployees";
            this.Text = "Aspect PT Version Database - Employees";
            ((System.ComponentModel.ISupportInitialize)(this.EmployeesGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button mainAddEmpBtn;
        private System.Windows.Forms.Button mainMenuBtn3;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.Button inspectBtn;
        private System.Windows.Forms.DataGridView EmployeesGrid;
        private System.Windows.Forms.Label CustLbl;
    }
}