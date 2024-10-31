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
using DocumentManagementSystem.Models;
using DocumentManagementSystem.Services;

namespace Try
{
    public partial class formDashboard : Form
    {
        private bool isDragging = false;
        private Point lastCursor;
        private Point lastForm;

        bool menuHomeExpand = false;
        bool menuSecurityExpand = false;
        bool sidebarExpand = false;

        formDocuments documents;
        formHistory history;
        formAbout about;
        formChangePassword changePassword;

        private AuditTrailService auditTrailService = new AuditTrailService();
        private DocumentService documentService = new DocumentService();
        private int _loggedInUserId; // Assume this ID is set when the user logs in

        public formDashboard(int loggedInUserId)
        {
            InitializeComponent();
            panel1.MouseDown += new MouseEventHandler(Form_MouseDown);
            panel1.MouseMove += new MouseEventHandler(Form_MouseMove);
            panel1.MouseUp += new MouseEventHandler(Form_MouseUp);
            _loggedInUserId = loggedInUserId;

        }

        private void formDashboard_Load(object sender, EventArgs e)
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

        private void btnHam_Click(object sender, EventArgs e)
        {
            sidebarTransition.Start();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            menuTransitionHome.Start();
        }

        private void btnSecurity_Click(object sender, EventArgs e)
        {
            menuTransitionSecurity.Start();
        }

        private void sidebarTransition_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sideBar.Width -= 10;
                if (sideBar.Width <= 77)
                {
                    sidebarExpand = false;
                    sidebarTransition.Stop();

                }
            }
            else
            {
                sideBar.Width += 10;
                if (sideBar.Width >= 250)
                {
                    sidebarExpand = true;
                    sidebarTransition.Stop();

                }
            }
        }

        private void menuTransitionHome_Tick(object sender, EventArgs e)
        {
            if (menuHomeExpand == false) {
                menuHome.Height += 10;
                if (menuHome.Height >= 196) {
                    menuTransitionHome.Stop();
                    menuHomeExpand = true;
                    
                }
            }
            else {
                menuHome.Height -= 10;
                if(menuHome.Height <= 49) {  
                    menuTransitionHome.Stop();
                    menuHomeExpand = false;
                }
            }
        }

        private void btnDocuments_Click(object sender, EventArgs e)
        {
            if(documents == null)
            {
                formDocuments documents = new formDocuments(_loggedInUserId);
                documents.FormClosed += Documents_FormClosed;
                documents.MdiParent = this;
                documents.Dock = DockStyle.Fill; 

                documentService.LoadDocuments(_loggedInUserId, documents.LvDocuments);

                documents.Show();
            }
            else
            {
                documents.Activate();
            }
        }

        private void Documents_FormClosed(object sender, FormClosedEventArgs e)
        {
            documents = null;
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            if (history == null)
            {
                formHistory history = new formHistory(_loggedInUserId);
                history.FormClosed += History_FormClosed;
                history.MdiParent = this;
                history.Dock = DockStyle.Fill;

                auditTrailService.LoadAuditTrail(_loggedInUserId, history.LvAuditTrail);

                history.Show();
            }
            else
            {
                history.Activate();
            }
        }

        private void History_FormClosed(object sender, FormClosedEventArgs e)
        {
            history = null; 
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            if (about == null)
            {
                about = new formAbout();
                about.FormClosed += History_FormClosed;
                about.MdiParent = this;
                about.Dock = DockStyle.Fill;
                about.Show();
            }
            else
            {
                about.Activate();
            }
        }

        private void menuTransitionSecurity_Tick(object sender, EventArgs e)
        {
            if (menuSecurityExpand == false) {
                menuSecurity.Height += 10;
                if (menuSecurity.Height >= 98) {
                    menuTransitionSecurity.Stop();
                    menuSecurityExpand = true;

                }
            }
            else {
                menuSecurity.Height -= 10;
                if (menuSecurity.Height <= 49)
                {
                    menuTransitionSecurity.Stop();
                    menuSecurityExpand = false;
                }
            }
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            if (changePassword == null)
            {
                changePassword = new formChangePassword(_loggedInUserId, this);
                changePassword.FormClosed += History_FormClosed;
                changePassword.MdiParent = this;
                changePassword.Dock = DockStyle.Fill;
                changePassword.Show();
            }
            else
            {
                changePassword.Activate();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            _loggedInUserId = 0;

            if (documents != null)
            {
                documents.Close();
                documents = null;
            }
            if (history != null)
            {
                history.Close();
                history = null;
            }

            MessageBox.Show("You have logged out successfully.");

            this.Hide();
        }

    }
}
