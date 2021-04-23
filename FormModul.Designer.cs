
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
            this.labelnama = new System.Windows.Forms.Label();
            this.Judul = new System.Windows.Forms.Label();
            this.Level = new System.Windows.Forms.Label();
            this.mdlKesehatan = new System.Windows.Forms.Button();
            this.mdlBelajar = new System.Windows.Forms.Button();
            this.mdlMotivasi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.8209F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(843, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Selamat Datang";
            // 
            // labelnama
            // 
            this.labelnama.AutoSize = true;
            this.labelnama.BackColor = System.Drawing.Color.Transparent;
            this.labelnama.Font = new System.Drawing.Font("Sitka Small", 10.74627F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelnama.Location = new System.Drawing.Point(843, 66);
            this.labelnama.Name = "labelnama";
            this.labelnama.Size = new System.Drawing.Size(106, 31);
            this.labelnama.TabIndex = 1;
            this.labelnama.Text = "// Nama";
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
            this.Level.Font = new System.Drawing.Font("Segoe UI", 11.8209F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Level.Location = new System.Drawing.Point(35, 29);
            this.Level.Name = "Level";
            this.Level.Size = new System.Drawing.Size(66, 31);
            this.Level.TabIndex = 3;
            this.Level.Text = "Level";
            // 
            // mdlKesehatan
            // 
            this.mdlKesehatan.BackColor = System.Drawing.Color.Red;
            this.mdlKesehatan.Font = new System.Drawing.Font("Segoe UI", 11.8209F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.mdlKesehatan.ForeColor = System.Drawing.Color.Snow;
            this.mdlKesehatan.Location = new System.Drawing.Point(332, 180);
            this.mdlKesehatan.Name = "mdlKesehatan";
            this.mdlKesehatan.Size = new System.Drawing.Size(351, 100);
            this.mdlKesehatan.TabIndex = 4;
            this.mdlKesehatan.Text = "MODUL KESEHATAN";
            this.mdlKesehatan.UseVisualStyleBackColor = false;
            // 
            // mdlBelajar
            // 
            this.mdlBelajar.BackColor = System.Drawing.Color.Teal;
            this.mdlBelajar.Font = new System.Drawing.Font("Segoe UI", 11.8209F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.mdlBelajar.ForeColor = System.Drawing.Color.Azure;
            this.mdlBelajar.Location = new System.Drawing.Point(332, 319);
            this.mdlBelajar.Name = "mdlBelajar";
            this.mdlBelajar.Size = new System.Drawing.Size(351, 100);
            this.mdlBelajar.TabIndex = 5;
            this.mdlBelajar.Text = "MODUL BELAJAR";
            this.mdlBelajar.UseVisualStyleBackColor = false;
            // 
            // mdlMotivasi
            // 
            this.mdlMotivasi.BackColor = System.Drawing.Color.MediumOrchid;
            this.mdlMotivasi.Font = new System.Drawing.Font("Segoe UI", 11.8209F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.mdlMotivasi.ForeColor = System.Drawing.Color.LightCyan;
            this.mdlMotivasi.Location = new System.Drawing.Point(332, 470);
            this.mdlMotivasi.Name = "mdlMotivasi";
            this.mdlMotivasi.Size = new System.Drawing.Size(351, 100);
            this.mdlMotivasi.TabIndex = 6;
            this.mdlMotivasi.Text = "MODUL MOTIVASI";
            this.mdlMotivasi.UseVisualStyleBackColor = false;
            // 
            // FormModul
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.BackgroundImage = global::WinFormsApp1.Properties.Resources._4mJtkR;
            this.ClientSize = new System.Drawing.Size(1042, 592);
            this.Controls.Add(this.mdlMotivasi);
            this.Controls.Add(this.mdlBelajar);
            this.Controls.Add(this.mdlKesehatan);
            this.Controls.Add(this.Level);
            this.Controls.Add(this.Judul);
            this.Controls.Add(this.labelnama);
            this.Controls.Add(this.label1);
            this.Name = "FormModul";
            this.Text = "MODUL BELAJAR";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelnama;
        private System.Windows.Forms.Label Judul;
        private System.Windows.Forms.Label Level;
        private System.Windows.Forms.Button modulKesehatan;
        private System.Windows.Forms.Button modulBelajar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button modulMotivasi;
        private System.Windows.Forms.Button mdlMotivasi;
        private System.Windows.Forms.Button mdlBelajar;
        private System.Windows.Forms.Button mdlKesehatan;
    }
}