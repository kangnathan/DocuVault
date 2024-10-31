using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using DocumentManagementSystem.Services;
using DocumentManagementSystem.Services;

namespace Try
{
    public partial class formResetPassword : Form
    {
        private bool isDragging = false;
        private Point lastCursor;
        private Point lastForm;

        private string _verificationPin; // The verification PIN
        private DateTime _pinGeneratedTime; // The time the PIN was generated
        private readonly TimeSpan _pinValidityDuration = TimeSpan.FromMinutes(5);

        public formResetPassword()
        {
            InitializeComponent();
        }

        private void formResetPassword_Load(object sender, EventArgs e)
        {
            int borderRadius = 30;

            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, borderRadius, borderRadius, 180, 90);
            path.AddArc(this.Width - borderRadius, 0, borderRadius, borderRadius, 270, 90);
            path.AddArc(this.Width - borderRadius, this.Height - borderRadius, borderRadius, borderRadius, 0, 90);
            path.AddArc(0, this.Height - borderRadius, borderRadius, borderRadius, 90, 90);
            path.CloseAllFigures();

            this.Region = new Region(path);

            this.MouseDown += new MouseEventHandler(Form_MouseDown);
            this.MouseMove += new MouseEventHandler(Form_MouseMove);
            this.MouseUp += new MouseEventHandler(Form_MouseUp);
        }

        private void Form_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                lastCursor = Cursor.Position;
                lastForm = this.Location;
            }
        }

        private void Form_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                Point delta = Point.Subtract(Cursor.Position, new Size(lastCursor));
                this.Location = Point.Add(lastForm, new Size(delta));
            }
        }

        private void Form_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnFormLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private async void btnSendEmail_Click(object sender, EventArgs e)
        {
            string recipientEmail = txtSendEmail.Texts.Trim(); // Get the input and trim whitespace

            UserService userService = new UserService();

            // Check if the email is registered
            if (await userService.IsEmailRegisteredAsync(recipientEmail))
            {
                _verificationPin = GenerateVerificationPin(); // Generate a random PIN
                _pinGeneratedTime = DateTime.Now; // Store the generation time

                EmailService emailService = new EmailService();
                try
                {
                    await emailService.SendEmailAsync(recipientEmail, "VERIFICATION PIN", "OOP DMS PIN", "<strong></strong>", _verificationPin);
                    MessageBox.Show("Email sent with your verification PIN!");
                }
                catch (Exception ex)
                {
                    // Log or handle the error
                    MessageBox.Show($"Error sending email: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Email address not registered.");
                txtSendEmail.Clear();
            }
        }

        private async void btnVerificationChangePassword_Click(object sender, EventArgs e)
        {
            string enteredPin = txtVerificationPin.Texts.Trim();
            string newPassword = txtVerificationNewPassword.Texts.Trim();
            string confirmNewPassword = txtConfirmVerificationNewPassword.Texts.Trim();

            // Check if the PIN is still valid
            if (DateTime.Now - _pinGeneratedTime <= _pinValidityDuration)
            {
                if (enteredPin == _verificationPin)
                {
                    if (newPassword == confirmNewPassword)
                    {
                        UserService userService = new UserService();

                        // Here you should ideally retrieve the user's email or user ID to update their password
                        string userEmail = txtSendEmail.Texts.Trim(); // Assume this field is available

                        // Reset the password in the database
                        bool isPasswordChanged = await userService.ResetPasswordAsync(userEmail, newPassword);

                        if (isPasswordChanged)
                        {
                            MessageBox.Show("Password changed successfully!");
                            this.Hide();
                            txtSendEmail.Clear();
                            txtVerificationPin.Clear();
                            txtVerificationNewPassword.Clear();
                            txtConfirmVerificationNewPassword.Clear();
                        }
                        else
                        {
                            MessageBox.Show("Failed to change the password. Please try again.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Passwords do not match. Please try again.");
                    }
                }
                else
                {
                    MessageBox.Show("Invalid PIN. Please try again.");
                }
            }
            else
            {
                MessageBox.Show("The PIN has expired. Please request a new one.");
            }
        }

        private string GenerateVerificationPin()
        {
            Random random = new Random();
            return random.Next(100000, 999999).ToString(); 
        }


        private bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
            {
                return false; 
            }

            var emailRegex = new System.Text.RegularExpressions.Regex(
                @"^[^@\s]+@[^@\s]+\.[^@\s]+$",
                System.Text.RegularExpressions.RegexOptions.IgnoreCase);

            if (!emailRegex.IsMatch(email))
            {
                return false;
            }

            try
            {

                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }


    }
}
