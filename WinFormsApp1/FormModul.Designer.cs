
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
            this.lblTextelamatDatang = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.Judul = new System.Windows.Forms.Label();
            this.lblTextLevel = new System.Windows.Forms.Label();
            this.btnKesehatan = new System.Windows.Forms.Button();
            this.btnBelajar = new System.Windows.Forms.Button();
            this.btnMotivasi = new System.Windows.Forms.Button();
            this.lblLevel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTextelamatDatang
            // 
            this.lblTextelamatDatang.AutoSize = true;
            this.lblTextelamatDatang.BackColor = System.Drawing.Color.Transparent;
            this.lblTextelamatDatang.Font = new System.Drawing.Font("STCaiyun", 13.97015F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTextelamatDatang.Location = new System.Drawing.Point(809, 32);
            this.lblTextelamatDatang.Name = "lblTextelamatDatang";
            this.lblTextelamatDatang.Size = new System.Drawing.Size(221, 28);
            this.lblTextelamatDatang.TabIndex = 0;
            this.lblTextelamatDatang.Text = "Selamat Datang";
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
            // lblTextLevel
            // 
            this.lblTextLevel.AutoSize = true;
            this.lblTextLevel.BackColor = System.Drawing.Color.Transparent;
            this.lblTextLevel.Font = new System.Drawing.Font("STCaiyun", 13.97015F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTextLevel.Location = new System.Drawing.Point(28, 33);
            this.lblTextLevel.Name = "lblTextLevel";
            this.lblTextLevel.Size = new System.Drawing.Size(74, 28);
            this.lblTextLevel.TabIndex = 3;
            this.lblTextLevel.Text = "Level";
            // 
            // btnKesehatan
            // 
            this.btnKesehatan.BackColor = System.Drawing.Color.Red;
            this.btnKesehatan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKesehatan.Font = new System.Drawing.Font("Segoe UI", 11.8209F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnKesehatan.ForeColor = System.Drawing.Color.Snow;
            this.btnKesehatan.Location = new System.Drawing.Point(332, 151);
            this.btnKesehatan.Name = "btnKesehatan";
            this.btnKesehatan.Size = new System.Drawing.Size(351, 100);
            this.btnKesehatan.TabIndex = 4;
            this.btnKesehatan.Text = "MODUL KESEHATAN";
            this.btnKesehatan.UseVisualStyleBackColor = false;
            this.btnKesehatan.Click += new System.EventHandler(this.btnKesehatan_Click);
            this.btnKesehatan.MouseLeave += new System.EventHandler(this.btnKesehatan_MouseLeave);
            this.btnKesehatan.MouseHover += new System.EventHandler(this.btnKesehatan_MouseHover);
            // 
            // btnBelajar
            // 
            this.btnBelajar.BackColor = System.Drawing.Color.Teal;
            this.btnBelajar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBelajar.Font = new System.Drawing.Font("Segoe UI", 11.8209F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBelajar.ForeColor = System.Drawing.Color.Azure;
            this.btnBelajar.Location = new System.Drawing.Point(332, 289);
            this.btnBelajar.Name = "btnBelajar";
            this.btnBelajar.Size = new System.Drawing.Size(351, 100);
            this.btnBelajar.TabIndex = 5;
            this.btnBelajar.Text = "MODUL BELAJAR";
            this.btnBelajar.UseVisualStyleBackColor = false;
            this.btnBelajar.Click += new System.EventHandler(this.btnBelajar_Click);
            this.btnBelajar.MouseLeave += new System.EventHandler(this.btnBelajar_MouseLeave);
            this.btnBelajar.MouseHover += new System.EventHandler(this.btnBelajar_MouseHover);
            // 
            // btnMotivasi
            // 
            this.btnMotivasi.BackColor = System.Drawing.Color.Blue;
            this.btnMotivasi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMotivasi.Font = new System.Drawing.Font("Segoe UI", 11.8209F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMotivasi.ForeColor = System.Drawing.Color.LightCyan;
            this.btnMotivasi.Location = new System.Drawing.Point(332, 423);
            this.btnMotivasi.Name = "btnMotivasi";
            this.btnMotivasi.Size = new System.Drawing.Size(351, 100);
            this.btnMotivasi.TabIndex = 6;
            this.btnMotivasi.Text = "MODUL MOTIVASI";
            this.btnMotivasi.UseVisualStyleBackColor = false;
            this.btnMotivasi.Click += new System.EventHandler(this.btnMotivasi_Click);
            this.btnMotivasi.MouseLeave += new System.EventHandler(this.btnMotivasi_MouseLeave);
            this.btnMotivasi.MouseHover += new System.EventHandler(this.btnMotivasi_MouseHover);
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
            this.Controls.Add(this.btnMotivasi);
            this.Controls.Add(this.btnBelajar);
            this.Controls.Add(this.btnKesehatan);
            this.Controls.Add(this.lblTextLevel);
            this.Controls.Add(this.Judul);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblTextelamatDatang);
            this.Name = "FormModul";
            this.Text = "Modul";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSelamatDatang;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label Judul;
        private System.Windows.Forms.Label lblTextLevel;
        private System.Windows.Forms.Button modulKesehatan;
        private System.Windows.Forms.Button modulBelajar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button modulMotivasi;
        private System.Windows.Forms.Button mdlMotivasi;
        private System.Windows.Forms.Button btnBelajar;
        private System.Windows.Forms.Button btnKesehatan;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.Button btnMotivasi;
        private System.Windows.Forms.Label lblTextelamatDatang;
    }
}