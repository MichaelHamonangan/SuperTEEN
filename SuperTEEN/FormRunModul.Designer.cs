
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRunModul));
            this.lblTask = new System.Windows.Forms.Label();
            this.btnJalankan = new System.Windows.Forms.Button();
            this.lblDurasi = new System.Windows.Forms.Label();
            this.lblDetik = new System.Windows.Forms.Label();
            this.lblNamaModul = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.btnBatalkan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTask
            // 
            this.lblTask.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.lblTask, "lblTask");
            this.lblTask.Name = "lblTask";
            // 
            // btnJalankan
            // 
            this.btnJalankan.BackColor = System.Drawing.Color.DarkCyan;
            this.btnJalankan.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnJalankan, "btnJalankan");
            this.btnJalankan.ForeColor = System.Drawing.Color.White;
            this.btnJalankan.Name = "btnJalankan";
            this.btnJalankan.UseVisualStyleBackColor = false;
            this.btnJalankan.Click += new System.EventHandler(this.btnJalankan_Click);
            // 
            // lblDurasi
            // 
            this.lblDurasi.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.lblDurasi, "lblDurasi");
            this.lblDurasi.Name = "lblDurasi";
            // 
            // lblDetik
            // 
            this.lblDetik.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.lblDetik, "lblDetik");
            this.lblDetik.Name = "lblDetik";
            // 
            // lblNamaModul
            // 
            this.lblNamaModul.AutoEllipsis = true;
            this.lblNamaModul.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.lblNamaModul, "lblNamaModul");
            this.lblNamaModul.Name = "lblNamaModul";
            // 
            // lblTime
            // 
            this.lblTime.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.lblTime, "lblTime");
            this.lblTime.Name = "lblTime";
            // 
            // btnBatalkan
            // 
            this.btnBatalkan.BackColor = System.Drawing.Color.DarkCyan;
            this.btnBatalkan.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnBatalkan, "btnBatalkan");
            this.btnBatalkan.ForeColor = System.Drawing.Color.White;
            this.btnBatalkan.Name = "btnBatalkan";
            this.btnBatalkan.UseVisualStyleBackColor = false;
            this.btnBatalkan.Click += new System.EventHandler(this.btnBatalkan_Click);
            // 
            // FormRunModul
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImage = global::SuperTEEN.Properties.Resources.Light_Flat_Shapes_Simple_Background_Orange;
            this.Controls.Add(this.btnBatalkan);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblNamaModul);
            this.Controls.Add(this.lblDetik);
            this.Controls.Add(this.lblDurasi);
            this.Controls.Add(this.btnJalankan);
            this.Controls.Add(this.lblTask);
            this.Name = "FormRunModul";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblTask;
        private System.Windows.Forms.Button btnJalankan;
        //private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.Label lblDetik;
        private System.Windows.Forms.Label lblDurasi;
        private System.Windows.Forms.Label lblNamaModul;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Button btnBatalkan;
    }
}