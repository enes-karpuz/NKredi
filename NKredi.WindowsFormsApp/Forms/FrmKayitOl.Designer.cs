namespace NKredi.WindowsFormsApp.Forms
{
    partial class FrmKayitOl
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
            LblTipi = new Label();
            TxtAdi = new TextBox();
            LblAdi = new Label();
            TxtSoyadi = new TextBox();
            LblSoyadi = new Label();
            TxtEPosta = new TextBox();
            LblEPosta = new Label();
            TxtSifre = new TextBox();
            LblSifre = new Label();
            LblDogumTarihi = new Label();
            CmbTipi = new ComboBox();
            DtpDogumTarihi = new DateTimePicker();
            BtnKaydet = new Button();
            SuspendLayout();
            // 
            // LblTipi
            // 
            LblTipi.AutoSize = true;
            LblTipi.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LblTipi.Location = new Point(155, 32);
            LblTipi.Name = "LblTipi";
            LblTipi.Size = new Size(44, 28);
            LblTipi.TabIndex = 0;
            LblTipi.Text = "Tipi";
            // 
            // TxtAdi
            // 
            TxtAdi.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TxtAdi.Location = new Point(205, 69);
            TxtAdi.Name = "TxtAdi";
            TxtAdi.Size = new Size(222, 34);
            TxtAdi.TabIndex = 3;
            // 
            // LblAdi
            // 
            LblAdi.AutoSize = true;
            LblAdi.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LblAdi.Location = new Point(155, 72);
            LblAdi.Name = "LblAdi";
            LblAdi.Size = new Size(42, 28);
            LblAdi.TabIndex = 4;
            LblAdi.Text = "Adı";
            // 
            // TxtSoyadi
            // 
            TxtSoyadi.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TxtSoyadi.Location = new Point(205, 109);
            TxtSoyadi.Name = "TxtSoyadi";
            TxtSoyadi.Size = new Size(222, 34);
            TxtSoyadi.TabIndex = 5;
            // 
            // LblSoyadi
            // 
            LblSoyadi.AutoSize = true;
            LblSoyadi.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LblSoyadi.Location = new Point(127, 112);
            LblSoyadi.Name = "LblSoyadi";
            LblSoyadi.Size = new Size(72, 28);
            LblSoyadi.TabIndex = 2;
            LblSoyadi.Text = "Soyadı";
            // 
            // TxtEPosta
            // 
            TxtEPosta.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TxtEPosta.Location = new Point(205, 149);
            TxtEPosta.Name = "TxtEPosta";
            TxtEPosta.PlaceholderText = "abc@nkredi.com";
            TxtEPosta.Size = new Size(222, 34);
            TxtEPosta.TabIndex = 7;
            // 
            // LblEPosta
            // 
            LblEPosta.AutoSize = true;
            LblEPosta.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LblEPosta.Location = new Point(122, 152);
            LblEPosta.Name = "LblEPosta";
            LblEPosta.Size = new Size(77, 28);
            LblEPosta.TabIndex = 6;
            LblEPosta.Text = "E-Posta";
            // 
            // TxtSifre
            // 
            TxtSifre.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TxtSifre.Location = new Point(205, 189);
            TxtSifre.Name = "TxtSifre";
            TxtSifre.PasswordChar = '*';
            TxtSifre.Size = new Size(222, 34);
            TxtSifre.TabIndex = 9;
            // 
            // LblSifre
            // 
            LblSifre.AutoSize = true;
            LblSifre.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LblSifre.Location = new Point(146, 192);
            LblSifre.Name = "LblSifre";
            LblSifre.Size = new Size(51, 28);
            LblSifre.TabIndex = 8;
            LblSifre.Text = "Şifre";
            // 
            // LblDogumTarihi
            // 
            LblDogumTarihi.AutoSize = true;
            LblDogumTarihi.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LblDogumTarihi.Location = new Point(70, 232);
            LblDogumTarihi.Name = "LblDogumTarihi";
            LblDogumTarihi.Size = new Size(129, 28);
            LblDogumTarihi.TabIndex = 10;
            LblDogumTarihi.Text = "Doğum Tarihi";
            // 
            // CmbTipi
            // 
            CmbTipi.FormattingEnabled = true;
            CmbTipi.Location = new Point(205, 36);
            CmbTipi.Name = "CmbTipi";
            CmbTipi.Size = new Size(222, 28);
            CmbTipi.TabIndex = 12;
            // 
            // DtpDogumTarihi
            // 
            DtpDogumTarihi.Format = DateTimePickerFormat.Short;
            DtpDogumTarihi.Location = new Point(205, 234);
            DtpDogumTarihi.Name = "DtpDogumTarihi";
            DtpDogumTarihi.Size = new Size(222, 27);
            DtpDogumTarihi.TabIndex = 13;
            // 
            // BtnKaydet
            // 
            BtnKaydet.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            BtnKaydet.Location = new Point(70, 267);
            BtnKaydet.Name = "BtnKaydet";
            BtnKaydet.Size = new Size(357, 70);
            BtnKaydet.TabIndex = 14;
            BtnKaydet.Text = "Kaydet";
            BtnKaydet.UseVisualStyleBackColor = true;
            BtnKaydet.Click += BtnKaydet_Click;
            // 
            // FrmKayitOl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(496, 369);
            Controls.Add(BtnKaydet);
            Controls.Add(DtpDogumTarihi);
            Controls.Add(CmbTipi);
            Controls.Add(LblDogumTarihi);
            Controls.Add(TxtSifre);
            Controls.Add(LblSifre);
            Controls.Add(TxtEPosta);
            Controls.Add(LblEPosta);
            Controls.Add(TxtSoyadi);
            Controls.Add(LblSoyadi);
            Controls.Add(TxtAdi);
            Controls.Add(LblAdi);
            Controls.Add(LblTipi);
            Name = "FrmKayitOl";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kayıt Ekranı";
            Load += FrmKayitOl_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblTipi;
        private TextBox TxtAdi;
        private Label LblAdi;
        private TextBox TxtSoyadi;
        private Label LblSoyadi;
        private TextBox TxtEPosta;
        private Label LblEPosta;
        private TextBox TxtSifre;
        private Label LblSifre;
        private Label LblDogumTarihi;
        private ComboBox CmbTipi;
        private DateTimePicker DtpDogumTarihi;
        private Button BtnKaydet;
    }
}