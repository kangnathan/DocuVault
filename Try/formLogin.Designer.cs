namespace Try
{
    partial class formLogin
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
            this.btnExit = new CustomControls.RJControls.RJButton();
            this.btnFormRegister = new CustomControls.RJControls.RJButton();
            this.btnForgotPassord = new CustomControls.RJControls.RJButton();
            this.txtPassword = new CustomControls.RJControls.RJTextBox();
            this.txtUsername = new CustomControls.RJControls.RJTextBox();
            this.btnLogin = new CustomControls.RJControls.RJButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 65.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(483, 232);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(452, 98);
            this.label1.TabIndex = 40;
            this.label1.Text = "DocuVault";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.btnExit.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.btnExit.BorderColor = System.Drawing.Color.Navy;
            this.btnExit.BorderRadius = 5;
            this.btnExit.BorderSize = 0;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(1322, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(44, 33);
            this.btnExit.TabIndex = 42;
            this.btnExit.Text = " X";
            this.btnExit.TextColor = System.Drawing.Color.White;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnFormRegister
            // 
            this.btnFormRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.btnFormRegister.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.btnFormRegister.BorderColor = System.Drawing.Color.Navy;
            this.btnFormRegister.BorderRadius = 5;
            this.btnFormRegister.BorderSize = 0;
            this.btnFormRegister.FlatAppearance.BorderSize = 0;
            this.btnFormRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFormRegister.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFormRegister.ForeColor = System.Drawing.Color.White;
            this.btnFormRegister.Location = new System.Drawing.Point(28, 694);
            this.btnFormRegister.Name = "btnFormRegister";
            this.btnFormRegister.Size = new System.Drawing.Size(127, 33);
            this.btnFormRegister.TabIndex = 41;
            this.btnFormRegister.Text = "Register";
            this.btnFormRegister.TextColor = System.Drawing.Color.White;
            this.btnFormRegister.UseVisualStyleBackColor = false;
            this.btnFormRegister.Click += new System.EventHandler(this.btnFormRegister_Click);
            // 
            // btnForgotPassord
            // 
            this.btnForgotPassord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(102)))), ((int)(((byte)(113)))));
            this.btnForgotPassord.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(102)))), ((int)(((byte)(113)))));
            this.btnForgotPassord.BorderColor = System.Drawing.Color.White;
            this.btnForgotPassord.BorderRadius = 5;
            this.btnForgotPassord.BorderSize = 0;
            this.btnForgotPassord.FlatAppearance.BorderSize = 0;
            this.btnForgotPassord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnForgotPassord.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnForgotPassord.ForeColor = System.Drawing.Color.Black;
            this.btnForgotPassord.Location = new System.Drawing.Point(576, 448);
            this.btnForgotPassord.Name = "btnForgotPassord";
            this.btnForgotPassord.Size = new System.Drawing.Size(258, 31);
            this.btnForgotPassord.TabIndex = 39;
            this.btnForgotPassord.Text = "Forgot Password?";
            this.btnForgotPassord.TextColor = System.Drawing.Color.Black;
            this.btnForgotPassord.UseVisualStyleBackColor = false;
            this.btnForgotPassord.Click += new System.EventHandler(this.btnForgotPassord_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.SystemColors.Window;
            this.txtPassword.BorderColor = System.Drawing.Color.White;
            this.txtPassword.BorderFocusColor = System.Drawing.Color.White;
            this.txtPassword.BorderRadius = 5;
            this.txtPassword.BorderSize = 2;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPassword.Location = new System.Drawing.Point(576, 373);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassword.Multiline = false;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtPassword.PasswordChar = true;
            this.txtPassword.PlaceholderColor = System.Drawing.Color.Black;
            this.txtPassword.PlaceholderText = "Password";
            this.txtPassword.Size = new System.Drawing.Size(258, 31);
            this.txtPassword.TabIndex = 38;
            this.txtPassword.Texts = "";
            this.txtPassword.UnderlinedStyle = false;
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.SystemColors.Window;
            this.txtUsername.BorderColor = System.Drawing.Color.White;
            this.txtUsername.BorderFocusColor = System.Drawing.Color.White;
            this.txtUsername.BorderRadius = 5;
            this.txtUsername.BorderSize = 2;
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtUsername.Location = new System.Drawing.Point(576, 334);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(4);
            this.txtUsername.Multiline = false;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtUsername.PasswordChar = false;
            this.txtUsername.PlaceholderColor = System.Drawing.Color.Black;
            this.txtUsername.PlaceholderText = "Username";
            this.txtUsername.Size = new System.Drawing.Size(258, 31);
            this.txtUsername.TabIndex = 37;
            this.txtUsername.Texts = "";
            this.txtUsername.UnderlinedStyle = false;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.btnLogin.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.btnLogin.BorderColor = System.Drawing.Color.Navy;
            this.btnLogin.BorderRadius = 5;
            this.btnLogin.BorderSize = 0;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(576, 411);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(258, 31);
            this.btnLogin.TabIndex = 36;
            this.btnLogin.Text = "Login\r\n\r\n";
            this.btnLogin.TextColor = System.Drawing.Color.White;
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // formLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(102)))), ((int)(((byte)(113)))));
            this.ClientSize = new System.Drawing.Size(1378, 753);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnFormRegister);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnForgotPassord);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.btnLogin);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formLogin";
            this.Load += new System.EventHandler(this.formLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private CustomControls.RJControls.RJButton btnLogin;
        private CustomControls.RJControls.RJTextBox txtUsername;
        private CustomControls.RJControls.RJTextBox txtPassword;
        private CustomControls.RJControls.RJButton btnForgotPassord;
        private System.Windows.Forms.Label label1;
        private CustomControls.RJControls.RJButton btnFormRegister;
        private CustomControls.RJControls.RJButton btnExit;
    }
}