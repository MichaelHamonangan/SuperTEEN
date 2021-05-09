
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
            this.lblKategori = new System.Windows.Forms.Label();
            this.cbNamaModul = new System.Windows.Forms.ComboBox();
            this.lblPilih = new System.Windows.Forms.Label();
            this.btnJalankan = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblKategori
            // 
            this.lblKategori.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblKategori.Font = new System.Drawing.Font("Segoe UI", 16.1194F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKategori.Location = new System.Drawing.Point(0, 0);
            this.lblKategori.Name = "lblKategori";
            this.lblKategori.Size = new System.Drawing.Size(521, 47);
            this.lblKategori.TabIndex = 0;
            this.lblKategori.Text = "Kategori";
            this.lblKategori.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cbNamaModul
            // 
            this.cbNamaModul.FormattingEnabled = true;
            this.cbNamaModul.Location = new System.Drawing.Point(138, 88);
            this.cbNamaModul.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbNamaModul.Name = "cbNamaModul";
            this.cbNamaModul.Size = new System.Drawing.Size(232, 24);
            this.cbNamaModul.Sorted = true;
            this.cbNamaModul.TabIndex = 1;
            // 
            // lblPilih
            // 
            this.lblPilih.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.134328F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPilih.Location = new System.Drawing.Point(119, 57);
            this.lblPilih.Name = "lblPilih";
            this.lblPilih.Size = new System.Drawing.Size(278, 20);
            this.lblPilih.TabIndex = 2;
            this.lblPilih.Text = "Pilih salah satu modul yang tersedia";
            // 
            // btnJalankan
            // 
            this.btnJalankan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.059701F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJalankan.Location = new System.Drawing.Point(93, 202);
            this.btnJalankan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnJalankan.Name = "btnJalankan";
            this.btnJalankan.Size = new System.Drawing.Size(93, 30);
            this.btnJalankan.TabIndex = 3;
            this.btnJalankan.Text = "Jalankan";
            this.btnJalankan.UseVisualStyleBackColor = true;
            this.btnJalankan.Click += new System.EventHandler(this.btnJalankan_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.059701F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(329, 202);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(93, 30);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // FormKategori
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 257);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnJalankan);
            this.Controls.Add(this.lblPilih);
            this.Controls.Add(this.cbNamaModul);
            this.Controls.Add(this.lblKategori);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormKategori";
            this.Text = "Kategori";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblKategori;
        private System.Windows.Forms.ComboBox cbNamaModul;
        private System.Windows.Forms.Label lblPilih;
        private System.Windows.Forms.Button btnJalankan;
        private System.Windows.Forms.Button btnBack;
    }
}