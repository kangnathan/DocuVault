using CustomControls.RJControls;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using DocumentManagementSystem.Models;
using DocumentManagementSystem.Services;

namespace Try
{
    public partial class formLogin : Form
    {
        private bool isDragging = false;
        private Point lastCursor;
        private Point lastForm;
        private int _loggedInUserId;

        public formLogin()
        {
            InitializeComponent();
        }

        private void formLogin_Load(object sender, EventArgs e)
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            // Trim any accidental whitespace that may be present
            string username = txtUsername.Texts.Trim();
            string password = txtPassword.Texts.Trim();

            UserService userService = new UserService();

            // Await the Authenticate method
            User authenticatedUser = await userService.Authenticate(username, password);

            if (authenticatedUser != null)
            {
                if (authenticatedUser.IsLocked)
                {
                    MessageBox.Show("Your account is locked. Please contact an administrator.");
                    txtUsername.Clear();
                    txtPassword.Clear();
                    return; // Exit if account is locked
                }

                _loggedInUserId = authenticatedUser.UserId;
                MessageBox.Show("Login successful!");


                this.Hide();
                formDashboard dashboard = new formDashboard(_loggedInUserId);
                dashboard.ShowDialog();
                dashboard = null;
                this.Show();

                txtUsername.Clear();
                txtPassword.Clear();
            }
            else
            {
                txtUsername.Clear();
                txtPassword.Clear();
                MessageBox.Show("Invalid username or password.");
            }
        }

        private void btnForgotPassord_Click(object sender, EventArgs e)
        {
            this.Hide();
            formResetPassword reset = new formResetPassword();
            reset.ShowDialog();
            reset = null;
            this.Show();
        }

        private void btnFormRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            formRegister register = new formRegister();
            register.ShowDialog();
            register = null;
            this.Show();
            txtUsername.Clear();
            txtPassword.Clear();
        }
    }
}
