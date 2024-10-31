namespace Try
{
    partial class formChangePassword
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
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNewPassword = new CustomControls.RJControls.RJTextBox();
            this.txtConfirmNewPassword = new CustomControls.RJControls.RJTextBox();
            this.txtCurrentPassword = new CustomControls.RJControls.RJTextBox();
            this.btnChangePassword = new CustomControls.RJControls.RJButton();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(145, 317);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(274, 90);
            this.label3.TabIndex = 45;
            this.label3.Text = "You will be logged out after \r\nsuccessfully changing your \r\npassword.";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 42F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(139, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 64);
            this.label1.TabIndex = 44;
            this.label1.Text = "DocuVault";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Gothic", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(564, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 636);
            this.label2.TabIndex = 46;
            this.label2.Text = "|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n";
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.BackColor = System.Drawing.SystemColors.Window;
            this.txtNewPassword.BorderColor = System.Drawing.Color.White;
            this.txtNewPassword.BorderFocusColor = System.Drawing.Color.White;
            this.txtNewPassword.BorderRadius = 5;
            this.txtNewPassword.BorderSize = 2;
            this.txtNewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNewPassword.Location = new System.Drawing.Point(735, 299);
            this.txtNewPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtNewPassword.Multiline = false;
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtNewPassword.PasswordChar = true;
            this.txtNewPassword.PlaceholderColor = System.Drawing.Color.Black;
            this.txtNewPassword.PlaceholderText = "New Password";
            this.txtNewPassword.Size = new System.Drawing.Size(258, 31);
            this.txtNewPassword.TabIndex = 53;
            this.txtNewPassword.Texts = "";
            this.txtNewPassword.UnderlinedStyle = false;
            // 
            // txtConfirmNewPassword
            // 
            this.txtConfirmNewPassword.BackColor = System.Drawing.SystemColors.Window;
            this.txtConfirmNewPassword.BorderColor = System.Drawing.Color.White;
            this.txtConfirmNewPassword.BorderFocusColor = System.Drawing.Color.White;
            this.txtConfirmNewPassword.BorderRadius = 5;
            this.txtConfirmNewPassword.BorderSize = 2;
            this.txtConfirmNewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmNewPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtConfirmNewPassword.Location = new System.Drawing.Point(735, 338);
            this.txtConfirmNewPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtConfirmNewPassword.Multiline = false;
            this.txtConfirmNewPassword.Name = "txtConfirmNewPassword";
            this.txtConfirmNewPassword.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtConfirmNewPassword.PasswordChar = true;
            this.txtConfirmNewPassword.PlaceholderColor = System.Drawing.Color.Black;
            this.txtConfirmNewPassword.PlaceholderText = "Confirm New Password";
            this.txtConfirmNewPassword.Size = new System.Drawing.Size(258, 31);
            this.txtConfirmNewPassword.TabIndex = 52;
            this.txtConfirmNewPassword.Texts = "";
            this.txtConfirmNewPassword.UnderlinedStyle = false;
            // 
            // txtCurrentPassword
            // 
            this.txtCurrentPassword.BackColor = System.Drawing.SystemColors.Window;
            this.txtCurrentPassword.BorderColor = System.Drawing.Color.White;
            this.txtCurrentPassword.BorderFocusColor = System.Drawing.Color.White;
            this.txtCurrentPassword.BorderRadius = 5;
            this.txtCurrentPassword.BorderSize = 2;
            this.txtCurrentPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurrentPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCurrentPassword.Location = new System.Drawing.Point(735, 260);
            this.txtCurrentPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtCurrentPassword.Multiline = false;
            this.txtCurrentPassword.Name = "txtCurrentPassword";
            this.txtCurrentPassword.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtCurrentPassword.PasswordChar = false;
            this.txtCurrentPassword.PlaceholderColor = System.Drawing.Color.Black;
            this.txtCurrentPassword.PlaceholderText = "Current Password";
            this.txtCurrentPassword.Size = new System.Drawing.Size(258, 31);
            this.txtCurrentPassword.TabIndex = 51;
            this.txtCurrentPassword.Texts = "";
            this.txtCurrentPassword.UnderlinedStyle = false;
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.btnChangePassword.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.btnChangePassword.BorderColor = System.Drawing.Color.Navy;
            this.btnChangePassword.BorderRadius = 5;
            this.btnChangePassword.BorderSize = 0;
            this.btnChangePassword.FlatAppearance.BorderSize = 0;
            this.btnChangePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangePassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangePassword.ForeColor = System.Drawing.Color.White;
            this.btnChangePassword.Location = new System.Drawing.Point(735, 376);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(258, 31);
            this.btnChangePassword.TabIndex = 50;
            this.btnChangePassword.Text = "Change Password";
            this.btnChangePassword.TextColor = System.Drawing.Color.White;
            this.btnChangePassword.UseVisualStyleBackColor = false;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(144, 276);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 31);
            this.label4.TabIndex = 54;
            this.label4.Text = "Note:";
            // 
            // formChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(102)))), ((int)(((byte)(113)))));
            this.ClientSize = new System.Drawing.Size(1138, 711);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNewPassword);
            this.Controls.Add(this.txtConfirmNewPassword);
            this.Controls.Add(this.txtCurrentPassword);
            this.Controls.Add(this.btnChangePassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formChangePassword";
            this.Text = "formChangePassword";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private CustomControls.RJControls.RJTextBox txtNewPassword;
        private CustomControls.RJControls.RJTextBox txtConfirmNewPassword;
        private CustomControls.RJControls.RJTextBox txtCurrentPassword;
        private CustomControls.RJControls.RJButton btnChangePassword;
        private System.Windows.Forms.Label label4;
    }
}