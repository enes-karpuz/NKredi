namespace NKredi.WindowsFormsApp.Forms
{
    partial class FrmAnaSayfa
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
            lblBaslik = new Label();
            btnKullanici = new Button();
            btnBankalar = new Button();
            btnKrediler = new Button();
            SuspendLayout();
            // 
            // lblBaslik
            // 
            lblBaslik.AutoSize = true;
            lblBaslik.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            lblBaslik.ForeColor = SystemColors.HotTrack;
            lblBaslik.Location = new Point(15, 16);
            lblBaslik.Name = "lblBaslik";
            lblBaslik.Size = new Size(359, 46);
            lblBaslik.TabIndex = 0;
            lblBaslik.Text = "NKREDİ KAYIT SİSTEMİ";
            // 
            // btnKullanici
            // 
            btnKullanici.BackColor = SystemColors.ActiveCaption;
            btnKullanici.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnKullanici.ForeColor = SystemColors.Desktop;
            btnKullanici.ImageAlign = ContentAlignment.TopRight;
            btnKullanici.Location = new Point(15, 65);
            btnKullanici.Name = "btnKullanici";
            btnKullanici.Size = new Size(359, 50);
            btnKullanici.TabIndex = 1;
            btnKullanici.Text = "Kullanıcılar";
            btnKullanici.UseVisualStyleBackColor = false;
            btnKullanici.Click += btnKullanici_Click;
            // 
            // btnBankalar
            // 
            btnBankalar.BackColor = SystemColors.ActiveCaption;
            btnBankalar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnBankalar.ForeColor = SystemColors.Desktop;
            btnBankalar.ImageAlign = ContentAlignment.TopRight;
            btnBankalar.Location = new Point(15, 121);
            btnBankalar.Name = "btnBankalar";
            btnBankalar.Size = new Size(359, 50);
            btnBankalar.TabIndex = 1;
            btnBankalar.Text = "Bankalar";
            btnBankalar.UseVisualStyleBackColor = false;
            btnBankalar.Click += btnBankalar_Click;
            // 
            // btnKrediler
            // 
            btnKrediler.BackColor = SystemColors.ActiveCaption;
            btnKrediler.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnKrediler.ForeColor = SystemColors.Desktop;
            btnKrediler.ImageAlign = ContentAlignment.TopRight;
            btnKrediler.Location = new Point(15, 177);
            btnKrediler.Name = "btnKrediler";
            btnKrediler.Size = new Size(359, 50);
            btnKrediler.TabIndex = 1;
            btnKrediler.Text = "Krediler";
            btnKrediler.UseVisualStyleBackColor = false;
            btnKrediler.Click += btnKrediler_Click;
            // 
            // FrmAnaSayfa
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(389, 242);
            Controls.Add(btnKrediler);
            Controls.Add(btnBankalar);
            Controls.Add(btnKullanici);
            Controls.Add(lblBaslik);
            Name = "FrmAnaSayfa";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ana Sayfa";
            Load += FrmAnaSayfa_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBaslik;
        private Button btnKullanici;
        private Button btnBankalar;
        private Button btnKrediler;
    }
}