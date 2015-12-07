namespace AspectUpdatesDummy
{
    partial class ExistingVersions
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
            this.components = new System.ComponentModel.Container();
            this.mainMenuBtn4 = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.editBtn = new System.Windows.Forms.Button();
            this.inspectBtn = new System.Windows.Forms.Button();
            this.existingVersionsGrid = new System.Windows.Forms.DataGridView();
            this.versionsLbl = new System.Windows.Forms.Label();
            this.versionDatabase1DataSet1 = new AspectUpdatesDummy.VersionDatabase1DataSet1();
            this.versionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.versionTableAdapter = new AspectUpdatesDummy.VersionDatabase1DataSet1TableAdapters.VersionTableAdapter();
            this.mainAddVersBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.existingVersionsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.versionDatabase1DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.versionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // mainMenuBtn4
            // 
            this.mainMenuBtn4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.mainMenuBtn4.Location = new System.Drawing.Point(583, 323);
            this.mainMenuBtn4.Name = "mainMenuBtn4";
            this.mainMenuBtn4.Size = new System.Drawing.Size(134, 40);
            this.mainMenuBtn4.TabIndex = 24;
            this.mainMenuBtn4.Text = "Main Menu";
            this.mainMenuBtn4.UseVisualStyleBackColor = true;
            this.mainMenuBtn4.Click += new System.EventHandler(this.mainMenuBtn4_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.deleteBtn.Location = new System.Drawing.Point(443, 323);
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
            this.editBtn.Location = new System.Drawing.Point(303, 323);
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
            this.inspectBtn.Location = new System.Drawing.Point(163, 323);
            this.inspectBtn.Name = "inspectBtn";
            this.inspectBtn.Size = new System.Drawing.Size(134, 40);
            this.inspectBtn.TabIndex = 21;
            this.inspectBtn.Text = "Inspect";
            this.inspectBtn.UseVisualStyleBackColor = true;
            this.inspectBtn.Click += new System.EventHandler(this.inspectBtn_Click);
            // 
            // existingVersionsGrid
            // 
            this.existingVersionsGrid.AllowUserToAddRows = false;
            this.existingVersionsGrid.AllowUserToDeleteRows = false;
            this.existingVersionsGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.existingVersionsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.existingVersionsGrid.Location = new System.Drawing.Point(23, 50);
            this.existingVersionsGrid.MultiSelect = false;
            this.existingVersionsGrid.Name = "existingVersionsGrid";
            this.existingVersionsGrid.ReadOnly = true;
            this.existingVersionsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.existingVersionsGrid.Size = new System.Drawing.Size(694, 255);
            this.existingVersionsGrid.TabIndex = 20;
            // 
            // versionsLbl
            // 
            this.versionsLbl.AutoSize = true;
            this.versionsLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.versionsLbl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.versionsLbl.Location = new System.Drawing.Point(327, 9);
            this.versionsLbl.Name = "versionsLbl";
            this.versionsLbl.Size = new System.Drawing.Size(79, 20);
            this.versionsLbl.TabIndex = 19;
            this.versionsLbl.Text = "Versions";
            // 
            // versionDatabase1DataSet1
            // 
            this.versionDatabase1DataSet1.DataSetName = "VersionDatabase1DataSet1";
            this.versionDatabase1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // versionBindingSource
            // 
            this.versionBindingSource.DataMember = "Version";
            this.versionBindingSource.DataSource = this.versionDatabase1DataSet1;
            // 
            // versionTableAdapter
            // 
            this.versionTableAdapter.ClearBeforeFill = true;
            // 
            // mainAddVersBtn
            // 
            this.mainAddVersBtn.Location = new System.Drawing.Point(23, 323);
            this.mainAddVersBtn.Name = "mainAddVersBtn";
            this.mainAddVersBtn.Size = new System.Drawing.Size(134, 40);
            this.mainAddVersBtn.TabIndex = 25;
            this.mainAddVersBtn.Text = "Add Version";
            this.mainAddVersBtn.UseVisualStyleBackColor = true;
            this.mainAddVersBtn.Click += new System.EventHandler(this.mainAddVersBtn_Click);
            // 
            // ExistingVersions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 375);
            this.Controls.Add(this.mainAddVersBtn);
            this.Controls.Add(this.mainMenuBtn4);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.inspectBtn);
            this.Controls.Add(this.existingVersionsGrid);
            this.Controls.Add(this.versionsLbl);
            this.Name = "ExistingVersions";
            this.Text = "Aspect PT Version Database - Versions";
            this.Load += new System.EventHandler(this.ExistingVersions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.existingVersionsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.versionDatabase1DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.versionBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button mainMenuBtn4;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.Button inspectBtn;
        private System.Windows.Forms.DataGridView existingVersionsGrid;
        private System.Windows.Forms.Label versionsLbl;
        private VersionDatabase1DataSet1 versionDatabase1DataSet1;
        private System.Windows.Forms.BindingSource versionBindingSource;
        private VersionDatabase1DataSet1TableAdapters.VersionTableAdapter versionTableAdapter;
        private System.Windows.Forms.Button mainAddVersBtn;
    }
}