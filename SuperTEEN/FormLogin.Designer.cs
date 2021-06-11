
namespace SuperTEEN
{
    partial class FormLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.Username = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.Label();
            this.SuperTEEN = new System.Windows.Forms.Label();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.cbShow = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.BackColor = System.Drawing.SystemColors.Window;
            this.Username.Font = new System.Drawing.Font("Segoe UI", 9.134328F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username.Location = new System.Drawing.Point(100, 104);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(96, 23);
            this.Username.TabIndex = 0;
            this.Username.Text = "Username :";
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.BackColor = System.Drawing.SystemColors.Window;
            this.Password.Font = new System.Drawing.Font("Segoe UI", 9.134328F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password.Location = new System.Drawing.Point(107, 162);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(89, 23);
            this.Password.TabIndex = 1;
            this.Password.Text = "Password :";
            // 
            // SuperTEEN
            // 
            this.SuperTEEN.AutoSize = true;
            this.SuperTEEN.BackColor = System.Drawing.Color.Transparent;
            this.SuperTEEN.Font = new System.Drawing.Font("Snap ITC", 13.97015F);
            this.SuperTEEN.Location = new System.Drawing.Point(205, 25);
            this.SuperTEEN.Name = "SuperTEEN";
            this.SuperTEEN.Size = new System.Drawing.Size(194, 35);
            this.SuperTEEN.TabIndex = 2;
            this.SuperTEEN.Text = "SuperTEEN";
            // 
            // tbUsername
            // 
            this.tbUsername.Font = new System.Drawing.Font("Nirmala UI", 8.059701F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUsername.Location = new System.Drawing.Point(227, 103);
            this.tbUsername.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(235, 27);
            this.tbUsername.TabIndex = 3;
            // 
            // tbPassword
            // 
            this.tbPassword.Font = new System.Drawing.Font("Nirmala UI", 8.059701F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPassword.Location = new System.Drawing.Point(227, 162);
            this.tbPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(235, 27);
            this.tbPassword.TabIndex = 4;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.DarkCyan;
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogin.Font = new System.Drawing.Font("Harrington", 9.134328F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnLogin.Location = new System.Drawing.Point(124, 245);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(0);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(93, 34);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            this.btnLogin.MouseLeave += new System.EventHandler(this.btnLogin_MouseLeave);
            this.btnLogin.MouseHover += new System.EventHandler(this.btnLogin_MouseHover);
            // 
            // btnSignUp
            // 
            this.btnSignUp.BackColor = System.Drawing.Color.DarkCyan;
            this.btnSignUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSignUp.Font = new System.Drawing.Font("Harrington", 9.134328F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignUp.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnSignUp.Location = new System.Drawing.Point(370, 245);
            this.btnSignUp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(93, 34);
            this.btnSignUp.TabIndex = 6;
            this.btnSignUp.Text = "Sign Up";
            this.btnSignUp.UseVisualStyleBackColor = false;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            this.btnSignUp.MouseLeave += new System.EventHandler(this.btnSignUp_MouseLeave);
            this.btnSignUp.MouseHover += new System.EventHandler(this.btnSignUp_MouseHover);
            // 
            // cbShow
            // 
            this.cbShow.AutoSize = true;
            this.cbShow.BackColor = System.Drawing.Color.Transparent;
            this.cbShow.Location = new System.Drawing.Point(484, 167);
            this.cbShow.Name = "cbShow";
            this.cbShow.Size = new System.Drawing.Size(63, 20);
            this.cbShow.TabIndex = 7;
            this.cbShow.Text = "Show";
            this.cbShow.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.cbShow.UseVisualStyleBackColor = false;
            this.cbShow.CheckStateChanged += new System.EventHandler(this.cbShow_CheckStateChanged);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(134F, 134F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(588, 310);
            this.Controls.Add(this.cbShow);
            this.Controls.Add(this.btnSignUp);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbUsername);
            this.Controls.Add(this.SuperTEEN);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Username);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(608, 362);
            this.MinimumSize = new System.Drawing.Size(608, 362);
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.Label SuperTEEN;
        private System.Windows.Forms.TextBox tbUsername;
        //private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnSignUp;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.CheckBox cbShow;
    }
}

