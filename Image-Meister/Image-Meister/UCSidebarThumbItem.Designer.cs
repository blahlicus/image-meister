namespace Image_Meister
{
    partial class UCSidebarThumbItem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PBMain = new System.Windows.Forms.PictureBox();
            this.LFileName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PBMain)).BeginInit();
            this.SuspendLayout();
            // 
            // PBMain
            // 
            this.PBMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PBMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PBMain.Location = new System.Drawing.Point(3, 3);
            this.PBMain.Name = "PBMain";
            this.PBMain.Size = new System.Drawing.Size(94, 94);
            this.PBMain.TabIndex = 0;
            this.PBMain.TabStop = false;
            this.PBMain.Click += new System.EventHandler(this.PBMain_Click);
            // 
            // LFileName
            // 
            this.LFileName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LFileName.AutoSize = true;
            this.LFileName.Location = new System.Drawing.Point(104, 4);
            this.LFileName.Name = "LFileName";
            this.LFileName.Size = new System.Drawing.Size(35, 13);
            this.LFileName.TabIndex = 1;
            this.LFileName.Text = "label1";
            this.LFileName.Click += new System.EventHandler(this.LFileName_Click);
            // 
            // UCSidebarThumbItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.LFileName);
            this.Controls.Add(this.PBMain);
            this.Name = "UCSidebarThumbItem";
            this.Size = new System.Drawing.Size(300, 100);
            this.Load += new System.EventHandler(this.UCSidebarThumbItem_Load);
            this.Click += new System.EventHandler(this.UCSidebarThumbItem_Click);
            ((System.ComponentModel.ISupportInitialize)(this.PBMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PBMain;
        private System.Windows.Forms.Label LFileName;
    }
}
