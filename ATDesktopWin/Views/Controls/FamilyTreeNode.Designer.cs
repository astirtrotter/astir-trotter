namespace ATDesktopWin.Views.Controls
{
    partial class FamilyTreeNode
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FamilyTreeNode));
            this.pbMother = new System.Windows.Forms.PictureBox();
            this.pbFather = new System.Windows.Forms.PictureBox();
            this.pbUser = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbMother)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFather)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pbMother
            // 
            this.pbMother.ErrorImage = global::ATDesktopWin.Properties.Resources.default_user_female;
            this.pbMother.Image = global::ATDesktopWin.Properties.Resources.default_user_female;
            this.pbMother.InitialImage = global::ATDesktopWin.Properties.Resources.default_user_female;
            this.pbMother.Location = new System.Drawing.Point(45, 0);
            this.pbMother.Name = "pbMother";
            this.pbMother.Size = new System.Drawing.Size(30, 30);
            this.pbMother.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMother.TabIndex = 3;
            this.pbMother.TabStop = false;
            // 
            // pbFather
            // 
            this.pbFather.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pbFather.ErrorImage")));
            this.pbFather.Image = ((System.Drawing.Image)(resources.GetObject("pbFather.Image")));
            this.pbFather.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbFather.InitialImage")));
            this.pbFather.Location = new System.Drawing.Point(5, 0);
            this.pbFather.Name = "pbFather";
            this.pbFather.Size = new System.Drawing.Size(30, 30);
            this.pbFather.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbFather.TabIndex = 2;
            this.pbFather.TabStop = false;
            // 
            // pbUser
            // 
            this.pbUser.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pbUser.ErrorImage")));
            this.pbUser.Image = ((System.Drawing.Image)(resources.GetObject("pbUser.Image")));
            this.pbUser.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbUser.InitialImage")));
            this.pbUser.Location = new System.Drawing.Point(0, 40);
            this.pbUser.Name = "pbUser";
            this.pbUser.Size = new System.Drawing.Size(80, 80);
            this.pbUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbUser.TabIndex = 0;
            this.pbUser.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ATDesktopWin.Properties.Resources.leaf;
            this.pictureBox1.Location = new System.Drawing.Point(36, 61);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // FamilyTreeNode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pbMother);
            this.Controls.Add(this.pbFather);
            this.Controls.Add(this.pbUser);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.MaximumSize = new System.Drawing.Size(80, 120);
            this.MinimumSize = new System.Drawing.Size(80, 120);
            this.Name = "FamilyTreeNode";
            this.Size = new System.Drawing.Size(80, 120);
            this.Validated += new System.EventHandler(this.FamilyTreeNode_Validated);
            ((System.ComponentModel.ISupportInitialize)(this.pbMother)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFather)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbUser;
        private System.Windows.Forms.PictureBox pbFather;
        private System.Windows.Forms.PictureBox pbMother;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
