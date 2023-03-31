namespace BillingApp.UI
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            panel1 = new System.Windows.Forms.Panel();
            btnLogin = new System.Windows.Forms.Button();
            cmb_UserType = new System.Windows.Forms.ComboBox();
            lblUserType = new System.Windows.Forms.Label();
            txt_Password = new System.Windows.Forms.TextBox();
            lblPassword = new System.Windows.Forms.Label();
            txt_Username = new System.Windows.Forms.TextBox();
            lblUsername = new System.Windows.Forms.Label();
            lblHeader = new System.Windows.Forms.Label();
            closeIcon = new System.Windows.Forms.PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)closeIcon).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.White;
            panel1.Controls.Add(btnLogin);
            panel1.Controls.Add(cmb_UserType);
            panel1.Controls.Add(lblUserType);
            panel1.Controls.Add(txt_Password);
            panel1.Controls.Add(lblPassword);
            panel1.Controls.Add(txt_Username);
            panel1.Controls.Add(lblUsername);
            panel1.Controls.Add(lblHeader);
            panel1.Location = new System.Drawing.Point(47, 42);
            panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(437, 725);
            panel1.TabIndex = 0;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = System.Drawing.Color.DarkGreen;
            btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnLogin.ForeColor = System.Drawing.SystemColors.Info;
            btnLogin.Location = new System.Drawing.Point(76, 575);
            btnLogin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new System.Drawing.Size(258, 78);
            btnLogin.TabIndex = 7;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // cmb_UserType
            // 
            cmb_UserType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            cmb_UserType.FormattingEnabled = true;
            cmb_UserType.Items.AddRange(new object[] { "Admin", "User" });
            cmb_UserType.Location = new System.Drawing.Point(76, 471);
            cmb_UserType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            cmb_UserType.Name = "cmb_UserType";
            cmb_UserType.Size = new System.Drawing.Size(258, 28);
            cmb_UserType.TabIndex = 6;
            // 
            // lblUserType
            // 
            lblUserType.AutoSize = true;
            lblUserType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblUserType.Location = new System.Drawing.Point(72, 424);
            lblUserType.Name = "lblUserType";
            lblUserType.Size = new System.Drawing.Size(81, 20);
            lblUserType.TabIndex = 5;
            lblUserType.Text = "UserType";
            // 
            // txt_Password
            // 
            txt_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txt_Password.Location = new System.Drawing.Point(76, 345);
            txt_Password.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txt_Password.Name = "txt_Password";
            txt_Password.PasswordChar = '#';
            txt_Password.Size = new System.Drawing.Size(258, 27);
            txt_Password.TabIndex = 4;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblPassword.Location = new System.Drawing.Point(75, 299);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new System.Drawing.Size(83, 20);
            lblPassword.TabIndex = 3;
            lblPassword.Text = "Password";
            // 
            // txt_Username
            // 
            txt_Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txt_Username.Location = new System.Drawing.Point(76, 230);
            txt_Username.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txt_Username.Name = "txt_Username";
            txt_Username.Size = new System.Drawing.Size(258, 27);
            txt_Username.TabIndex = 2;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblUsername.Location = new System.Drawing.Point(72, 181);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new System.Drawing.Size(86, 20);
            lblUsername.TabIndex = 1;
            lblUsername.Text = "Username";
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblHeader.Location = new System.Drawing.Point(169, 70);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new System.Drawing.Size(92, 29);
            lblHeader.TabIndex = 0;
            lblHeader.Text = "LOGIN";
            // 
            // closeIcon
            // 
            closeIcon.Image = (System.Drawing.Image)resources.GetObject("closeIcon.Image");
            closeIcon.Location = new System.Drawing.Point(503, 5);
            closeIcon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            closeIcon.Name = "closeIcon";
            closeIcon.Size = new System.Drawing.Size(37, 46);
            closeIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            closeIcon.TabIndex = 1;
            closeIcon.TabStop = false;
            closeIcon.Click += closeIcon_Click;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.MediumSeaGreen;
            ClientSize = new System.Drawing.Size(552, 815);
            Controls.Add(closeIcon);
            Controls.Add(panel1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "frmLogin";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "frmLogin";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)closeIcon).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.ComboBox cmb_UserType;
        private System.Windows.Forms.Label lblUserType;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txt_Username;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.PictureBox closeIcon;
    }
}