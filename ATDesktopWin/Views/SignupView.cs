using ATCommon.Global;
using ATDesktopWin.Controllers;
using ATDesktopWin.Helpers;
using ATDesktopWin.Views.Dialogs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATDesktopWin.Views
{
    public partial class SignupView : Form, IView
    {
        public string Title { get => Text; set => Text = value; }

        public Form Form => this;

    
        public SignupView()
        {
            InitializeComponent();
            
            cbGender.DataSource = Constants.genders;
            cbGender.DisplayMember = "value";
            cbGender.ValueMember = "value";

            cbParty.DataSource = Constants.parties;
            cbParty.DisplayMember = "value";
            cbParty.ValueMember = "value";
            cbParty.SelectedIndex = -1;

            cbNationality.DataSource = Constants.nationalities;
            cbNationality.DisplayMember = "value";
            cbNationality.ValueMember = "value";
            cbNationality.SelectedIndex = -1;

            cbClassOrigin.DataSource = Constants.classOrigins;
            cbClassOrigin.DisplayMember = "value";
            cbClassOrigin.ValueMember = "value";
            cbClassOrigin.SelectedIndex = -1;

            cbSocialOrigin.DataSource = Constants.socialOrigins;
            cbSocialOrigin.DisplayMember = "value";
            cbSocialOrigin.ValueMember = "value";
            cbSocialOrigin.SelectedIndex = -1;

            cbNationalOrigin.DataSource = Constants.nationalOrigins;
            cbNationalOrigin.DisplayMember = "value";
            cbNationalOrigin.ValueMember = "value";
            cbNationalOrigin.SelectedIndex = -1;

            dtpBirthday.MaxDate = DateTime.Today;
            dtpDiedDay.MaxDate = DateTime.Today;
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            // check basic validity of input
            string userId = txtUserId.Text,
                password = txtPassword.Text,
                passwordConfirm = txtPasswordConfirm.Text,
                firstName = txtFirstName.Text,
                lastName = txtLastName.Text,
                nickName = txtNickName.Text,
                gender = cbGender.Text,
                birthday = dtpBirthday.Value.ToShortDateString(),
                address = txtAddress.Text,
                birthPlace = txtBirthPlace.Text,
                party = cbParty.Text,
                nationality = cbNationality.Text,
                nationalOrigin = cbNationalOrigin.Text,
                classOrigin = cbClassOrigin.Text,
                socialOrigin = cbSocialOrigin.Text,
                phoneNumber = txtPhoneNumber.Text,
                email = txtEmail.Text,
                details = txtDetails.Text,
                diedDay = dtpDiedDay.Value.ToShortDateString();
            
            List<string> invalidFields = new List<string>();
            if (userId.Length == 0) invalidFields.Add("User Id");
            if (password.Length == 0) invalidFields.Add("Password");
            if (password != passwordConfirm) invalidFields.Add("Confirm");
            if (firstName.Length == 0) invalidFields.Add("First Name");
            if (lastName.Length == 0) invalidFields.Add("Last Name");
            if (gender.Length == 0) invalidFields.Add("Gender");

            if (invalidFields.Count > 0)
            {
                MessageBoxHelper.ShowWarning(this, Constants.Messages.Warning.InvalidInput + String.Join("\n", invalidFields));
            } else
            {
                if (nickName.Length == 0) nickName = null;
                if (address.Length == 0) address = null;
                if (birthPlace.Length == 0) birthPlace = null;
                if (party.Length == 0) party = null;
                if (nationality.Length == 0) nationality = null;
                if (nationalOrigin.Length == 0) nationalOrigin = null;
                if (classOrigin.Length == 0) classOrigin = null;
                if (socialOrigin.Length == 0) socialOrigin = null;
                if (phoneNumber.Length == 0) phoneNumber = null;
                if (email.Length == 0) email = null;
                if (details.Length == 0) details = null;
                if (!chbDied.Checked) diedDay = null;

                byte[] picture = null;
                if (pbPicture.Image != null)
                {
                    using (MemoryStream ms = new MemoryStream())
                    {
                        pbPicture.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                        picture = ms.ToArray();
                    }
                }

                AppManager.Instance.GetCurController<SignupController>()
                    .Signup(userId, password, firstName, lastName, nickName, gender, 
                    birthday, address, birthPlace, party, nationality, nationalOrigin, 
                    classOrigin, socialOrigin, phoneNumber, email, details, diedDay, 
                    picture);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            AppManager.Instance.GetCurController<SignupController>().Back();
        }

        private void chbDied_CheckedChanged(object sender, EventArgs e)
        {
            dtpDiedDay.Enabled = chbDied.Checked;
        }

        private void mnuItemPictureReset_Click(object sender, EventArgs e)
        {
            if (pbPicture.Image != null)
            {
                pbPicture.Image.Dispose();
                pbPicture.Image = null;
            }
        }

        private void mnuItemPictureImage_Click(object sender, EventArgs e)
        {
            if (ofdPicture.ShowDialog() == DialogResult.OK)
            {
                if (pbPicture.Image != null)
                {
                    pbPicture.Image.Dispose();
                }
                pbPicture.Image = ImageHelper.CropBitmap(new Bitmap(ofdPicture.FileName), pbPicture.Width, pbPicture.Height); 
            }
        }

        private void mnuItemPictureCamera_Click(object sender, EventArgs e)
        {
            CameraDialog cameraDialog = new CameraDialog();
            if (cameraDialog.ShowDialog() == DialogResult.OK)
            {
                if (pbPicture.Image != null)
                {
                    pbPicture.Image.Dispose();
                }
                pbPicture.Image = ImageHelper.CropBitmap(cameraDialog.image, pbPicture.Width, pbPicture.Height);
            }
        }

        private void cbGender_SelectedValueChanged(object sender, EventArgs e)
        {
            pbPicture.BackgroundImage = cbGender.SelectedValue == Constants.genders[0].value
                ? Properties.Resources.default_user_male
                : Properties.Resources.default_user_female;
        }
    }
}
