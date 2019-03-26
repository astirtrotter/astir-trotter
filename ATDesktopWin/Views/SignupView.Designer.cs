namespace ATDesktopWin.Views
{
    partial class SignupView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignupView));
            this.pbPicture = new System.Windows.Forms.PictureBox();
            this.cmsPicture = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuItemPictureCamera = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemPictureImage = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemPictureReset = new System.Windows.Forms.ToolStripMenuItem();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNickName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpBirthday = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtBirthPlace = new System.Windows.Forms.TextBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.cbGender = new System.Windows.Forms.ComboBox();
            this.cbClassOrigin = new System.Windows.Forms.ComboBox();
            this.cbSocialOrigin = new System.Windows.Forms.ComboBox();
            this.cbNationalOrigin = new System.Windows.Forms.ComboBox();
            this.cbParty = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtDetails = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUserId = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtPasswordConfirm = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cbNationality = new System.Windows.Forms.ComboBox();
            this.chbDied = new System.Windows.Forms.CheckBox();
            this.dtpDiedDay = new System.Windows.Forms.DateTimePicker();
            this.ofdPicture = new System.Windows.Forms.OpenFileDialog();
            this.ttPicture = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbPicture)).BeginInit();
            this.cmsPicture.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbPicture
            // 
            this.pbPicture.BackColor = System.Drawing.Color.Transparent;
            this.pbPicture.BackgroundImage = global::ATDesktopWin.Properties.Resources.default_user_male;
            this.pbPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbPicture.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbPicture.ContextMenuStrip = this.cmsPicture;
            this.pbPicture.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pbPicture.InitialImage = null;
            this.pbPicture.Location = new System.Drawing.Point(125, 30);
            this.pbPicture.Name = "pbPicture";
            this.pbPicture.Size = new System.Drawing.Size(135, 135);
            this.pbPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPicture.TabIndex = 0;
            this.pbPicture.TabStop = false;
            this.ttPicture.SetToolTip(this.pbPicture, "Click mouse right button to change or reset\r\n");
            // 
            // cmsPicture
            // 
            this.cmsPicture.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuItemPictureCamera,
            this.mnuItemPictureImage,
            this.mnuItemPictureReset});
            this.cmsPicture.Name = "cmsPicture";
            this.cmsPicture.Size = new System.Drawing.Size(158, 70);
            // 
            // mnuItemPictureCamera
            // 
            this.mnuItemPictureCamera.Name = "mnuItemPictureCamera";
            this.mnuItemPictureCamera.Size = new System.Drawing.Size(157, 22);
            this.mnuItemPictureCamera.Text = "From camera";
            this.mnuItemPictureCamera.Click += new System.EventHandler(this.mnuItemPictureCamera_Click);
            // 
            // mnuItemPictureImage
            // 
            this.mnuItemPictureImage.Name = "mnuItemPictureImage";
            this.mnuItemPictureImage.Size = new System.Drawing.Size(157, 22);
            this.mnuItemPictureImage.Text = "From image file";
            this.mnuItemPictureImage.Click += new System.EventHandler(this.mnuItemPictureImage_Click);
            // 
            // mnuItemPictureReset
            // 
            this.mnuItemPictureReset.Name = "mnuItemPictureReset";
            this.mnuItemPictureReset.Size = new System.Drawing.Size(157, 22);
            this.mnuItemPictureReset.Text = "Reset";
            this.mnuItemPictureReset.Click += new System.EventHandler(this.mnuItemPictureReset_Click);
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(125, 215);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(100, 20);
            this.txtFirstName.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 218);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "First Name*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(271, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Last Name*";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(339, 215);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(100, 20);
            this.txtLastName.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(485, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nick Name";
            // 
            // txtNickName
            // 
            this.txtNickName.Location = new System.Drawing.Point(555, 215);
            this.txtNickName.Name = "txtNickName";
            this.txtNickName.Size = new System.Drawing.Size(100, 20);
            this.txtNickName.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(73, 252);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Gender*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(284, 252);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Birthday*";
            // 
            // dtpBirthday
            // 
            this.dtpBirthday.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBirthday.Location = new System.Drawing.Point(339, 249);
            this.dtpBirthday.MaxDate = new System.DateTime(2019, 3, 20, 0, 0, 0, 0);
            this.dtpBirthday.Name = "dtpBirthday";
            this.dtpBirthday.Size = new System.Drawing.Size(100, 20);
            this.dtpBirthday.TabIndex = 7;
            this.dtpBirthday.Value = new System.DateTime(2019, 3, 20, 0, 0, 0, 0);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(57, 325);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Birth Place";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(70, 291);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Address";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(53, 404);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Class Origin";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(263, 404);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Social Origin";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(469, 364);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 13);
            this.label11.TabIndex = 11;
            this.label11.Text = "National Origin";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(471, 252);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(78, 13);
            this.label12.TabIndex = 11;
            this.label12.Text = "Phone Number";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(83, 443);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(32, 13);
            this.label13.TabIndex = 11;
            this.label13.Text = "Email";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(125, 288);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(530, 20);
            this.txtAddress.TabIndex = 9;
            // 
            // txtBirthPlace
            // 
            this.txtBirthPlace.Location = new System.Drawing.Point(125, 322);
            this.txtBirthPlace.Name = "txtBirthPlace";
            this.txtBirthPlace.Size = new System.Drawing.Size(530, 20);
            this.txtBirthPlace.TabIndex = 10;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(555, 250);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(100, 20);
            this.txtPhoneNumber.TabIndex = 8;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(125, 441);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(204, 20);
            this.txtEmail.TabIndex = 16;
            // 
            // btnSignUp
            // 
            this.btnSignUp.Location = new System.Drawing.Point(234, 568);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(75, 23);
            this.btnSignUp.TabIndex = 20;
            this.btnSignUp.Text = "Sign Up";
            this.btnSignUp.UseVisualStyleBackColor = true;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // btnBack
            // 
            this.btnBack.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnBack.Location = new System.Drawing.Point(400, 568);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 21;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // cbGender
            // 
            this.cbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGender.FormattingEnabled = true;
            this.cbGender.Location = new System.Drawing.Point(125, 249);
            this.cbGender.Name = "cbGender";
            this.cbGender.Size = new System.Drawing.Size(100, 21);
            this.cbGender.TabIndex = 6;
            this.cbGender.SelectedValueChanged += new System.EventHandler(this.cbGender_SelectedValueChanged);
            // 
            // cbClassOrigin
            // 
            this.cbClassOrigin.FormattingEnabled = true;
            this.cbClassOrigin.Location = new System.Drawing.Point(125, 401);
            this.cbClassOrigin.Name = "cbClassOrigin";
            this.cbClassOrigin.Size = new System.Drawing.Size(100, 21);
            this.cbClassOrigin.TabIndex = 14;
            // 
            // cbSocialOrigin
            // 
            this.cbSocialOrigin.FormattingEnabled = true;
            this.cbSocialOrigin.Location = new System.Drawing.Point(339, 401);
            this.cbSocialOrigin.Name = "cbSocialOrigin";
            this.cbSocialOrigin.Size = new System.Drawing.Size(100, 21);
            this.cbSocialOrigin.TabIndex = 15;
            // 
            // cbNationalOrigin
            // 
            this.cbNationalOrigin.FormattingEnabled = true;
            this.cbNationalOrigin.Location = new System.Drawing.Point(555, 361);
            this.cbNationalOrigin.Name = "cbNationalOrigin";
            this.cbNationalOrigin.Size = new System.Drawing.Size(100, 21);
            this.cbNationalOrigin.TabIndex = 13;
            // 
            // cbParty
            // 
            this.cbParty.FormattingEnabled = true;
            this.cbParty.Location = new System.Drawing.Point(125, 361);
            this.cbParty.Name = "cbParty";
            this.cbParty.Size = new System.Drawing.Size(100, 21);
            this.cbParty.TabIndex = 11;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(72, 364);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(31, 13);
            this.label15.TabIndex = 20;
            this.label15.Text = "Party";
            // 
            // txtDetails
            // 
            this.txtDetails.Location = new System.Drawing.Point(125, 480);
            this.txtDetails.MaxLength = 256;
            this.txtDetails.Multiline = true;
            this.txtDetails.Name = "txtDetails";
            this.txtDetails.Size = new System.Drawing.Size(530, 65);
            this.txtDetails.TabIndex = 19;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(76, 483);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(39, 13);
            this.label16.TabIndex = 11;
            this.label16.Text = "Details";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(361, 44);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(47, 13);
            this.label17.TabIndex = 23;
            this.label17.Text = "User ID*";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(351, 85);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(57, 13);
            this.label18.TabIndex = 24;
            this.label18.Text = "Password*";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(414, 82);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(198, 20);
            this.txtPassword.TabIndex = 1;
            // 
            // txtUserId
            // 
            this.txtUserId.Location = new System.Drawing.Point(414, 41);
            this.txtUserId.Name = "txtUserId";
            this.txtUserId.Size = new System.Drawing.Size(198, 20);
            this.txtUserId.TabIndex = 0;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(362, 125);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(46, 13);
            this.label19.TabIndex = 26;
            this.label19.Text = "Confirm*";
            // 
            // txtPasswordConfirm
            // 
            this.txtPasswordConfirm.Location = new System.Drawing.Point(414, 122);
            this.txtPasswordConfirm.Name = "txtPasswordConfirm";
            this.txtPasswordConfirm.PasswordChar = '*';
            this.txtPasswordConfirm.Size = new System.Drawing.Size(198, 20);
            this.txtPasswordConfirm.TabIndex = 2;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(273, 364);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(56, 13);
            this.label14.TabIndex = 18;
            this.label14.Text = "Nationality";
            // 
            // cbNationality
            // 
            this.cbNationality.FormattingEnabled = true;
            this.cbNationality.Location = new System.Drawing.Point(339, 361);
            this.cbNationality.Name = "cbNationality";
            this.cbNationality.Size = new System.Drawing.Size(100, 21);
            this.cbNationality.TabIndex = 12;
            // 
            // chbDied
            // 
            this.chbDied.AutoSize = true;
            this.chbDied.Location = new System.Drawing.Point(497, 443);
            this.chbDied.Name = "chbDied";
            this.chbDied.Size = new System.Drawing.Size(48, 17);
            this.chbDied.TabIndex = 17;
            this.chbDied.Text = "Died";
            this.chbDied.UseVisualStyleBackColor = true;
            this.chbDied.CheckedChanged += new System.EventHandler(this.chbDied_CheckedChanged);
            // 
            // dtpDiedDay
            // 
            this.dtpDiedDay.Enabled = false;
            this.dtpDiedDay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDiedDay.Location = new System.Drawing.Point(555, 441);
            this.dtpDiedDay.MaxDate = new System.DateTime(2019, 3, 20, 0, 0, 0, 0);
            this.dtpDiedDay.Name = "dtpDiedDay";
            this.dtpDiedDay.Size = new System.Drawing.Size(100, 20);
            this.dtpDiedDay.TabIndex = 18;
            this.dtpDiedDay.Value = new System.DateTime(2019, 3, 20, 0, 0, 0, 0);
            // 
            // ofdPicture
            // 
            this.ofdPicture.Filter = "Image files (*.bmp, *.jpg, *.png)|*.bmp;*.jpb;*.png|All files (*.*)|*.*";
            // 
            // SignupView
            // 
            this.AcceptButton = this.btnSignUp;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnBack;
            this.ClientSize = new System.Drawing.Size(708, 620);
            this.Controls.Add(this.dtpDiedDay);
            this.Controls.Add(this.chbDied);
            this.Controls.Add(this.cbParty);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.cbNationality);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.cbNationalOrigin);
            this.Controls.Add(this.cbSocialOrigin);
            this.Controls.Add(this.cbClassOrigin);
            this.Controls.Add(this.cbGender);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnSignUp);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtpBirthday);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNickName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBirthPlace);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.pbPicture);
            this.Controls.Add(this.txtDetails);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.txtPasswordConfirm);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUserId);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(724, 659);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(724, 659);
            this.Name = "SignupView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Astir Trotter (Sign Up)";
            ((System.ComponentModel.ISupportInitialize)(this.pbPicture)).EndInit();
            this.cmsPicture.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbPicture;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNickName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpBirthday;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtBirthPlace;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnSignUp;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ComboBox cbGender;
        private System.Windows.Forms.ComboBox cbClassOrigin;
        private System.Windows.Forms.ComboBox cbSocialOrigin;
        private System.Windows.Forms.ComboBox cbNationalOrigin;
        private System.Windows.Forms.ComboBox cbParty;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtDetails;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUserId;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtPasswordConfirm;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cbNationality;
        private System.Windows.Forms.CheckBox chbDied;
        private System.Windows.Forms.DateTimePicker dtpDiedDay;
        private System.Windows.Forms.ContextMenuStrip cmsPicture;
        private System.Windows.Forms.ToolStripMenuItem mnuItemPictureCamera;
        private System.Windows.Forms.ToolStripMenuItem mnuItemPictureImage;
        private System.Windows.Forms.ToolStripMenuItem mnuItemPictureReset;
        private System.Windows.Forms.OpenFileDialog ofdPicture;
        private System.Windows.Forms.ToolTip ttPicture;
    }
}