namespace Try
{
    partial class formRegister
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
            this.txtConfirmPassword = new CustomControls.RJControls.RJTextBox();
            this.txtRegisterPassword = new CustomControls.RJControls.RJTextBox();
            this.btnRegister = new CustomControls.RJControls.RJButton();
            this.txtEmail = new CustomControls.RJControls.RJTextBox();
            this.txtRegisterUsername = new CustomControls.RJControls.RJTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFormLogin = new CustomControls.RJControls.RJButton();
            this.SuspendLayout();
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.BackColor = System.Drawing.SystemColors.Window;
            this.txtConfirmPassword.BorderColor = System.Drawing.Color.White;
            this.txtConfirmPassword.BorderFocusColor = System.Drawing.Color.White;
            this.txtConfirmPassword.BorderRadius = 5;
            this.txtConfirmPassword.BorderSize = 2;
            this.txtConfirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtConfirmPassword.Location = new System.Drawing.Point(576, 418);
            this.txtConfirmPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtConfirmPassword.Multiline = false;
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtConfirmPassword.PasswordChar = true;
            this.txtConfirmPassword.PlaceholderColor = System.Drawing.Color.Black;
            this.txtConfirmPassword.PlaceholderText = "Confirm Password";
            this.txtConfirmPassword.Size = new System.Drawing.Size(258, 31);
            this.txtConfirmPassword.TabIndex = 41;
            this.txtConfirmPassword.Texts = "";
            this.txtConfirmPassword.UnderlinedStyle = false;
            // 
            // txtRegisterPassword
            // 
            this.txtRegisterPassword.BackColor = System.Drawing.SystemColors.Window;
            this.txtRegisterPassword.BorderColor = System.Drawing.Color.White;
            this.txtRegisterPassword.BorderFocusColor = System.Drawing.Color.White;
            this.txtRegisterPassword.BorderRadius = 5;
            this.txtRegisterPassword.BorderSize = 2;
            this.txtRegisterPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegisterPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtRegisterPassword.Location = new System.Drawing.Point(576, 379);
            this.txtRegisterPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtRegisterPassword.Multiline = false;
            this.txtRegisterPassword.Name = "txtRegisterPassword";
            this.txtRegisterPassword.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtRegisterPassword.PasswordChar = true;
            this.txtRegisterPassword.PlaceholderColor = System.Drawing.Color.Black;
            this.txtRegisterPassword.PlaceholderText = "Password";
            this.txtRegisterPassword.Size = new System.Drawing.Size(258, 31);
            this.txtRegisterPassword.TabIndex = 40;
            this.txtRegisterPassword.Texts = "";
            this.txtRegisterPassword.UnderlinedStyle = false;
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.btnRegister.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.btnRegister.BorderColor = System.Drawing.Color.Navy;
            this.btnRegister.BorderRadius = 5;
            this.btnRegister.BorderSize = 0;
            this.btnRegister.FlatAppearance.BorderSize = 0;
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.ForeColor = System.Drawing.Color.White;
            this.btnRegister.Location = new System.Drawing.Point(576, 456);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(258, 31);
            this.btnRegister.TabIndex = 39;
            this.btnRegister.Text = "Register";
            this.btnRegister.TextColor = System.Drawing.Color.White;
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.SystemColors.Window;
            this.txtEmail.BorderColor = System.Drawing.Color.White;
            this.txtEmail.BorderFocusColor = System.Drawing.Color.White;
            this.txtEmail.BorderRadius = 5;
            this.txtEmail.BorderSize = 2;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtEmail.Location = new System.Drawing.Point(576, 340);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.Multiline = false;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtEmail.PasswordChar = false;
            this.txtEmail.PlaceholderColor = System.Drawing.Color.Black;
            this.txtEmail.PlaceholderText = "Email";
            this.txtEmail.Size = new System.Drawing.Size(258, 31);
            this.txtEmail.TabIndex = 42;
            this.txtEmail.Texts = "";
            this.txtEmail.UnderlinedStyle = false;
            // 
            // txtRegisterUsername
            // 
            this.txtRegisterUsername.BackColor = System.Drawing.SystemColors.Window;
            this.txtRegisterUsername.BorderColor = System.Drawing.Color.White;
            this.txtRegisterUsername.BorderFocusColor = System.Drawing.Color.White;
            this.txtRegisterUsername.BorderRadius = 5;
            this.txtRegisterUsername.BorderSize = 2;
            this.txtRegisterUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegisterUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtRegisterUsername.Location = new System.Drawing.Point(576, 301);
            this.txtRegisterUsername.Margin = new System.Windows.Forms.Padding(4);
            this.txtRegisterUsername.Multiline = false;
            this.txtRegisterUsername.Name = "txtRegisterUsername";
            this.txtRegisterUsername.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtRegisterUsername.PasswordChar = false;
            this.txtRegisterUsername.PlaceholderColor = System.Drawing.Color.Black;
            this.txtRegisterUsername.PlaceholderText = "Username";
            this.txtRegisterUsername.Size = new System.Drawing.Size(258, 31);
            this.txtRegisterUsername.TabIndex = 43;
            this.txtRegisterUsername.Texts = "";
            this.txtRegisterUsername.UnderlinedStyle = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 50.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(535, 210);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(349, 76);
            this.label1.TabIndex = 44;
            this.label1.Text = "DocuVault";
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
            this.btnFormLogin.TabIndex = 45;
            this.btnFormLogin.Text = "Login";
            this.btnFormLogin.TextColor = System.Drawing.Color.White;
            this.btnFormLogin.UseVisualStyleBackColor = false;
            this.btnFormLogin.Click += new System.EventHandler(this.btnFormLogin_Click);
            // 
            // formRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(102)))), ((int)(((byte)(113)))));
            this.ClientSize = new System.Drawing.Size(1378, 753);
            this.Controls.Add(this.btnFormLogin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRegisterUsername);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtConfirmPassword);
            this.Controls.Add(this.txtRegisterPassword);
            this.Controls.Add(this.btnRegister);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formRegister";
            this.Load += new System.EventHandler(this.formRegister_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomControls.RJControls.RJTextBox txtConfirmPassword;
        private CustomControls.RJControls.RJTextBox txtRegisterPassword;
        private CustomControls.RJControls.RJButton btnRegister;
        private CustomControls.RJControls.RJTextBox txtEmail;
        private CustomControls.RJControls.RJTextBox txtRegisterUsername;
        private System.Windows.Forms.Label label1;
        private CustomControls.RJControls.RJButton btnFormLogin;
    }
}