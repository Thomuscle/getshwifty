namespace AspectUpdatesDummy
{
    partial class NewVersionPage
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
            this.mainMenuBtn2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mainMenuBtn2
            // 
            this.mainMenuBtn2.Location = new System.Drawing.Point(433, 267);
            this.mainMenuBtn2.Name = "mainMenuBtn2";
            this.mainMenuBtn2.Size = new System.Drawing.Size(127, 42);
            this.mainMenuBtn2.TabIndex = 0;
            this.mainMenuBtn2.Text = "Main Menu";
            this.mainMenuBtn2.UseVisualStyleBackColor = true;
            this.mainMenuBtn2.Click += new System.EventHandler(this.mainMenuBtn2_Click);
            // 
            // NewVersionPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 314);
            this.Controls.Add(this.mainMenuBtn2);
            this.Name = "NewVersionPage";
            this.Text = "Aspect PT Version Database - Add Version";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button mainMenuBtn2;
    }
}