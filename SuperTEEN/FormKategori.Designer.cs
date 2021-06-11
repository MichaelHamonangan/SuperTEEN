
namespace SuperTEEN
{
    partial class FormKategori
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormKategori));
            this.lblKategori = new System.Windows.Forms.Label();
            this.cbNamaModul = new System.Windows.Forms.ComboBox();
            this.btnJalankan = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblPilih = new System.Windows.Forms.Label();
            this.lblDurasi = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblDetik = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblKategori
            // 
            this.lblKategori.BackColor = System.Drawing.Color.Transparent;
            this.lblKategori.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblKategori.Font = new System.Drawing.Font("Segoe UI", 16.1194F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKategori.Location = new System.Drawing.Point(0, 0);
            this.lblKategori.MaximumSize = new System.Drawing.Size(521, 47);
            this.lblKategori.MinimumSize = new System.Drawing.Size(521, 47);
            this.lblKategori.Name = "lblKategori";
            this.lblKategori.Size = new System.Drawing.Size(521, 47);
            this.lblKategori.TabIndex = 0;
            this.lblKategori.Text = "Kategori";
            this.lblKategori.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cbNamaModul
            // 
            this.cbNamaModul.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.134328F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNamaModul.FormattingEnabled = true;
            this.cbNamaModul.Location = new System.Drawing.Point(140, 88);
            this.cbNamaModul.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbNamaModul.Name = "cbNamaModul";
            this.cbNamaModul.Size = new System.Drawing.Size(232, 28);
            this.cbNamaModul.Sorted = true;
            this.cbNamaModul.TabIndex = 1;
            this.cbNamaModul.SelectionChangeCommitted += new System.EventHandler(this.cbNamaModul_SelectionChangeCommitted);
            // 
            // btnJalankan
            // 
            this.btnJalankan.BackColor = System.Drawing.Color.DarkCyan;
            this.btnJalankan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnJalankan.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnJalankan.Font = new System.Drawing.Font("Garamond", 10.20895F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJalankan.ForeColor = System.Drawing.SystemColors.Window;
            this.btnJalankan.Location = new System.Drawing.Point(93, 202);
            this.btnJalankan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnJalankan.Name = "btnJalankan";
            this.btnJalankan.Size = new System.Drawing.Size(101, 30);
            this.btnJalankan.TabIndex = 3;
            this.btnJalankan.Text = "Jalankan";
            this.btnJalankan.UseVisualStyleBackColor = false;
            this.btnJalankan.Click += new System.EventHandler(this.btnJalankan_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.DarkCyan;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBack.Font = new System.Drawing.Font("Garamond", 10.20895F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.SystemColors.Window;
            this.btnBack.Location = new System.Drawing.Point(329, 202);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(100, 30);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblPilih
            // 
            this.lblPilih.AutoSize = true;
            this.lblPilih.BackColor = System.Drawing.Color.Transparent;
            this.lblPilih.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.20895F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPilih.Location = new System.Drawing.Point(156, 51);
            this.lblPilih.Name = "lblPilih";
            this.lblPilih.Size = new System.Drawing.Size(201, 24);
            this.lblPilih.TabIndex = 5;
            this.lblPilih.Text = "Pilih salah satu modul :";
            // 
            // lblDurasi
            // 
            this.lblDurasi.BackColor = System.Drawing.Color.Transparent;
            this.lblDurasi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.134328F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDurasi.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblDurasi.Location = new System.Drawing.Point(156, 127);
            this.lblDurasi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDurasi.Name = "lblDurasi";
            this.lblDurasi.Size = new System.Drawing.Size(148, 28);
            this.lblDurasi.TabIndex = 6;
            this.lblDurasi.Text = "Total durasi :";
            // 
            // lblTime
            // 
            this.lblTime.BackColor = System.Drawing.Color.Transparent;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.20895F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblTime.Location = new System.Drawing.Point(266, 125);
            this.lblTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(56, 26);
            this.lblTime.TabIndex = 8;
            // 
            // lblDetik
            // 
            this.lblDetik.BackColor = System.Drawing.Color.Transparent;
            this.lblDetik.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.134328F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetik.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblDetik.Location = new System.Drawing.Point(312, 127);
            this.lblDetik.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDetik.Name = "lblDetik";
            this.lblDetik.Size = new System.Drawing.Size(56, 26);
            this.lblDetik.TabIndex = 9;
            this.lblDetik.Text = "detik";
            // 
            // FormKategori
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(134F, 134F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImage = global::SuperTEEN.Properties.Resources.wp3687982;
            this.ClientSize = new System.Drawing.Size(521, 257);
            this.Controls.Add(this.lblDetik);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblDurasi);
            this.Controls.Add(this.lblPilih);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnJalankan);
            this.Controls.Add(this.cbNamaModul);
            this.Controls.Add(this.lblKategori);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(541, 309);
            this.MinimumSize = new System.Drawing.Size(541, 309);
            this.Name = "FormKategori";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kategori";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKategori;
        private System.Windows.Forms.ComboBox cbNamaModul;
        private System.Windows.Forms.Button btnJalankan;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblPilih;
        private System.Windows.Forms.Label lblDurasi;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblDetik;
    }
}