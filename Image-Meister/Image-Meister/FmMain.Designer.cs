namespace Image_Meister
{
    partial class FmMain
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
            this.MsMain = new System.Windows.Forms.MenuStrip();
            this.showSidebarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showAllFilesInFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openInExplorerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TSCMBZoom = new System.Windows.Forms.ToolStripComboBox();
            this.preferencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SCMain = new System.Windows.Forms.SplitContainer();
            this.FLPSide = new System.Windows.Forms.FlowLayoutPanel();
            this.TLPMain = new System.Windows.Forms.TableLayoutPanel();
            this.FLPMain = new System.Windows.Forms.FlowLayoutPanel();
            this.MsMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SCMain)).BeginInit();
            this.SCMain.Panel1.SuspendLayout();
            this.SCMain.Panel2.SuspendLayout();
            this.SCMain.SuspendLayout();
            this.TLPMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // MsMain
            // 
            this.MsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showSidebarToolStripMenuItem,
            this.showAllFilesInFolderToolStripMenuItem,
            this.openInExplorerToolStripMenuItem,
            this.TSCMBZoom,
            this.preferencesToolStripMenuItem});
            this.MsMain.Location = new System.Drawing.Point(0, 0);
            this.MsMain.Name = "MsMain";
            this.MsMain.Size = new System.Drawing.Size(950, 27);
            this.MsMain.TabIndex = 0;
            this.MsMain.Text = "menuStrip1";
            // 
            // showSidebarToolStripMenuItem
            // 
            this.showSidebarToolStripMenuItem.Name = "showSidebarToolStripMenuItem";
            this.showSidebarToolStripMenuItem.Size = new System.Drawing.Size(90, 23);
            this.showSidebarToolStripMenuItem.Text = "Show Sidebar";
            this.showSidebarToolStripMenuItem.Click += new System.EventHandler(this.showSidebarToolStripMenuItem_Click);
            // 
            // showAllFilesInFolderToolStripMenuItem
            // 
            this.showAllFilesInFolderToolStripMenuItem.Name = "showAllFilesInFolderToolStripMenuItem";
            this.showAllFilesInFolderToolStripMenuItem.Size = new System.Drawing.Size(140, 23);
            this.showAllFilesInFolderToolStripMenuItem.Text = "Show All Files in Folder";
            this.showAllFilesInFolderToolStripMenuItem.Click += new System.EventHandler(this.showAllFilesInFolderToolStripMenuItem_Click);
            // 
            // openInExplorerToolStripMenuItem
            // 
            this.openInExplorerToolStripMenuItem.Name = "openInExplorerToolStripMenuItem";
            this.openInExplorerToolStripMenuItem.Size = new System.Drawing.Size(106, 23);
            this.openInExplorerToolStripMenuItem.Text = "Open in Explorer";
            // 
            // TSCMBZoom
            // 
            this.TSCMBZoom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TSCMBZoom.Items.AddRange(new object[] {
            "100",
            "90",
            "80",
            "70",
            "60",
            "50",
            "40",
            "30",
            "20",
            "10"});
            this.TSCMBZoom.Name = "TSCMBZoom";
            this.TSCMBZoom.Size = new System.Drawing.Size(121, 23);
            this.TSCMBZoom.ToolTipText = "Set Zoom Level";
            this.TSCMBZoom.SelectedIndexChanged += new System.EventHandler(this.TSCMBZoom_SelectedIndexChanged);
            // 
            // preferencesToolStripMenuItem
            // 
            this.preferencesToolStripMenuItem.Name = "preferencesToolStripMenuItem";
            this.preferencesToolStripMenuItem.Size = new System.Drawing.Size(80, 23);
            this.preferencesToolStripMenuItem.Text = "Preferences";
            // 
            // SCMain
            // 
            this.SCMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SCMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SCMain.Location = new System.Drawing.Point(0, 27);
            this.SCMain.Name = "SCMain";
            // 
            // SCMain.Panel1
            // 
            this.SCMain.Panel1.Controls.Add(this.FLPSide);
            this.SCMain.Panel1MinSize = 30;
            // 
            // SCMain.Panel2
            // 
            this.SCMain.Panel2.AutoScroll = true;
            this.SCMain.Panel2.Controls.Add(this.TLPMain);
            this.SCMain.Panel2.Resize += new System.EventHandler(this.SCMain_Panel2_Resize);
            this.SCMain.Size = new System.Drawing.Size(950, 528);
            this.SCMain.SplitterDistance = 203;
            this.SCMain.SplitterWidth = 5;
            this.SCMain.TabIndex = 1;
            this.SCMain.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.SCMain_SplitterMoved);
            // 
            // FLPSide
            // 
            this.FLPSide.AutoScroll = true;
            this.FLPSide.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FLPSide.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.FLPSide.Location = new System.Drawing.Point(0, 0);
            this.FLPSide.Margin = new System.Windows.Forms.Padding(0);
            this.FLPSide.Name = "FLPSide";
            this.FLPSide.Size = new System.Drawing.Size(201, 526);
            this.FLPSide.TabIndex = 0;
            this.FLPSide.WrapContents = false;
            // 
            // TLPMain
            // 
            this.TLPMain.ColumnCount = 3;
            this.TLPMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TLPMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 400F));
            this.TLPMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TLPMain.Controls.Add(this.FLPMain, 1, 0);
            this.TLPMain.Location = new System.Drawing.Point(0, 0);
            this.TLPMain.Margin = new System.Windows.Forms.Padding(0);
            this.TLPMain.Name = "TLPMain";
            this.TLPMain.RowCount = 1;
            this.TLPMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TLPMain.Size = new System.Drawing.Size(634, 300);
            this.TLPMain.TabIndex = 0;
            // 
            // FLPMain
            // 
            this.FLPMain.BackColor = System.Drawing.SystemColors.ControlDark;
            this.FLPMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FLPMain.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.FLPMain.Location = new System.Drawing.Point(117, 0);
            this.FLPMain.Margin = new System.Windows.Forms.Padding(0);
            this.FLPMain.Name = "FLPMain";
            this.FLPMain.Size = new System.Drawing.Size(400, 300);
            this.FLPMain.TabIndex = 0;
            this.FLPMain.WrapContents = false;
            // 
            // FmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 555);
            this.Controls.Add(this.SCMain);
            this.Controls.Add(this.MsMain);
            this.MainMenuStrip = this.MsMain;
            this.Name = "FmMain";
            this.Text = "Form1";
            this.MsMain.ResumeLayout(false);
            this.MsMain.PerformLayout();
            this.SCMain.Panel1.ResumeLayout(false);
            this.SCMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SCMain)).EndInit();
            this.SCMain.ResumeLayout(false);
            this.TLPMain.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MsMain;
        private System.Windows.Forms.ToolStripMenuItem showSidebarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showAllFilesInFolderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openInExplorerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem preferencesToolStripMenuItem;
        private System.Windows.Forms.SplitContainer SCMain;
        private System.Windows.Forms.ToolStripComboBox TSCMBZoom;
        private System.Windows.Forms.TableLayoutPanel TLPMain;
        private System.Windows.Forms.FlowLayoutPanel FLPSide;
        private System.Windows.Forms.FlowLayoutPanel FLPMain;
    }
}

