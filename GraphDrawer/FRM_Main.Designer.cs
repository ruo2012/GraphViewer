namespace GraphDrawer
{
    partial class FRM_Main
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
            this.PAN_Canvas = new System.Windows.Forms.Panel();
            this.MS_Menu = new System.Windows.Forms.MenuStrip();
            this.TSM_File = new System.Windows.Forms.ToolStripMenuItem();
            this.TSM_FileLoad = new System.Windows.Forms.ToolStripMenuItem();
            this.TSM_FileClose = new System.Windows.Forms.ToolStripMenuItem();
            this.TSM_FileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.TSM_Codecs = new System.Windows.Forms.ToolStripMenuItem();
            this.TSM_CodecsInstall = new System.Windows.Forms.ToolStripMenuItem();
            this.TSM_CodecsSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.MS_Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // PAN_Canvas
            // 
            this.PAN_Canvas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PAN_Canvas.BackColor = System.Drawing.Color.White;
            this.PAN_Canvas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PAN_Canvas.Cursor = System.Windows.Forms.Cursors.Cross;
            this.PAN_Canvas.Location = new System.Drawing.Point(13, 27);
            this.PAN_Canvas.Name = "PAN_Canvas";
            this.PAN_Canvas.Size = new System.Drawing.Size(414, 383);
            this.PAN_Canvas.TabIndex = 0;
            // 
            // MS_Menu
            // 
            this.MS_Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSM_File,
            this.TSM_Codecs});
            this.MS_Menu.Location = new System.Drawing.Point(0, 0);
            this.MS_Menu.Name = "MS_Menu";
            this.MS_Menu.Size = new System.Drawing.Size(439, 24);
            this.MS_Menu.TabIndex = 1;
            this.MS_Menu.Text = "MS_Menu";
            // 
            // TSM_File
            // 
            this.TSM_File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSM_FileLoad,
            this.TSM_FileClose,
            this.TSM_FileExit});
            this.TSM_File.Name = "TSM_File";
            this.TSM_File.Size = new System.Drawing.Size(37, 20);
            this.TSM_File.Text = "File";
            // 
            // TSM_FileLoad
            // 
            this.TSM_FileLoad.Name = "TSM_FileLoad";
            this.TSM_FileLoad.Size = new System.Drawing.Size(103, 22);
            this.TSM_FileLoad.Text = "Load";
            this.TSM_FileLoad.Click += new System.EventHandler(this.TSM_FileLoad_Click);
            // 
            // TSM_FileClose
            // 
            this.TSM_FileClose.Name = "TSM_FileClose";
            this.TSM_FileClose.Size = new System.Drawing.Size(103, 22);
            this.TSM_FileClose.Text = "Close";
            this.TSM_FileClose.Click += new System.EventHandler(this.TSM_FileClose_Click);
            // 
            // TSM_FileExit
            // 
            this.TSM_FileExit.Name = "TSM_FileExit";
            this.TSM_FileExit.Size = new System.Drawing.Size(103, 22);
            this.TSM_FileExit.Text = "Exit";
            this.TSM_FileExit.Click += new System.EventHandler(this.TSM_FileExit_Click);
            // 
            // TSM_Codecs
            // 
            this.TSM_Codecs.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSM_CodecsInstall,
            this.TSM_CodecsSeparator});
            this.TSM_Codecs.Name = "TSM_Codecs";
            this.TSM_Codecs.Size = new System.Drawing.Size(58, 20);
            this.TSM_Codecs.Text = "Codecs";
            // 
            // TSM_CodecsInstall
            // 
            this.TSM_CodecsInstall.Name = "TSM_CodecsInstall";
            this.TSM_CodecsInstall.Size = new System.Drawing.Size(152, 22);
            this.TSM_CodecsInstall.Text = "Install";
            this.TSM_CodecsInstall.Click += new System.EventHandler(this.TSM_CodecsInstall_Click);
            // 
            // TSM_CodecsSeparator
            // 
            this.TSM_CodecsSeparator.Name = "TSM_CodecsSeparator";
            this.TSM_CodecsSeparator.Size = new System.Drawing.Size(149, 6);
            // 
            // FRM_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 422);
            this.Controls.Add(this.PAN_Canvas);
            this.Controls.Add(this.MS_Menu);
            this.MainMenuStrip = this.MS_Menu;
            this.Name = "FRM_Main";
            this.Text = "GraphDrawer";
            this.Load += new System.EventHandler(this.FRM_Main_Load);
            this.MS_Menu.ResumeLayout(false);
            this.MS_Menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PAN_Canvas;
        private System.Windows.Forms.MenuStrip MS_Menu;
        private System.Windows.Forms.ToolStripMenuItem TSM_File;
        private System.Windows.Forms.ToolStripMenuItem TSM_FileLoad;
        private System.Windows.Forms.ToolStripMenuItem TSM_FileClose;
        private System.Windows.Forms.ToolStripMenuItem TSM_FileExit;
        private System.Windows.Forms.ToolStripMenuItem TSM_Codecs;
        private System.Windows.Forms.ToolStripMenuItem TSM_CodecsInstall;
        private System.Windows.Forms.ToolStripSeparator TSM_CodecsSeparator;
    }
}