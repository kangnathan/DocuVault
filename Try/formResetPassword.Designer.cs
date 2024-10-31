namespace Try
{
    partial class formResetPassword
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSendEmail = new CustomControls.RJControls.RJTextBox();
            this.btnSendEmail = new CustomControls.RJControls.RJButton();
            this.txtConfirmVerificationNewPassword = new CustomControls.RJControls.RJTextBox();
            this.txtVerificationPin = new CustomControls.RJControls.RJTextBox();
            this.btnVerificationChangePassword = new CustomControls.RJControls.RJButton();
            this.txtVerificationNewPassword = new CustomControls.RJControls.RJTextBox();
            this.btnFormLogin = new CustomControls.RJControls.RJButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 42F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(237, 204);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 64);
            this.label1.TabIndex = 41;
            this.label1.Text = "DocuVault";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Gothic", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(705, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 636);
            this.label2.TabIndex = 42;
            this.label2.Text = "|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(248, 280);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(266, 60);
            this.label3.TabIndex = 43;
            this.label3.Text = "Enter your email to receive \r\nthe verification PIN.\r\n";
            // 
            // txtSendEmail
            // 
            this.txtSendEmail.BackColor = System.Drawing.SystemColors.Window;
            this.txtSendEmail.BorderColor = System.Drawing.Color.White;
            this.txtSendEmail.BorderFocusColor = System.Drawing.Color.White;
            this.txtSendEmail.BorderRadius = 5;
            this.txtSendEmail.BorderSize = 2;
            this.txtSendEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSendEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSendEmail.Location = new System.Drawing.Point(250, 358);
            this.txtSendEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtSendEmail.Multiline = false;
            this.txtSendEmail.Name = "txtSendEmail";
            this.txtSendEmail.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtSendEmail.PasswordChar = false;
            this.txtSendEmail.PlaceholderColor = System.Drawing.Color.Black;
            this.txtSendEmail.PlaceholderText = "Email";
            this.txtSendEmail.Size = new System.Drawing.Size(258, 31);
            this.txtSendEmail.TabIndex = 45;
            this.txtSendEmail.Texts = "";
            this.txtSendEmail.UnderlinedStyle = false;
            // 
            // btnSendEmail
            // 
            this.btnSendEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.btnSendEmail.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.btnSendEmail.BorderColor = System.Drawing.Color.Navy;
            this.btnSendEmail.BorderRadius = 5;
            this.btnSendEmail.BorderSize = 0;
            this.btnSendEmail.FlatAppearance.BorderSize = 0;
            this.btnSendEmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSendEmail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendEmail.ForeColor = System.Drawing.Color.White;
            this.btnSendEmail.Location = new System.Drawing.Point(250, 396);
            this.btnSendEmail.Name = "btnSendEmail";
            this.btnSendEmail.Size = new System.Drawing.Size(258, 31);
            this.btnSendEmail.TabIndex = 44;
            this.btnSendEmail.Text = "Send PIN";
            this.btnSendEmail.TextColor = System.Drawing.Color.White;
            this.btnSendEmail.UseVisualStyleBackColor = false;
            this.btnSendEmail.Click += new System.EventHandler(this.btnSendEmail_Click);
            // 
            // txtConfirmVerificationNewPassword
            // 
            this.txtConfirmVerificationNewPassword.BackColor = System.Drawing.SystemColors.Window;
            this.txtConfirmVerificationNewPassword.BorderColor = System.Drawing.Color.White;
            this.txtConfirmVerificationNewPassword.BorderFocusColor = System.Drawing.Color.White;
            this.txtConfirmVerificationNewPassword.BorderRadius = 5;
            this.txtConfirmVerificationNewPassword.BorderSize = 2;
            this.txtConfirmVerificationNewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmVerificationNewPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtConfirmVerificationNewPassword.Location = new System.Drawing.Point(932, 358);
            this.txtConfirmVerificationNewPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtConfirmVerificationNewPassword.Multiline = false;
            this.txtConfirmVerificationNewPassword.Name = "txtConfirmVerificationNewPassword";
            this.txtConfirmVerificationNewPassword.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtConfirmVerificationNewPassword.PasswordChar = true;
            this.txtConfirmVerificationNewPassword.PlaceholderColor = System.Drawing.Color.Black;
            this.txtConfirmVerificationNewPassword.PlaceholderText = "Confirm New Password";
            this.txtConfirmVerificationNewPassword.Size = new System.Drawing.Size(258, 31);
            this.txtConfirmVerificationNewPassword.TabIndex = 48;
            this.txtConfirmVerificationNewPassword.Texts = "";
            this.txtConfirmVerificationNewPassword.UnderlinedStyle = false;
            // 
            // txtVerificationPin
            // 
            this.txtVerificationPin.BackColor = System.Drawing.SystemColors.Window;
            this.txtVerificationPin.BorderColor = System.Drawing.Color.White;
            this.txtVerificationPin.BorderFocusColor = System.Drawing.Color.White;
            this.txtVerificationPin.BorderRadius = 5;
            this.txtVerificationPin.BorderSize = 2;
            this.txtVerificationPin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVerificationPin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtVerificationPin.Location = new System.Drawing.Point(932, 280);
            this.txtVerificationPin.Margin = new System.Windows.Forms.Padding(4);
            this.txtVerificationPin.Multiline = false;
            this.txtVerificationPin.Name = "txtVerificationPin";
            this.txtVerificationPin.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtVerificationPin.PasswordChar = false;
            this.txtVerificationPin.PlaceholderColor = System.Drawing.Color.Black;
            this.txtVerificationPin.PlaceholderText = "PIN";
            this.txtVerificationPin.Size = new System.Drawing.Size(258, 31);
            this.txtVerificationPin.TabIndex = 47;
            this.txtVerificationPin.Texts = "";
            this.txtVerificationPin.UnderlinedStyle = false;
            // 
            // btnVerificationChangePassword
            // 
            this.btnVerificationChangePassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.btnVerificationChangePassword.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.btnVerificationChangePassword.BorderColor = System.Drawing.Color.Navy;
            this.btnVerificationChangePassword.BorderRadius = 5;
            this.btnVerificationChangePassword.BorderSize = 0;
            this.btnVerificationChangePassword.FlatAppearance.BorderSize = 0;
            this.btnVerificationChangePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerificationChangePassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerificationChangePassword.ForeColor = System.Drawing.Color.White;
            this.btnVerificationChangePassword.Location = new System.Drawing.Point(932, 396);
            this.btnVerificationChangePassword.Name = "btnVerificationChangePassword";
            this.btnVerificationChangePassword.Size = new System.Drawing.Size(258, 31);
            this.btnVerificationChangePassword.TabIndex = 46;
            this.btnVerificationChangePassword.Text = "Reset Password";
            this.btnVerificationChangePassword.TextColor = System.Drawing.Color.White;
            this.btnVerificationChangePassword.UseVisualStyleBackColor = false;
            this.btnVerificationChangePassword.Click += new System.EventHandler(this.btnVerificationChangePassword_Click);
            // 
            // txtVerificationNewPassword
            // 
            this.txtVerificationNewPassword.BackColor = System.Drawing.SystemColors.Window;
            this.txtVerificationNewPassword.BorderColor = System.Drawing.Color.White;
            this.txtVerificationNewPassword.BorderFocusColor = System.Drawing.Color.White;
            this.txtVerificationNewPassword.BorderRadius = 5;
            this.txtVerificationNewPassword.BorderSize = 2;
            this.txtVerificationNewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVerificationNewPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtVerificationNewPassword.Location = new System.Drawing.Point(932, 319);
            this.txtVerificationNewPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtVerificationNewPassword.Multiline = false;
            this.txtVerificationNewPassword.Name = "txtVerificationNewPassword";
            this.txtVerificationNewPassword.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtVerificationNewPassword.PasswordChar = true;
            this.txtVerificationNewPassword.PlaceholderColor = System.Drawing.Color.Black;
            this.txtVerificationNewPassword.PlaceholderText = "New Password";
            this.txtVerificationNewPassword.Size = new System.Drawing.Size(258, 31);
            this.txtVerificationNewPassword.TabIndex = 49;
            this.txtVerificationNewPassword.Texts = "";
            this.txtVerificationNewPassword.UnderlinedStyle = false;
            // 
            // btnFormLogin
            // 
            this.btnFormLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.btnFormLogin.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.btnFormLogin.BorderColor = System.Drawing.Color.Navy;
            this.btnFormLogin.BorderRadius = 5;
            this.btnFormLogin.BorderSize = 0;
            this.btnFormLogin.FlatAppearance.BorderSize = 0;
            this.btnFormLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFormLogin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFormLogin.ForeColor = System.Drawing.Color.White;
            this.btnFormLogin.Location = new System.Drawing.Point(28, 694);
            this.btnFormLogin.Name = "btnFormLogin";
            this.btnFormLogin.Size = new System.Drawing.Size(127, 33);
            this.btnFormLogin.TabIndex = 50;
            this.btnFormLogin.Text = "Login";
            this.btnFormLogin.TextColor = System.Drawing.Color.White;
            this.btnFormLogin.UseVisualStyleBackColor = false;
            this.btnFormLogin.Click += new System.EventHandler(this.btnFormLogin_Click);
            // 
            // formResetPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(102)))), ((int)(((byte)(113)))));
            this.ClientSize = new System.Drawing.Size(1378, 753);
            this.Controls.Add(this.btnFormLogin);
            this.Controls.Add(this.txtVerificationNewPassword);
            this.Controls.Add(this.txtConfirmVerificationNewPassword);
            this.Controls.Add(this.txtVerificationPin);
            this.Controls.Add(this.btnVerificationChangePassword);
            this.Controls.Add(this.txtSendEmail);
            this.Controls.Add(this.btnSendEmail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formResetPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formResetPassword";
            this.Load += new System.EventHandler(this.formResetPassword_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private CustomControls.RJControls.RJTextBox txtSendEmail;
        private CustomControls.RJControls.RJButton btnSendEmail;
        private CustomControls.RJControls.RJTextBox txtConfirmVerificationNewPassword;
        private CustomControls.RJControls.RJTextBox txtVerificationPin;
        private CustomControls.RJControls.RJButton btnVerificationChangePassword;
        private CustomControls.RJControls.RJTextBox txtVerificationNewPassword;
        private CustomControls.RJControls.RJButton btnFormLogin;
    }
}