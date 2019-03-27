namespace ATDesktopWin.Views
{
    partial class HomeView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeView));
            this.menuMain = new System.Windows.Forms.MenuStrip();
            this.appToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.screenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dashboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.familyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.treeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.discoverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.messagesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.albumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.websiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.feedbackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scMain = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblHeaderName = new System.Windows.Forms.Label();
            this.pbHeaderPicture = new System.Windows.Forms.PictureBox();
            this.lblHeaderTitle = new System.Windows.Forms.Label();
            this.tcPages = new System.Windows.Forms.TabControl();
            this.tpDashboard = new System.Windows.Forms.TabPage();
            this.tpFamilyTree = new System.Windows.Forms.TabPage();
            this.familyTreePanel = new System.Windows.Forms.Panel();
            this.tpFamilyTable = new System.Windows.Forms.TabPage();
            this.familyTreeNode1 = new ATDesktopWin.Views.Controls.FamilyTreeNode();
            this.menuMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scMain)).BeginInit();
            this.scMain.Panel1.SuspendLayout();
            this.scMain.Panel2.SuspendLayout();
            this.scMain.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbHeaderPicture)).BeginInit();
            this.tcPages.SuspendLayout();
            this.tpFamilyTree.SuspendLayout();
            this.familyTreePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuMain
            // 
            this.menuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.appToolStripMenuItem,
            this.screenToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuMain.Location = new System.Drawing.Point(0, 0);
            this.menuMain.Name = "menuMain";
            this.menuMain.Size = new System.Drawing.Size(1008, 24);
            this.menuMain.TabIndex = 0;
            this.menuMain.Text = "menuStrip1";
            // 
            // appToolStripMenuItem
            // 
            this.appToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.appToolStripMenuItem.Name = "appToolStripMenuItem";
            this.appToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.appToolStripMenuItem.Text = "&App";
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.refreshToolStripMenuItem.Text = "&Refresh";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(110, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // screenToolStripMenuItem
            // 
            this.screenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dashboardToolStripMenuItem,
            this.familyToolStripMenuItem,
            this.discoverToolStripMenuItem,
            this.messagesToolStripMenuItem,
            this.albumToolStripMenuItem});
            this.screenToolStripMenuItem.Name = "screenToolStripMenuItem";
            this.screenToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.screenToolStripMenuItem.Text = "&Screen";
            // 
            // dashboardToolStripMenuItem
            // 
            this.dashboardToolStripMenuItem.Name = "dashboardToolStripMenuItem";
            this.dashboardToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.dashboardToolStripMenuItem.Text = "&Dashboard";
            this.dashboardToolStripMenuItem.Click += new System.EventHandler(this.dashboardToolStripMenuItem_Click);
            // 
            // familyToolStripMenuItem
            // 
            this.familyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tableToolStripMenuItem,
            this.treeToolStripMenuItem});
            this.familyToolStripMenuItem.Name = "familyToolStripMenuItem";
            this.familyToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.familyToolStripMenuItem.Text = "&Family";
            // 
            // tableToolStripMenuItem
            // 
            this.tableToolStripMenuItem.Name = "tableToolStripMenuItem";
            this.tableToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.tableToolStripMenuItem.Text = "Table";
            this.tableToolStripMenuItem.Click += new System.EventHandler(this.tableToolStripMenuItem_Click);
            // 
            // treeToolStripMenuItem
            // 
            this.treeToolStripMenuItem.Name = "treeToolStripMenuItem";
            this.treeToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.treeToolStripMenuItem.Text = "Tree";
            this.treeToolStripMenuItem.Click += new System.EventHandler(this.treeToolStripMenuItem_Click);
            // 
            // discoverToolStripMenuItem
            // 
            this.discoverToolStripMenuItem.Name = "discoverToolStripMenuItem";
            this.discoverToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.discoverToolStripMenuItem.Text = "D&iscover";
            // 
            // messagesToolStripMenuItem
            // 
            this.messagesToolStripMenuItem.Name = "messagesToolStripMenuItem";
            this.messagesToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.messagesToolStripMenuItem.Text = "&Messages";
            // 
            // albumToolStripMenuItem
            // 
            this.albumToolStripMenuItem.Name = "albumToolStripMenuItem";
            this.albumToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.albumToolStripMenuItem.Text = "&Album";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "S&ettings";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.optionsToolStripMenuItem.Text = "&Options";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.websiteToolStripMenuItem,
            this.feedbackToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // websiteToolStripMenuItem
            // 
            this.websiteToolStripMenuItem.Name = "websiteToolStripMenuItem";
            this.websiteToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.websiteToolStripMenuItem.Text = "Website";
            // 
            // feedbackToolStripMenuItem
            // 
            this.feedbackToolStripMenuItem.Name = "feedbackToolStripMenuItem";
            this.feedbackToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.feedbackToolStripMenuItem.Text = "Feedback";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // scMain
            // 
            this.scMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scMain.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.scMain.IsSplitterFixed = true;
            this.scMain.Location = new System.Drawing.Point(0, 24);
            this.scMain.Name = "scMain";
            this.scMain.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // scMain.Panel1
            // 
            this.scMain.Panel1.BackColor = System.Drawing.SystemColors.Info;
            this.scMain.Panel1.Controls.Add(this.panel1);
            this.scMain.Panel1.Controls.Add(this.lblHeaderTitle);
            // 
            // scMain.Panel2
            // 
            this.scMain.Panel2.Controls.Add(this.tcPages);
            this.scMain.Size = new System.Drawing.Size(1008, 705);
            this.scMain.SplitterDistance = 60;
            this.scMain.SplitterWidth = 1;
            this.scMain.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblHeaderName);
            this.panel1.Controls.Add(this.pbHeaderPicture);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(808, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 60);
            this.panel1.TabIndex = 7;
            // 
            // lblHeaderName
            // 
            this.lblHeaderName.AutoSize = true;
            this.lblHeaderName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeaderName.Location = new System.Drawing.Point(62, 18);
            this.lblHeaderName.Name = "lblHeaderName";
            this.lblHeaderName.Size = new System.Drawing.Size(119, 25);
            this.lblHeaderName.TabIndex = 5;
            this.lblHeaderName.Text = "User Name";
            // 
            // pbHeaderPicture
            // 
            this.pbHeaderPicture.BackgroundImage = global::ATDesktopWin.Properties.Resources.default_user_male;
            this.pbHeaderPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbHeaderPicture.ErrorImage = null;
            this.pbHeaderPicture.InitialImage = null;
            this.pbHeaderPicture.Location = new System.Drawing.Point(20, 12);
            this.pbHeaderPicture.Name = "pbHeaderPicture";
            this.pbHeaderPicture.Size = new System.Drawing.Size(36, 36);
            this.pbHeaderPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbHeaderPicture.TabIndex = 4;
            this.pbHeaderPicture.TabStop = false;
            // 
            // lblHeaderTitle
            // 
            this.lblHeaderTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHeaderTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeaderTitle.Location = new System.Drawing.Point(0, 0);
            this.lblHeaderTitle.Name = "lblHeaderTitle";
            this.lblHeaderTitle.Size = new System.Drawing.Size(1008, 60);
            this.lblHeaderTitle.TabIndex = 5;
            this.lblHeaderTitle.Text = "Screen Name";
            this.lblHeaderTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tcPages
            // 
            this.tcPages.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tcPages.Controls.Add(this.tpDashboard);
            this.tcPages.Controls.Add(this.tpFamilyTree);
            this.tcPages.Controls.Add(this.tpFamilyTable);
            this.tcPages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcPages.ItemSize = new System.Drawing.Size(50, 25);
            this.tcPages.Location = new System.Drawing.Point(0, 0);
            this.tcPages.Multiline = true;
            this.tcPages.Name = "tcPages";
            this.tcPages.SelectedIndex = 0;
            this.tcPages.Size = new System.Drawing.Size(1008, 644);
            this.tcPages.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tcPages.TabIndex = 2;
            // 
            // tpDashboard
            // 
            this.tpDashboard.Location = new System.Drawing.Point(4, 29);
            this.tpDashboard.Name = "tpDashboard";
            this.tpDashboard.Size = new System.Drawing.Size(1000, 611);
            this.tpDashboard.TabIndex = 3;
            this.tpDashboard.Text = "Dashboard";
            this.tpDashboard.UseVisualStyleBackColor = true;
            // 
            // tpFamilyTree
            // 
            this.tpFamilyTree.Controls.Add(this.familyTreePanel);
            this.tpFamilyTree.Location = new System.Drawing.Point(4, 29);
            this.tpFamilyTree.Name = "tpFamilyTree";
            this.tpFamilyTree.Padding = new System.Windows.Forms.Padding(3);
            this.tpFamilyTree.Size = new System.Drawing.Size(1000, 611);
            this.tpFamilyTree.TabIndex = 1;
            this.tpFamilyTree.Text = "FamilyTree";
            this.tpFamilyTree.UseVisualStyleBackColor = true;
            // 
            // familyTreePanel
            // 
            this.familyTreePanel.AutoScroll = true;
            this.familyTreePanel.AutoSize = true;
            this.familyTreePanel.Controls.Add(this.familyTreeNode1);
            this.familyTreePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.familyTreePanel.Location = new System.Drawing.Point(3, 3);
            this.familyTreePanel.Name = "familyTreePanel";
            this.familyTreePanel.Size = new System.Drawing.Size(994, 605);
            this.familyTreePanel.TabIndex = 0;
            // 
            // tpFamilyTable
            // 
            this.tpFamilyTable.Location = new System.Drawing.Point(4, 29);
            this.tpFamilyTable.Name = "tpFamilyTable";
            this.tpFamilyTable.Size = new System.Drawing.Size(1000, 611);
            this.tpFamilyTable.TabIndex = 2;
            this.tpFamilyTable.Text = "FamilyTable";
            this.tpFamilyTable.UseVisualStyleBackColor = true;
            // 
            // familyTreeNode1
            // 
            this.familyTreeNode1.BackColor = System.Drawing.Color.Transparent;
            this.familyTreeNode1.Location = new System.Drawing.Point(279, 108);
            this.familyTreeNode1.Name = "familyTreeNode1";
            this.familyTreeNode1.Node = null;
            this.familyTreeNode1.ParentVisible = ATDesktopWin.Views.Controls.FamilyTreeNode.HusbandOrWife.Wife;
            this.familyTreeNode1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.familyTreeNode1.Size = new System.Drawing.Size(180, 120);
            this.familyTreeNode1.TabIndex = 0;
            // 
            // HomeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.scMain);
            this.Controls.Add(this.menuMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuMain;
            this.MinimumSize = new System.Drawing.Size(1024, 768);
            this.Name = "HomeView";
            this.Text = "Astir Trotter (Home)";
            this.Shown += new System.EventHandler(this.HomeView_Shown);
            this.menuMain.ResumeLayout(false);
            this.menuMain.PerformLayout();
            this.scMain.Panel1.ResumeLayout(false);
            this.scMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scMain)).EndInit();
            this.scMain.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbHeaderPicture)).EndInit();
            this.tcPages.ResumeLayout(false);
            this.tpFamilyTree.ResumeLayout(false);
            this.tpFamilyTree.PerformLayout();
            this.familyTreePanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuMain;
        private System.Windows.Forms.ToolStripMenuItem appToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem screenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dashboardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem familyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem treeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem discoverToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem messagesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem albumToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem websiteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem feedbackToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.SplitContainer scMain;
        private System.Windows.Forms.TabControl tcPages;
        private System.Windows.Forms.TabPage tpFamilyTree;
        private System.Windows.Forms.TabPage tpFamilyTable;
        private System.Windows.Forms.TabPage tpDashboard;
        private System.Windows.Forms.Panel familyTreePanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblHeaderName;
        private System.Windows.Forms.PictureBox pbHeaderPicture;
        private System.Windows.Forms.Label lblHeaderTitle;
        private Controls.FamilyTreeNode familyTreeNode1;
    }
}