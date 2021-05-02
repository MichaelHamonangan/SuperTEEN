
namespace WinFormsApp1
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
            this.lblKategori.AutoSize = true;
            this.lblKategori.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblKategori.Font = new System.Drawing.Font("Segoe UI", 18.26866F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblKategori.Location = new System.Drawing.Point(0, 0);
            this.lblKategori.Name = "lblKategori";
            this.lblKategori.Size = new System.Drawing.Size(162, 47);
            this.lblKategori.TabIndex = 0;
            this.lblKategori.Text = "Kategori";
            // 
            // cbNamaModul
            // 
            this.cbNamaModul.FormattingEnabled = true;
            this.cbNamaModul.Location = new System.Drawing.Point(155, 126);
            this.cbNamaModul.Name = "cbNamaModul";
            this.cbNamaModul.Size = new System.Drawing.Size(261, 31);
            this.cbNamaModul.TabIndex = 1;
            // 
            // lblPilih
            // 
            this.lblPilih.AutoSize = true;
            this.lblPilih.Location = new System.Drawing.Point(145, 82);
            this.lblPilih.Name = "lblPilih";
            this.lblPilih.Size = new System.Drawing.Size(284, 23);
            this.lblPilih.TabIndex = 2;
            this.lblPilih.Text = "Pilih salah satu modul yang tersedia";
            // 
            // btnJalankan
            // 
            this.btnJalankan.Location = new System.Drawing.Point(105, 291);
            this.btnJalankan.Name = "btnJalankan";
            this.btnJalankan.Size = new System.Drawing.Size(105, 32);
            this.btnJalankan.TabIndex = 3;
            this.btnJalankan.Text = "Jalankan";
            this.btnJalankan.UseVisualStyleBackColor = true;
            this.btnJalankan.Click += new System.EventHandler(this.btnJalankan_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(370, 291);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(105, 32);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // FormKategori
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 352);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnJalankan);
            this.Controls.Add(this.lblPilih);
            this.Controls.Add(this.cbNamaModul);
            this.Controls.Add(this.lblKategori);
            this.Name = "FormKategori";
            this.Text = "Kategori";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKategori;
        private System.Windows.Forms.ComboBox cbNamaModul;
        private System.Windows.Forms.Label lblPilih;
        private System.Windows.Forms.Button btnJalankan;
        private System.Windows.Forms.Button btnBack;
    }
}