namespace NKredi.WindowsFormApp
{
    partial class FrmMainMenu
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.BtnGetirKullanici = new System.Windows.Forms.Button();
            this.RTxtCevap = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.BtnGetirKullanici);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.RTxtCevap);
            this.splitContainer1.Size = new System.Drawing.Size(851, 439);
            this.splitContainer1.SplitterDistance = 67;
            this.splitContainer1.TabIndex = 0;
            // 
            // BtnGetirKullanici
            // 
            this.BtnGetirKullanici.Location = new System.Drawing.Point(12, 10);
            this.BtnGetirKullanici.Name = "BtnGetirKullanici";
            this.BtnGetirKullanici.Size = new System.Drawing.Size(142, 47);
            this.BtnGetirKullanici.TabIndex = 0;
            this.BtnGetirKullanici.Text = "Getir Kullanıcı";
            this.BtnGetirKullanici.UseVisualStyleBackColor = true;
            this.BtnGetirKullanici.Click += new System.EventHandler(this.BtnGetirKullanici_Click);
            // 
            // RTxtCevap
            // 
            this.RTxtCevap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RTxtCevap.Location = new System.Drawing.Point(0, 0);
            this.RTxtCevap.Name = "RTxtCevap";
            this.RTxtCevap.Size = new System.Drawing.Size(851, 368);
            this.RTxtCevap.TabIndex = 0;
            this.RTxtCevap.Text = "";
            // 
            // FrmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 439);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmMainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ana Menü";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button BtnGetirKullanici;
        private System.Windows.Forms.RichTextBox RTxtCevap;
    }
}

