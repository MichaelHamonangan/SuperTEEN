
namespace WinFormsApp1
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
            this.Username = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.Label();
            this.SuperTEEN = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Signin = new System.Windows.Forms.Button();
            this.Signup = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.BackColor = System.Drawing.SystemColors.Window;
            this.Username.Location = new System.Drawing.Point(152, 113);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(96, 23);
            this.Username.TabIndex = 0;
            this.Username.Text = "Username :";
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.BackColor = System.Drawing.SystemColors.Window;
            this.Password.Location = new System.Drawing.Point(159, 163);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(89, 23);
            this.Password.TabIndex = 1;
            this.Password.Text = "Password :";
            // 
            // SuperTEEN
            // 
            this.SuperTEEN.AutoSize = true;
            this.SuperTEEN.BackColor = System.Drawing.Color.Transparent;
            this.SuperTEEN.Font = new System.Drawing.Font("Snap ITC", 13.97015F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SuperTEEN.Location = new System.Drawing.Point(215, 30);
            this.SuperTEEN.Name = "SuperTEEN";
            this.SuperTEEN.Size = new System.Drawing.Size(194, 35);
            this.SuperTEEN.TabIndex = 2;
            this.SuperTEEN.Text = "SuperTEEN";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(255, 113);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(204, 30);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(255, 163);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(204, 30);
            this.textBox2.TabIndex = 4;
            // 
            // Signin
            // 
            this.Signin.BackColor = System.Drawing.Color.DarkCyan;
            this.Signin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Signin.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Signin.Location = new System.Drawing.Point(152, 244);
            this.Signin.Name = "Signin";
            this.Signin.Size = new System.Drawing.Size(105, 32);
            this.Signin.TabIndex = 5;
            this.Signin.Text = "Login";
            this.Signin.UseVisualStyleBackColor = false;
            this.Signin.Click += new System.EventHandler(this.Signin_Click);
            this.Signin.MouseLeave += new System.EventHandler(this.Signin_MouseLeave);
            this.Signin.MouseHover += new System.EventHandler(this.Signin_MouseHover);
            // 
            // Signup
            // 
            this.Signup.BackColor = System.Drawing.Color.DarkCyan;
            this.Signup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Signup.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Signup.Location = new System.Drawing.Point(354, 244);
            this.Signup.Name = "Signup";
            this.Signup.Size = new System.Drawing.Size(105, 32);
            this.Signup.TabIndex = 6;
            this.Signup.Text = "Sign Up";
            this.Signup.UseVisualStyleBackColor = false;
            this.Signup.Click += new System.EventHandler(this.Signup_Click);
            this.Signup.MouseLeave += new System.EventHandler(this.Signup_MouseLeave);
            this.Signup.MouseHover += new System.EventHandler(this.Signup_MouseHover);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WinFormsApp1.Properties.Resources.e77ec7693867e901290ce8d2b3e04f1c;
            this.ClientSize = new System.Drawing.Size(625, 318);
            this.Controls.Add(this.Signup);
            this.Controls.Add(this.Signin);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.SuperTEEN);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Username);
            this.Name = "FormLogin";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.Label SuperTEEN;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button Signin;
        private System.Windows.Forms.Button Signup;
    }
}

