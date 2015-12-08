namespace AspectUpdatesDummy
{
    partial class NewCustomerPage
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
            this.mainMenuBtn1 = new System.Windows.Forms.Button();
            this.subLbl = new System.Windows.Forms.Label();
            this.newCustLbl = new System.Windows.Forms.Label();
            this.submitBtn = new System.Windows.Forms.Button();
            this.idLbl = new System.Windows.Forms.Label();
            this.nameTxtBx = new System.Windows.Forms.TextBox();
            this.detailsLbl = new System.Windows.Forms.Label();
            this.descriptionTxtBx = new System.Windows.Forms.TextBox();
            this.versionDatabase1DataSet = new AspectUpdatesDummy.VersionDatabase1DataSet();
            this.versionDatabase1DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.versionDatabase1DataSet1 = new AspectUpdatesDummy.VersionDatabase1DataSet1();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerTableAdapter = new AspectUpdatesDummy.VersionDatabase1DataSet1TableAdapters.CustomerTableAdapter();
            this.versionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.versionTableAdapter = new AspectUpdatesDummy.VersionDatabase1DataSet1TableAdapters.VersionTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.versionGrid = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.logonTB = new System.Windows.Forms.TextBox();
            this.contactsTB = new System.Windows.Forms.TextBox();
            this.plcTB = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.versionDatabase1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.versionDatabase1DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.versionDatabase1DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.versionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.versionGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // mainMenuBtn1
            // 
            this.mainMenuBtn1.Location = new System.Drawing.Point(593, 426);
            this.mainMenuBtn1.Name = "mainMenuBtn1";
            this.mainMenuBtn1.Size = new System.Drawing.Size(127, 42);
            this.mainMenuBtn1.TabIndex = 0;
            this.mainMenuBtn1.Text = "Menu";
            this.mainMenuBtn1.UseVisualStyleBackColor = true;
            this.mainMenuBtn1.Click += new System.EventHandler(this.mainMenuBtn1_Click);
            // 
            // subLbl
            // 
            this.subLbl.AutoSize = true;
            this.subLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subLbl.Location = new System.Drawing.Point(261, 28);
            this.subLbl.Name = "subLbl";
            this.subLbl.Size = new System.Drawing.Size(224, 15);
            this.subLbl.TabIndex = 13;
            this.subLbl.Text = "Please enter new customer information:";
            this.subLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // newCustLbl
            // 
            this.newCustLbl.AutoSize = true;
            this.newCustLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newCustLbl.Location = new System.Drawing.Point(310, 9);
            this.newCustLbl.Name = "newCustLbl";
            this.newCustLbl.Size = new System.Drawing.Size(125, 20);
            this.newCustLbl.TabIndex = 12;
            this.newCustLbl.Text = "New Customer";
            // 
            // submitBtn
            // 
            this.submitBtn.Location = new System.Drawing.Point(424, 426);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(127, 42);
            this.submitBtn.TabIndex = 14;
            this.submitBtn.Text = "Submit";
            this.submitBtn.UseVisualStyleBackColor = true;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // idLbl
            // 
            this.idLbl.AutoSize = true;
            this.idLbl.Location = new System.Drawing.Point(29, 59);
            this.idLbl.Name = "idLbl";
            this.idLbl.Size = new System.Drawing.Size(107, 13);
            this.idLbl.TabIndex = 18;
            this.idLbl.Text = "New Customer Name";
            // 
            // nameTxtBx
            // 
            this.nameTxtBx.Location = new System.Drawing.Point(32, 75);
            this.nameTxtBx.Name = "nameTxtBx";
            this.nameTxtBx.Size = new System.Drawing.Size(222, 20);
            this.nameTxtBx.TabIndex = 17;
            // 
            // detailsLbl
            // 
            this.detailsLbl.AutoSize = true;
            this.detailsLbl.Location = new System.Drawing.Point(29, 118);
            this.detailsLbl.Name = "detailsLbl";
            this.detailsLbl.Size = new System.Drawing.Size(87, 13);
            this.detailsLbl.TabIndex = 16;
            this.detailsLbl.Text = "Details (Optional)";
            // 
            // descriptionTxtBx
            // 
            this.descriptionTxtBx.Location = new System.Drawing.Point(32, 134);
            this.descriptionTxtBx.Multiline = true;
            this.descriptionTxtBx.Name = "descriptionTxtBx";
            this.descriptionTxtBx.Size = new System.Drawing.Size(222, 100);
            this.descriptionTxtBx.TabIndex = 15;
            // 
            // versionDatabase1DataSet
            // 
            this.versionDatabase1DataSet.DataSetName = "VersionDatabase1DataSet";
            this.versionDatabase1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // versionDatabase1DataSetBindingSource
            // 
            this.versionDatabase1DataSetBindingSource.DataSource = this.versionDatabase1DataSet;
            this.versionDatabase1DataSetBindingSource.Position = 0;
            // 
            // versionDatabase1DataSet1
            // 
            this.versionDatabase1DataSet1.DataSetName = "VersionDatabase1DataSet1";
            this.versionDatabase1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataMember = "Customer";
            this.customerBindingSource.DataSource = this.versionDatabase1DataSet1;
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(279, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "New Customer Version";
            // 
            // versionGrid
            // 
            this.versionGrid.AllowUserToAddRows = false;
            this.versionGrid.AllowUserToDeleteRows = false;
            this.versionGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.versionGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.versionGrid.Location = new System.Drawing.Point(282, 75);
            this.versionGrid.MultiSelect = false;
            this.versionGrid.Name = "versionGrid";
            this.versionGrid.ReadOnly = true;
            this.versionGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.versionGrid.Size = new System.Drawing.Size(418, 159);
            this.versionGrid.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(421, 248);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Contacts (Optional)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 248);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "PLC Address (Optional)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 294);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Logon Details (Optional)";
            // 
            // logonTB
            // 
            this.logonTB.Location = new System.Drawing.Point(32, 310);
            this.logonTB.Multiline = true;
            this.logonTB.Name = "logonTB";
            this.logonTB.Size = new System.Drawing.Size(360, 158);
            this.logonTB.TabIndex = 24;
            // 
            // contactsTB
            // 
            this.contactsTB.Location = new System.Drawing.Point(424, 264);
            this.contactsTB.Multiline = true;
            this.contactsTB.Name = "contactsTB";
            this.contactsTB.Size = new System.Drawing.Size(276, 130);
            this.contactsTB.TabIndex = 25;
            // 
            // plcTB
            // 
            this.plcTB.Location = new System.Drawing.Point(32, 264);
            this.plcTB.Name = "plcTB";
            this.plcTB.Size = new System.Drawing.Size(360, 20);
            this.plcTB.TabIndex = 26;
            // 
            // NewCustomerPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 480);
            this.Controls.Add(this.plcTB);
            this.Controls.Add(this.contactsTB);
            this.Controls.Add(this.logonTB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.versionGrid);
            this.Controls.Add(this.idLbl);
            this.Controls.Add(this.nameTxtBx);
            this.Controls.Add(this.detailsLbl);
            this.Controls.Add(this.descriptionTxtBx);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.subLbl);
            this.Controls.Add(this.newCustLbl);
            this.Controls.Add(this.mainMenuBtn1);
            this.Name = "NewCustomerPage";
            this.Text = "Aspect PT Version Database - Add Customer";
            this.Load += new System.EventHandler(this.NewCustomerPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.versionDatabase1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.versionDatabase1DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.versionDatabase1DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.versionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.versionGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button mainMenuBtn1;
        private System.Windows.Forms.Label subLbl;
        private System.Windows.Forms.Label newCustLbl;
        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.Label idLbl;
        private System.Windows.Forms.TextBox nameTxtBx;
        private System.Windows.Forms.Label detailsLbl;
        private System.Windows.Forms.TextBox descriptionTxtBx;
        private System.Windows.Forms.BindingSource versionDatabase1DataSetBindingSource;
        private VersionDatabase1DataSet versionDatabase1DataSet;
        private VersionDatabase1DataSet1 versionDatabase1DataSet1;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private VersionDatabase1DataSet1TableAdapters.CustomerTableAdapter customerTableAdapter;
        private System.Windows.Forms.BindingSource versionBindingSource;
        private VersionDatabase1DataSet1TableAdapters.VersionTableAdapter versionTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView versionGrid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox logonTB;
        private System.Windows.Forms.TextBox contactsTB;
        private System.Windows.Forms.TextBox plcTB;
    }
}