
namespace WinFormsApp1
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
            this.lblNamaModul = new System.Windows.Forms.Label();
            this.lblTask = new System.Windows.Forms.Label();
            this.btnJalankan = new System.Windows.Forms.Button();
            this.lblDurasi = new System.Windows.Forms.Label();
            this.lblDetik = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNamaModul
            // 
            this.lblNamaModul.AutoSize = true;
            this.lblNamaModul.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblNamaModul.Font = new System.Drawing.Font("Segoe UI", 16.1194F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNamaModul.Location = new System.Drawing.Point(0, 0);
            this.lblNamaModul.Name = "lblNamaModul";
            this.lblNamaModul.Size = new System.Drawing.Size(202, 41);
            this.lblNamaModul.TabIndex = 1;
            this.lblNamaModul.Text = "Nama Modul";
            // 
            // lblTask
            // 
            this.lblTask.AutoSize = true;
            this.lblTask.Font = new System.Drawing.Font("Segoe UI", 10.74627F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTask.Location = new System.Drawing.Point(363, 79);
            this.lblTask.Name = "lblTask";
            this.lblTask.Size = new System.Drawing.Size(52, 30);
            this.lblTask.TabIndex = 2;
            this.lblTask.Text = "Task";
            // 
            // btnJalankan
            // 
            this.btnJalankan.Location = new System.Drawing.Point(341, 293);
            this.btnJalankan.Name = "btnJalankan";
            this.btnJalankan.Size = new System.Drawing.Size(105, 32);
            this.btnJalankan.TabIndex = 3;
            this.btnJalankan.Text = "Jalankan";
            this.btnJalankan.UseVisualStyleBackColor = true;
            this.btnJalankan.Click += new System.EventHandler(this.btnJalankan_Click);
            // 
            // lblDurasi
            // 
            this.lblDurasi.AutoSize = true;
            this.lblDurasi.Location = new System.Drawing.Point(324, 219);
            this.lblDurasi.Name = "lblDurasi";
            this.lblDurasi.Size = new System.Drawing.Size(58, 23);
            this.lblDurasi.TabIndex = 4;
            this.lblDurasi.Text = "Durasi";
            // 
            // lblDetik
            // 
            this.lblDetik.AutoSize = true;
            this.lblDetik.Location = new System.Drawing.Point(412, 219);
            this.lblDetik.Name = "lblDetik";
            this.lblDetik.Size = new System.Drawing.Size(49, 23);
            this.lblDetik.TabIndex = 5;
            this.lblDetik.Text = "Detik";
            // 
            // FormRunModul
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 348);
            this.Controls.Add(this.lblDetik);
            this.Controls.Add(this.lblDurasi);
            this.Controls.Add(this.btnJalankan);
            this.Controls.Add(this.lblTask);
            this.Controls.Add(this.lblNamaModul);
            this.Name = "FormRunModul";
            this.Text = "Jalankan Modul";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNamaModul;
        private System.Windows.Forms.Label lblTask;
        private System.Windows.Forms.Button btnJalankan;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.Label lblDetik;
        private System.Windows.Forms.Label lblDurasi;
    }
}