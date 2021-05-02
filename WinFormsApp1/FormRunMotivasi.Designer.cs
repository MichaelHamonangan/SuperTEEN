
namespace WinFormsApp1
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
            this.lblNamaModul.AutoSize = true;
            this.lblNamaModul.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblNamaModul.Font = new System.Drawing.Font("Segoe UI", 16.1194F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNamaModul.Location = new System.Drawing.Point(0, 0);
            this.lblNamaModul.Name = "lblNamaModul";
            this.lblNamaModul.Size = new System.Drawing.Size(202, 41);
            this.lblNamaModul.TabIndex = 3;
            this.lblNamaModul.Text = "Nama Modul";
            // 
            // lblTask
            // 
            this.lblTask.AutoSize = true;
            this.lblTask.Font = new System.Drawing.Font("Segoe UI", 10.74627F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTask.Location = new System.Drawing.Point(362, 89);
            this.lblTask.Name = "lblTask";
            this.lblTask.Size = new System.Drawing.Size(52, 30);
            this.lblTask.TabIndex = 4;
            this.lblTask.Text = "Task";
            // 
            // btnSelesai
            // 
            this.btnSelesai.Location = new System.Drawing.Point(337, 390);
            this.btnSelesai.Name = "btnSelesai";
            this.btnSelesai.Size = new System.Drawing.Size(105, 32);
            this.btnSelesai.TabIndex = 5;
            this.btnSelesai.Text = "Selesai";
            this.btnSelesai.UseVisualStyleBackColor = true;
            this.btnSelesai.Click += new System.EventHandler(this.btnSelesai_Click);
            // 
            // rtbIsi
            // 
            this.rtbIsi.Location = new System.Drawing.Point(43, 182);
            this.rtbIsi.Name = "rtbIsi";
            this.rtbIsi.Size = new System.Drawing.Size(706, 178);
            this.rtbIsi.TabIndex = 6;
            this.rtbIsi.Text = "";
            // 
            // FormRunMotivasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rtbIsi);
            this.Controls.Add(this.btnSelesai);
            this.Controls.Add(this.lblTask);
            this.Controls.Add(this.lblNamaModul);
            this.Name = "FormRunMotivasi";
            this.Text = "Jalankan Modul";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNamaModul;
        private System.Windows.Forms.Label lblTask;
        private System.Windows.Forms.Button btnSelesai;
        private System.Windows.Forms.RichTextBox rtbIsi;
        private System.Windows.Forms.Button Selesai;
    }
}