
namespace SuperTEEN
{
    partial class FormRunMotivasi
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
            this.btnSelesai = new System.Windows.Forms.Button();
            this.rtbIsi = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // lblNamaModul
            // 
            this.lblNamaModul.AutoEllipsis = true;
            this.lblNamaModul.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblNamaModul.Font = new System.Drawing.Font("Segoe UI", 13.97015F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNamaModul.Location = new System.Drawing.Point(0, 0);
            this.lblNamaModul.Name = "lblNamaModul";
            this.lblNamaModul.Size = new System.Drawing.Size(711, 36);
            this.lblNamaModul.TabIndex = 3;
            this.lblNamaModul.Text = "Nama Modul";
            this.lblNamaModul.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblTask
            // 
            this.lblTask.AutoEllipsis = true;
            this.lblTask.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTask.Font = new System.Drawing.Font("Segoe UI", 10.74627F);
            this.lblTask.Location = new System.Drawing.Point(0, 36);
            this.lblTask.Name = "lblTask";
            this.lblTask.Padding = new System.Windows.Forms.Padding(0, 14, 0, 0);
            this.lblTask.Size = new System.Drawing.Size(711, 326);
            this.lblTask.TabIndex = 4;
            this.lblTask.Text = "Task";
            this.lblTask.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnSelesai
            // 
            this.btnSelesai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.134328F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelesai.Location = new System.Drawing.Point(299, 312);
            this.btnSelesai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSelesai.Name = "btnSelesai";
            this.btnSelesai.Size = new System.Drawing.Size(93, 39);
            this.btnSelesai.TabIndex = 5;
            this.btnSelesai.Text = "Selesai";
            this.btnSelesai.UseVisualStyleBackColor = true;
            this.btnSelesai.Click += new System.EventHandler(this.btnSelesai_Click);
            // 
            // rtbIsi
            // 
            this.rtbIsi.Location = new System.Drawing.Point(36, 93);
            this.rtbIsi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rtbIsi.Name = "rtbIsi";
            this.rtbIsi.Size = new System.Drawing.Size(644, 215);
            this.rtbIsi.TabIndex = 6;
            this.rtbIsi.Text = "";
            // 
            // FormRunMotivasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 362);
            this.Controls.Add(this.rtbIsi);
            this.Controls.Add(this.btnSelesai);
            this.Controls.Add(this.lblTask);
            this.Controls.Add(this.lblNamaModul);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormRunMotivasi";
            this.Text = "Jalankan Modul";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblNamaModul;
        private System.Windows.Forms.Label lblTask;
        private System.Windows.Forms.Button btnSelesai;
        private System.Windows.Forms.RichTextBox rtbIsi;
        private System.Windows.Forms.Button Selesai;
    }
}