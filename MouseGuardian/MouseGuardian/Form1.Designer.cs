namespace MouseGuardian
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.StatusStrip1 = new System.Windows.Forms.StatusStrip();
            this.xMousePosition = new System.Windows.Forms.ToolStripStatusLabel();
            this.yMousePosition = new System.Windows.Forms.ToolStripStatusLabel();
            this.shortcutLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.MenuBar = new System.Windows.Forms.MenuStrip();
            this.showLabel = new System.Windows.Forms.ToolStripMenuItem();
            this.horLine = new System.Windows.Forms.ToolStripMenuItem();
            this.verLine = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.coorLabel = new System.Windows.Forms.ToolStripMenuItem();
            this.prefLabel = new System.Windows.Forms.ToolStripMenuItem();
            this.linecLabel = new System.Windows.Forms.ToolStripMenuItem();
            this.langLabel = new System.Windows.Forms.ToolStripMenuItem();
            this.engLang = new System.Windows.Forms.ToolStripMenuItem();
            this.italianItalianoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.disableMirrorLabel = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.helpLabel = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.gitHubProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updLabel = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutLabel = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.playMirror = new System.Windows.Forms.ToolStripButton();
            this.pauseMirror = new System.Windows.Forms.ToolStripButton();
            this.stopMirror = new System.Windows.Forms.ToolStripButton();
            this.StatusStrip1.SuspendLayout();
            this.MenuBar.SuspendLayout();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // StatusStrip1
            // 
            this.StatusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xMousePosition,
            this.yMousePosition,
            this.shortcutLabel});
            this.StatusStrip1.Location = new System.Drawing.Point(0, 258);
            this.StatusStrip1.Name = "StatusStrip1";
            this.StatusStrip1.Size = new System.Drawing.Size(574, 22);
            this.StatusStrip1.SizingGrip = false;
            this.StatusStrip1.TabIndex = 1;
            this.StatusStrip1.Text = "statusStrip1";
            // 
            // xMousePosition
            // 
            this.xMousePosition.Name = "xMousePosition";
            this.xMousePosition.Size = new System.Drawing.Size(17, 17);
            this.xMousePosition.Text = "X:";
            // 
            // yMousePosition
            // 
            this.yMousePosition.Name = "yMousePosition";
            this.yMousePosition.Size = new System.Drawing.Size(17, 17);
            this.yMousePosition.Text = "Y:";
            // 
            // shortcutLabel
            // 
            this.shortcutLabel.ForeColor = System.Drawing.Color.Red;
            this.shortcutLabel.Name = "shortcutLabel";
            this.shortcutLabel.Size = new System.Drawing.Size(321, 17);
            this.shortcutLabel.Text = "Press CTRL to position the cursor at the center of the screen";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MenuBar
            // 
            this.MenuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showLabel,
            this.prefLabel,
            this.aboutMenu});
            this.MenuBar.Location = new System.Drawing.Point(0, 0);
            this.MenuBar.Name = "MenuBar";
            this.MenuBar.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.MenuBar.Size = new System.Drawing.Size(574, 24);
            this.MenuBar.TabIndex = 3;
            this.MenuBar.Text = "menuStrip1";
            // 
            // showLabel
            // 
            this.showLabel.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.horLine,
            this.verLine,
            this.toolStripSeparator2,
            this.coorLabel});
            this.showLabel.Name = "showLabel";
            this.showLabel.Size = new System.Drawing.Size(48, 20);
            this.showLabel.Text = "Show";
            // 
            // horLine
            // 
            this.horLine.CheckOnClick = true;
            this.horLine.Name = "horLine";
            this.horLine.Size = new System.Drawing.Size(151, 22);
            this.horLine.Text = "Horizontal line";
            this.horLine.Click += new System.EventHandler(this.horLine_Click);
            this.horLine.Paint += new System.Windows.Forms.PaintEventHandler(this.horLine_Paint);
            // 
            // verLine
            // 
            this.verLine.CheckOnClick = true;
            this.verLine.Name = "verLine";
            this.verLine.Size = new System.Drawing.Size(151, 22);
            this.verLine.Text = "Vertical line";
            this.verLine.Click += new System.EventHandler(this.verLine_Click);
            this.verLine.Paint += new System.Windows.Forms.PaintEventHandler(this.verLine_Paint);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(148, 6);
            // 
            // coorLabel
            // 
            this.coorLabel.CheckOnClick = true;
            this.coorLabel.Name = "coorLabel";
            this.coorLabel.Size = new System.Drawing.Size(151, 22);
            this.coorLabel.Text = "Coordinates";
            this.coorLabel.Click += new System.EventHandler(this.coorLabel_Click);
            this.coorLabel.Paint += new System.Windows.Forms.PaintEventHandler(this.coorLabel_Paint);
            // 
            // prefLabel
            // 
            this.prefLabel.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.linecLabel,
            this.langLabel,
            this.toolStripSeparator4,
            this.disableMirrorLabel});
            this.prefLabel.Name = "prefLabel";
            this.prefLabel.Size = new System.Drawing.Size(80, 20);
            this.prefLabel.Text = "Preferences";
            // 
            // linecLabel
            // 
            this.linecLabel.Name = "linecLabel";
            this.linecLabel.Size = new System.Drawing.Size(165, 22);
            this.linecLabel.Text = "Line color";
            this.linecLabel.Click += new System.EventHandler(this.lineColorToolStripMenuItem_Click);
            // 
            // langLabel
            // 
            this.langLabel.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.engLang,
            this.italianItalianoToolStripMenuItem});
            this.langLabel.Name = "langLabel";
            this.langLabel.Size = new System.Drawing.Size(165, 22);
            this.langLabel.Text = "Language";
            // 
            // engLang
            // 
            this.engLang.Name = "engLang";
            this.engLang.Size = new System.Drawing.Size(156, 22);
            this.engLang.Text = "English";
            this.engLang.Click += new System.EventHandler(this.englishToolStripMenuItem_Click);
            // 
            // italianItalianoToolStripMenuItem
            // 
            this.italianItalianoToolStripMenuItem.Name = "italianItalianoToolStripMenuItem";
            this.italianItalianoToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.italianItalianoToolStripMenuItem.Text = "Italian - Italiano";
            this.italianItalianoToolStripMenuItem.Click += new System.EventHandler(this.italianItalianoToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(162, 6);
            // 
            // disableMirrorLabel
            // 
            this.disableMirrorLabel.CheckOnClick = true;
            this.disableMirrorLabel.Name = "disableMirrorLabel";
            this.disableMirrorLabel.Size = new System.Drawing.Size(165, 22);
            this.disableMirrorLabel.Text = "Disable Mirroring";
            this.disableMirrorLabel.Click += new System.EventHandler(this.disableMirrorLabel_Click);
            // 
            // aboutMenu
            // 
            this.aboutMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpLabel,
            this.toolStripSeparator1,
            this.gitHubProjectToolStripMenuItem,
            this.updLabel,
            this.toolStripSeparator3,
            this.aboutLabel});
            this.aboutMenu.Name = "aboutMenu";
            this.aboutMenu.Size = new System.Drawing.Size(24, 20);
            this.aboutMenu.Text = "?";
            this.aboutMenu.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // helpLabel
            // 
            this.helpLabel.Name = "helpLabel";
            this.helpLabel.Size = new System.Drawing.Size(175, 22);
            this.helpLabel.Text = "Help";
            this.helpLabel.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(172, 6);
            // 
            // gitHubProjectToolStripMenuItem
            // 
            this.gitHubProjectToolStripMenuItem.Name = "gitHubProjectToolStripMenuItem";
            this.gitHubProjectToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.gitHubProjectToolStripMenuItem.Text = "The GitHub Project";
            this.gitHubProjectToolStripMenuItem.Click += new System.EventHandler(this.gitHubProjectToolStripMenuItem_Click);
            // 
            // updLabel
            // 
            this.updLabel.Name = "updLabel";
            this.updLabel.Size = new System.Drawing.Size(175, 22);
            this.updLabel.Text = "Check Updates";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(172, 6);
            // 
            // aboutLabel
            // 
            this.aboutLabel.Name = "aboutLabel";
            this.aboutLabel.Size = new System.Drawing.Size(175, 22);
            this.aboutLabel.Text = "About";
            this.aboutLabel.Click += new System.EventHandler(this.aboutLabel_Click);
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.pictureBox1);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(574, 209);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 24);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(574, 234);
            this.toolStripContainer1.TabIndex = 4;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.toolStrip1);
            // 
            // toolStrip1
            // 
            this.toolStrip1.DataBindings.Add(new System.Windows.Forms.Binding("Location", global::MouseGuardian.Properties.Settings.Default, "tool1Loc", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.playMirror,
            this.pauseMirror,
            this.stopMirror});
            this.toolStrip1.Location = global::MouseGuardian.Properties.Settings.Default.tool1Loc;
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(81, 25);
            this.toolStrip1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(574, 209);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // playMirror
            // 
            this.playMirror.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.playMirror.Enabled = false;
            this.playMirror.Image = global::MouseGuardian.Properties.Resources.start;
            this.playMirror.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.playMirror.Name = "playMirror";
            this.playMirror.Size = new System.Drawing.Size(23, 22);
            this.playMirror.Text = "Play mirroring";
            this.playMirror.Click += new System.EventHandler(this.playMirror_Click);
            // 
            // pauseMirror
            // 
            this.pauseMirror.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pauseMirror.Image = global::MouseGuardian.Properties.Resources.pause;
            this.pauseMirror.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pauseMirror.Name = "pauseMirror";
            this.pauseMirror.Size = new System.Drawing.Size(23, 22);
            this.pauseMirror.Text = "Pause Mirroring";
            this.pauseMirror.Click += new System.EventHandler(this.pauseMirror_Click);
            // 
            // stopMirror
            // 
            this.stopMirror.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.stopMirror.Image = global::MouseGuardian.Properties.Resources.stop;
            this.stopMirror.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.stopMirror.Name = "stopMirror";
            this.stopMirror.Size = new System.Drawing.Size(23, 22);
            this.stopMirror.Text = "Stop mirroring";
            this.stopMirror.Click += new System.EventHandler(this.stopMirror_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 280);
            this.Controls.Add(this.toolStripContainer1);
            this.Controls.Add(this.StatusStrip1);
            this.Controls.Add(this.MenuBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MenuBar;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MouseGuardian";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.StatusStrip1.ResumeLayout(false);
            this.StatusStrip1.PerformLayout();
            this.MenuBar.ResumeLayout(false);
            this.MenuBar.PerformLayout();
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip StatusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel xMousePosition;
        private System.Windows.Forms.ToolStripStatusLabel yMousePosition;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripStatusLabel shortcutLabel;
        private System.Windows.Forms.MenuStrip MenuBar;
        private System.Windows.Forms.ToolStripMenuItem aboutMenu;
        private System.Windows.Forms.ToolStripMenuItem showLabel;
        private System.Windows.Forms.ToolStripMenuItem horLine;
        private System.Windows.Forms.ToolStripMenuItem verLine;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem coorLabel;
        private System.Windows.Forms.ToolStripMenuItem prefLabel;
        private System.Windows.Forms.ToolStripMenuItem linecLabel;
        private System.Windows.Forms.ToolStripMenuItem langLabel;
        private System.Windows.Forms.ToolStripMenuItem engLang;
        private System.Windows.Forms.ToolStripMenuItem italianItalianoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpLabel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem gitHubProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updLabel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem aboutLabel;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton playMirror;
        private System.Windows.Forms.ToolStripButton stopMirror;
        private System.Windows.Forms.ToolStripButton pauseMirror;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem disableMirrorLabel;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

