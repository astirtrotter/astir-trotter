using ATDesktopWin.Config;
using ATDesktopWin.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            
            cbGender.DataSource = GlobalConstants.genders;
            cbGender.DisplayMember = "value";
            cbGender.ValueMember = "value";
            cbGender.SelectedIndex = -1;

            cbParty.DataSource = GlobalConstants.parties;
            cbParty.DisplayMember = "value";
            cbParty.ValueMember = "value";
            cbParty.SelectedIndex = -1;

            cbNationality.DataSource = GlobalConstants.nationalities;
            cbNationality.DisplayMember = "value";
            cbNationality.ValueMember = "value";
            cbNationality.SelectedIndex = -1;

            cbClassOrigin.DataSource = GlobalConstants.classOrigins;
            cbClassOrigin.DisplayMember = "value";
            cbClassOrigin.ValueMember = "value";
            cbClassOrigin.SelectedIndex = -1;

            cbSocialOrigin.DataSource = GlobalConstants.socialOrigins;
            cbSocialOrigin.DisplayMember = "value";
            cbSocialOrigin.ValueMember = "value";
            cbSocialOrigin.SelectedIndex = -1;

            cbNationalOrigin.DataSource = GlobalConstants.nationalOrigins;
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
                MessageBox.Show("Invalid fields: \n\n" + String.Join("\n", invalidFields));
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

                ((SignupController)AppManager.Instance._currentController)
                    .Signup(userId, password, firstName, lastName, nickName, gender, 
                    birthday, address, birthPlace, party, nationality, nationalOrigin, 
                    classOrigin, socialOrigin, phoneNumber, email, details, diedDay);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            ((SignupController)AppManager.Instance._currentController).Back();
        }

        private void chbDied_CheckedChanged(object sender, EventArgs e)
        {
            dtpDiedDay.Enabled = chbDied.Checked;
        }
    }
}
