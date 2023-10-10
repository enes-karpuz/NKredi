namespace NKredi.WindowsFormsApp
{
    partial class DashBoard
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
            pnlLeft = new Panel();
            lblBaslik = new Label();
            btnKullanicilar = new Button();
            btnKullaniciTipleri = new Button();
            btnBankalar = new Button();
            btnKrediler = new Button();
            btnKrediOranlari = new Button();
            btnDovizCinleri = new Button();
            panel1 = new Panel();
            btnKurTablosu = new Button();
            btnLog = new Button();
            pnlLeft.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pnlLeft
            // 
            pnlLeft.BackColor = SystemColors.ActiveCaption;
            pnlLeft.Controls.Add(lblBaslik);
            pnlLeft.Location = new Point(2, 0);
            pnlLeft.Name = "pnlLeft";
            pnlLeft.Size = new Size(1168, 85);
            pnlLeft.TabIndex = 0;
            // 
            // lblBaslik
            // 
            lblBaslik.AutoSize = true;
            lblBaslik.BackColor = SystemColors.ActiveCaption;
            lblBaslik.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            lblBaslik.ForeColor = SystemColors.ActiveCaptionText;
            lblBaslik.Location = new Point(444, 18);
            lblBaslik.Name = "lblBaslik";
            lblBaslik.Size = new Size(389, 46);
            lblBaslik.TabIndex = 1;
            lblBaslik.Text = "NKREDİ KAYIT SİSTEMİ";
            // 
            // btnKullanicilar
            // 
            btnKullanicilar.BackColor = SystemColors.ActiveCaption;
            btnKullanicilar.BackgroundImageLayout = ImageLayout.None;
            btnKullanicilar.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnKullanicilar.ForeColor = SystemColors.MenuText;
            btnKullanicilar.ImageAlign = ContentAlignment.TopRight;
            btnKullanicilar.Location = new Point(3, 36);
            btnKullanicilar.Name = "btnKullanicilar";
            btnKullanicilar.Size = new Size(247, 50);
            btnKullanicilar.TabIndex = 2;
            btnKullanicilar.Text = "Kullanıcılar";
            btnKullanicilar.UseVisualStyleBackColor = false;
            // 
            // btnKullaniciTipleri
            // 
            btnKullaniciTipleri.BackColor = SystemColors.ActiveCaption;
            btnKullaniciTipleri.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnKullaniciTipleri.ForeColor = SystemColors.MenuText;
            btnKullaniciTipleri.ImageAlign = ContentAlignment.TopRight;
            btnKullaniciTipleri.Location = new Point(3, 117);
            btnKullaniciTipleri.Name = "btnKullaniciTipleri";
            btnKullaniciTipleri.Size = new Size(247, 50);
            btnKullaniciTipleri.TabIndex = 2;
            btnKullaniciTipleri.Text = "Kullanıcı Tipleri";
            btnKullaniciTipleri.UseVisualStyleBackColor = false;
            // 
            // btnBankalar
            // 
            btnBankalar.BackColor = SystemColors.ActiveCaption;
            btnBankalar.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnBankalar.ForeColor = SystemColors.MenuText;
            btnBankalar.ImageAlign = ContentAlignment.TopRight;
            btnBankalar.Location = new Point(3, 207);
            btnBankalar.Name = "btnBankalar";
            btnBankalar.Size = new Size(247, 50);
            btnBankalar.TabIndex = 2;
            btnBankalar.Text = "Bankalar";
            btnBankalar.UseVisualStyleBackColor = false;
            // 
            // btnKrediler
            // 
            btnKrediler.BackColor = SystemColors.ActiveCaption;
            btnKrediler.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnKrediler.ForeColor = SystemColors.MenuText;
            btnKrediler.ImageAlign = ContentAlignment.TopRight;
            btnKrediler.Location = new Point(3, 289);
            btnKrediler.Name = "btnKrediler";
            btnKrediler.Size = new Size(247, 50);
            btnKrediler.TabIndex = 2;
            btnKrediler.Text = "Krediler";
            btnKrediler.UseVisualStyleBackColor = false;
            // 
            // btnKrediOranlari
            // 
            btnKrediOranlari.BackColor = SystemColors.ActiveCaption;
            btnKrediOranlari.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnKrediOranlari.ForeColor = SystemColors.MenuText;
            btnKrediOranlari.ImageAlign = ContentAlignment.TopRight;
            btnKrediOranlari.Location = new Point(3, 374);
            btnKrediOranlari.Name = "btnKrediOranlari";
            btnKrediOranlari.Size = new Size(247, 50);
            btnKrediOranlari.TabIndex = 2;
            btnKrediOranlari.Text = "Kredi Oranları";
            btnKrediOranlari.UseVisualStyleBackColor = false;
            // 
            // btnDovizCinleri
            // 
            btnDovizCinleri.BackColor = SystemColors.ActiveCaption;
            btnDovizCinleri.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnDovizCinleri.ForeColor = SystemColors.MenuText;
            btnDovizCinleri.ImageAlign = ContentAlignment.TopRight;
            btnDovizCinleri.Location = new Point(3, 452);
            btnDovizCinleri.Name = "btnDovizCinleri";
            btnDovizCinleri.Size = new Size(247, 50);
            btnDovizCinleri.TabIndex = 2;
            btnDovizCinleri.Text = "Döviz Cinsleri";
            btnDovizCinleri.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(btnKullanicilar);
            panel1.Controls.Add(btnKurTablosu);
            panel1.Controls.Add(btnDovizCinleri);
            panel1.Controls.Add(btnKullaniciTipleri);
            panel1.Controls.Add(btnKrediOranlari);
            panel1.Controls.Add(btnBankalar);
            panel1.Controls.Add(btnKrediler);
            panel1.Location = new Point(2, 82);
            panel1.Name = "panel1";
            panel1.Size = new Size(256, 592);
            panel1.TabIndex = 3;
            panel1.Paint += panel1_Paint;
            // 
            // btnKurTablosu
            // 
            btnKurTablosu.BackColor = SystemColors.ActiveCaption;
            btnKurTablosu.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnKurTablosu.ForeColor = SystemColors.MenuText;
            btnKurTablosu.ImageAlign = ContentAlignment.TopRight;
            btnKurTablosu.Location = new Point(3, 531);
            btnKurTablosu.Name = "btnKurTablosu";
            btnKurTablosu.Size = new Size(247, 50);
            btnKurTablosu.TabIndex = 2;
            btnKurTablosu.Text = "Kur Tablosu";
            btnKurTablosu.UseVisualStyleBackColor = false;
            // 
            // btnLog
            // 
            btnLog.BackColor = SystemColors.Control;
            btnLog.Font = new Font("Sitka Small", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnLog.ForeColor = SystemColors.Desktop;
            btnLog.ImageAlign = ContentAlignment.MiddleRight;
            btnLog.Location = new Point(1038, 643);
            btnLog.Name = "btnLog";
            btnLog.Size = new Size(132, 31);
            btnLog.TabIndex = 4;
            btnLog.Text = "Log";
            btnLog.UseVisualStyleBackColor = false;
            // 
            // DashBoard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1168, 675);
            Controls.Add(btnLog);
            Controls.Add(panel1);
            Controls.Add(pnlLeft);
            Name = "DashBoard";
            Text = "DashBoard";
            pnlLeft.ResumeLayout(false);
            pnlLeft.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlLeft;
        private Label lblBaslik;
        private Button btnKullanicilar;
        private Button btnKullaniciTipleri;
        private Button btnBankalar;
        private Button btnKrediler;
        private Button btnKrediOranlari;
        private Button btnDovizCinleri;
        private Panel panel1;
        private Button btnKurTablosu;
        private Button btnLog;
    }
}