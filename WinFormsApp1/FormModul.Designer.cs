
namespace WinFormsApp1
{
    partial class FormModul
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
            this.lblUsername = new System.Windows.Forms.Label();
            this.Judul = new System.Windows.Forms.Label();
            this.Level = new System.Windows.Forms.Label();
            this.mdlKesehatan = new System.Windows.Forms.Button();
            this.mdlBelajar = new System.Windows.Forms.Button();
            this.mdlMotivasi = new System.Windows.Forms.Button();
            this.lblLevel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("STCaiyun", 13.97015F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(809, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Selamat Datang";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.BackColor = System.Drawing.Color.Transparent;
            this.lblUsername.Font = new System.Drawing.Font("Sitka Small", 10.74627F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblUsername.Location = new System.Drawing.Point(809, 60);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(106, 31);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "// Nama";
            // 
            // Judul
            // 
            this.Judul.AutoSize = true;
            this.Judul.BackColor = System.Drawing.Color.Transparent;
            this.Judul.Font = new System.Drawing.Font("Snap ITC", 22.02985F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Judul.Location = new System.Drawing.Point(368, 22);
            this.Judul.Name = "Judul";
            this.Judul.Size = new System.Drawing.Size(296, 53);
            this.Judul.TabIndex = 2;
            this.Judul.Text = "SuperTEEN";
            // 
            // Level
            // 
            this.Level.AutoSize = true;
            this.Level.BackColor = System.Drawing.Color.Transparent;
            this.Level.Font = new System.Drawing.Font("STCaiyun", 13.97015F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Level.Location = new System.Drawing.Point(28, 33);
            this.Level.Name = "Level";
            this.Level.Size = new System.Drawing.Size(74, 28);
            this.Level.TabIndex = 3;
            this.Level.Text = "Level";
            // 
            // mdlKesehatan
            // 
            this.mdlKesehatan.BackColor = System.Drawing.Color.Red;
            this.mdlKesehatan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mdlKesehatan.Font = new System.Drawing.Font("Segoe UI", 11.8209F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.mdlKesehatan.ForeColor = System.Drawing.Color.Snow;
            this.mdlKesehatan.Location = new System.Drawing.Point(332, 151);
            this.mdlKesehatan.Name = "mdlKesehatan";
            this.mdlKesehatan.Size = new System.Drawing.Size(351, 100);
            this.mdlKesehatan.TabIndex = 4;
            this.mdlKesehatan.Text = "MODUL KESEHATAN";
            this.mdlKesehatan.UseVisualStyleBackColor = false;
            this.mdlKesehatan.MouseLeave += new System.EventHandler(this.mdlKesehatan_MouseLeave);
            this.mdlKesehatan.MouseHover += new System.EventHandler(this.mdlKesehatan_MouseHover);
            // 
            // mdlBelajar
            // 
            this.mdlBelajar.BackColor = System.Drawing.Color.Teal;
            this.mdlBelajar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mdlBelajar.Font = new System.Drawing.Font("Segoe UI", 11.8209F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.mdlBelajar.ForeColor = System.Drawing.Color.Azure;
            this.mdlBelajar.Location = new System.Drawing.Point(332, 289);
            this.mdlBelajar.Name = "mdlBelajar";
            this.mdlBelajar.Size = new System.Drawing.Size(351, 100);
            this.mdlBelajar.TabIndex = 5;
            this.mdlBelajar.Text = "MODUL BELAJAR";
            this.mdlBelajar.UseVisualStyleBackColor = false;
            this.mdlBelajar.MouseLeave += new System.EventHandler(this.mdlBelajar_MouseLeave);
            this.mdlBelajar.MouseHover += new System.EventHandler(this.mdlBelajar_MouseHover);
            // 
            // mdlMotivasi
            // 
            this.mdlMotivasi.BackColor = System.Drawing.Color.Blue;
            this.mdlMotivasi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mdlMotivasi.Font = new System.Drawing.Font("Segoe UI", 11.8209F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.mdlMotivasi.ForeColor = System.Drawing.Color.LightCyan;
            this.mdlMotivasi.Location = new System.Drawing.Point(332, 423);
            this.mdlMotivasi.Name = "mdlMotivasi";
            this.mdlMotivasi.Size = new System.Drawing.Size(351, 100);
            this.mdlMotivasi.TabIndex = 6;
            this.mdlMotivasi.Text = "MODUL MOTIVASI";
            this.mdlMotivasi.UseVisualStyleBackColor = false;
            this.mdlMotivasi.MouseLeave += new System.EventHandler(this.mdlMotivasi_MouseLeave);
            this.mdlMotivasi.MouseHover += new System.EventHandler(this.mdlMotivasi_MouseHover);
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.BackColor = System.Drawing.Color.Transparent;
            this.lblLevel.Font = new System.Drawing.Font("Showcard Gothic", 16.1194F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLevel.Location = new System.Drawing.Point(101, 23);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(43, 37);
            this.lblLevel.TabIndex = 7;
            this.lblLevel.Text = "//";
            // 
            // FormModul
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.BackgroundImage = global::WinFormsApp1.Properties.Resources._4mJtkR;
            this.ClientSize = new System.Drawing.Size(1042, 540);
            this.Controls.Add(this.lblLevel);
            this.Controls.Add(this.mdlMotivasi);
            this.Controls.Add(this.mdlBelajar);
            this.Controls.Add(this.mdlKesehatan);
            this.Controls.Add(this.Level);
            this.Controls.Add(this.Judul);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.label1);
            this.Name = "FormModul";
            this.Text = "MODUL BELAJAR";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label Judul;
        private System.Windows.Forms.Label Level;
        private System.Windows.Forms.Button modulKesehatan;
        private System.Windows.Forms.Button modulBelajar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button modulMotivasi;
        private System.Windows.Forms.Button mdlMotivasi;
        private System.Windows.Forms.Button mdlBelajar;
        private System.Windows.Forms.Button mdlKesehatan;
        private System.Windows.Forms.Label lblLevel;
    }
}