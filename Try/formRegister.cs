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

namespace Try
{
    public partial class formRegister : Form
    {
        private bool isDragging = false;
        private Point lastCursor;
        private Point lastForm;

        public formRegister()
        {
            InitializeComponent();
        }

        private void formRegister_Load(object sender, EventArgs e)
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

        private void btnFormLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string username = txtRegisterUsername.Texts.Trim();
            string password = txtRegisterPassword.Texts.Trim();
            string confirmPassword = txtConfirmPassword.Texts.Trim();
            string email = txtEmail.Texts.Trim(); // Get email input

            // Validate inputs
            if (string.IsNullOrWhiteSpace(username) ||
                string.IsNullOrWhiteSpace(password) ||
                string.IsNullOrWhiteSpace(confirmPassword) ||
                string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("All fields are required.");
                return;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("Passwords do not match.");
                return;
            }

            if (!IsValidEmail(email))
            {
                MessageBox.Show("Please enter a valid email address.");
                return;
            }

            // Password strength validation
            if (!IsValidPassword(password))
            {
                MessageBox.Show("Password must be at least 8 characters long and contain at least one number.");
                return;
            }

            UserService userService = new UserService();

            // Check if username already exists
            if (userService.DoesUserExist(username))
            {
                MessageBox.Show("Username already exists. Please choose another.");
                return;
            }

            try
            {
                // Register the new user
                userService.RegisterUser(username, password, email);
                MessageBox.Show("Registration successful! You can now log in.");

                // Clear input fields
                txtRegisterUsername.Clear();
                txtRegisterPassword.Clear();
                txtEmail.Clear();
                txtConfirmPassword.Clear();
                this.Hide();
            }
            catch (Exception ex)
            {
                // Check if the exception is due to email already existing
                if (ex.Message.Contains("Email already exists"))
                {
                    MessageBox.Show("Email already exists. Please use a different email.");
                }
                else
                {
                    MessageBox.Show("An error occurred during registration. Please try again.");
                }
            }
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
