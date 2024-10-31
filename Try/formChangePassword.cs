using DocumentManagementSystem.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Try
{
    public partial class formChangePassword : Form
    {
        private formDashboard _dashboard;
        private int _loggedInUserId;

        public formChangePassword(int loggedInUserId, formDashboard dashboard)
        {
            InitializeComponent();
            _loggedInUserId = loggedInUserId;
            _dashboard = dashboard; // Store the reference to formDashboard

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            if (_loggedInUserId != 0)
            {
                string currentPassword = txtCurrentPassword.Texts.Trim();
                string newPassword = txtNewPassword.Texts.Trim();
                string confirmPassword = txtConfirmNewPassword.Texts.Trim();

                // Validate inputs
                if (string.IsNullOrWhiteSpace(currentPassword) ||
                    string.IsNullOrWhiteSpace(newPassword) ||
                    string.IsNullOrWhiteSpace(confirmPassword))
                {
                    MessageBox.Show("All fields are required.");
                    return;
                }

                if (newPassword != confirmPassword)
                {
                    MessageBox.Show("New passwords do not match.");
                    return;
                }

                // Password strength validation for new password
                if (!IsValidPassword(newPassword))
                {
                    MessageBox.Show("New password must be at least 8 characters long and contain at least one number.");
                    return;
                }

                UserService userService = new UserService();

                // Attempt to change the password
                try
                {
                    if (userService.ChangePassword(_loggedInUserId, currentPassword, newPassword))
                    {
                        MessageBox.Show("Password changed successfully.");
                        txtCurrentPassword.Clear();
                        txtNewPassword.Clear();
                        txtConfirmNewPassword.Clear();

                        _dashboard.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Current password is incorrect.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Password change failed: {ex.Message}");
                }
            }
        }

                private bool IsValidPassword(string password)
        {
            // Check that the password is at least 8 characters long
            if (password.Length < 8)
            {
                return false;
            }

            // Check for at least one number
            return System.Text.RegularExpressions.Regex.IsMatch(password, @"[0-9]");
        }
    }
}
