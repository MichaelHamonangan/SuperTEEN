
namespace SuperTEEN
{
    partial class FormRunModul
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
            this.lblTask = new System.Windows.Forms.Label();
            this.btnJalankan = new System.Windows.Forms.Button();
            this.lblDurasi = new System.Windows.Forms.Label();
            this.lblDetik = new System.Windows.Forms.Label();
            this.lblNamaModul = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTask
            // 
            this.lblTask.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTask.Font = new System.Drawing.Font("Segoe UI", 10.74627F);
            this.lblTask.Location = new System.Drawing.Point(0, 0);
            this.lblTask.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTask.Name = "lblTask";
            this.lblTask.Padding = new System.Windows.Forms.Padding(0, 80, 0, 0);
            this.lblTask.Size = new System.Drawing.Size(855, 353);
            this.lblTask.TabIndex = 2;
            this.lblTask.Text = "Task yang harus dikerjakan akan tertampil di sini";
            this.lblTask.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnJalankan
            // 
            this.btnJalankan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.134328F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJalankan.Location = new System.Drawing.Point(376, 290);
            this.btnJalankan.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnJalankan.Name = "btnJalankan";
            this.btnJalankan.Size = new System.Drawing.Size(116, 32);
            this.btnJalankan.TabIndex = 3;
            this.btnJalankan.Text = "Jalankan";
            this.btnJalankan.UseVisualStyleBackColor = true;
            this.btnJalankan.Click += new System.EventHandler(this.btnJalankan_Click);
            // 
            // lblDurasi
            // 
            this.lblDurasi.AutoSize = true;
            this.lblDurasi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.20895F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDurasi.Location = new System.Drawing.Point(308, 199);
            this.lblDurasi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDurasi.Name = "lblDurasi";
            this.lblDurasi.Size = new System.Drawing.Size(119, 24);
            this.lblDurasi.TabIndex = 4;
            this.lblDurasi.Text = "Total Durasi :";
            // 
            // lblDetik
            // 
            this.lblDetik.AutoSize = true;
            this.lblDetik.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.20895F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetik.Location = new System.Drawing.Point(469, 199);
            this.lblDetik.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDetik.Name = "lblDetik";
            this.lblDetik.Size = new System.Drawing.Size(51, 24);
            this.lblDetik.TabIndex = 5;
            this.lblDetik.Text = "Detik";
            // 
            // lblNamaModul
            // 
            this.lblNamaModul.AutoEllipsis = true;
            this.lblNamaModul.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblNamaModul.Font = new System.Drawing.Font("Segoe UI", 13.97015F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNamaModul.Location = new System.Drawing.Point(0, 0);
            this.lblNamaModul.Name = "lblNamaModul";
            this.lblNamaModul.Size = new System.Drawing.Size(855, 36);
            this.lblNamaModul.TabIndex = 6;
            this.lblNamaModul.Text = "Nama Modul";
            this.lblNamaModul.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.20895F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(427, 199);
            this.lblTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(30, 24);
            this.lblTime.TabIndex = 7;
            this.lblTime.Text = "xx";
            // 
            // FormRunModul
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 353);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblNamaModul);
            this.Controls.Add(this.lblDetik);
            this.Controls.Add(this.lblDurasi);
            this.Controls.Add(this.btnJalankan);
            this.Controls.Add(this.lblTask);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.134328F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Name = "FormRunModul";
            this.Text = "Jalankan Modul";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTask;
        private System.Windows.Forms.Button btnJalankan;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.Label lblDetik;
        private System.Windows.Forms.Label lblDurasi;
        private System.Windows.Forms.Label lblNamaModul;
        private System.Windows.Forms.Label lblTime;
    }
}