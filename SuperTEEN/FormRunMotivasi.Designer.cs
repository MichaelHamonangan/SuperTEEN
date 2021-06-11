
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
            this.lblNamaModul.BackColor = System.Drawing.Color.Transparent;
            this.lblNamaModul.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblNamaModul.Font = new System.Drawing.Font("Segoe UI", 16.1194F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.lblTask.BackColor = System.Drawing.Color.Transparent;
            this.lblTask.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTask.Font = new System.Drawing.Font("Segoe UI", 10.74627F);
            this.lblTask.Location = new System.Drawing.Point(0, 36);
            this.lblTask.Name = "lblTask";
            this.lblTask.Padding = new System.Windows.Forms.Padding(0, 14, 0, 0);
            this.lblTask.Size = new System.Drawing.Size(711, 359);
            this.lblTask.TabIndex = 4;
            this.lblTask.Text = "Task";
            this.lblTask.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnSelesai
            // 
            this.btnSelesai.BackColor = System.Drawing.Color.DarkCyan;
            this.btnSelesai.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSelesai.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSelesai.Font = new System.Drawing.Font("Garamond", 10.20895F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelesai.ForeColor = System.Drawing.Color.White;
            this.btnSelesai.Location = new System.Drawing.Point(313, 345);
            this.btnSelesai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSelesai.Name = "btnSelesai";
            this.btnSelesai.Size = new System.Drawing.Size(93, 39);
            this.btnSelesai.TabIndex = 5;
            this.btnSelesai.Text = "Selesai";
            this.btnSelesai.UseVisualStyleBackColor = false;
            this.btnSelesai.Click += new System.EventHandler(this.btnSelesai_Click);
            // 
            // rtbIsi
            // 
            this.rtbIsi.Font = new System.Drawing.Font("Times New Roman", 10.20895F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbIsi.Location = new System.Drawing.Point(32, 126);
            this.rtbIsi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rtbIsi.Name = "rtbIsi";
            this.rtbIsi.Size = new System.Drawing.Size(644, 215);
            this.rtbIsi.TabIndex = 6;
            this.rtbIsi.Text = "";
            // 
            // FormRunMotivasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(134F, 134F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImage = global::SuperTEEN.Properties.Resources.Light_Flat_Shapes_Simple_Background_Orange;
            this.ClientSize = new System.Drawing.Size(711, 395);
            this.Controls.Add(this.rtbIsi);
            this.Controls.Add(this.btnSelesai);
            this.Controls.Add(this.lblTask);
            this.Controls.Add(this.lblNamaModul);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(731, 447);
            this.MinimumSize = new System.Drawing.Size(731, 447);
            this.Name = "FormRunMotivasi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jalankan Modul";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblNamaModul;
        private System.Windows.Forms.Label lblTask;
        private System.Windows.Forms.Button btnSelesai;
        private System.Windows.Forms.RichTextBox rtbIsi;
        //private System.Windows.Forms.Button Selesai;
    }
}