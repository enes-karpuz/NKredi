namespace NKredi.WindowsFormsApp.Forms
{
    partial class FrmKullaniciEkle
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
            txtAdiText = new TextBox();
            lblAdiNokta = new Label();
            lblAdi = new Label();
            btnKullaniciEkle = new Button();
            lblTipiNokta = new Label();
            lblTipi = new Label();
            lblSoyadi = new Label();
            lblSoyadiNokta = new Label();
            txtSoyadi = new TextBox();
            lblEmail = new Label();
            lblEmailNokta = new Label();
            txtEmail = new TextBox();
            lblSifre = new Label();
            lblSifreNokta = new Label();
            txtSifre = new TextBox();
            lblDogumTarihi = new Label();
            lblDogumTarihiNokta = new Label();
            cbTipi = new ComboBox();
            dtpDogumTarihi = new DateTimePicker();
            SuspendLayout();
            // 
            // txtAdiText
            // 
            txtAdiText.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtAdiText.Location = new Point(154, 49);
            txtAdiText.Name = "txtAdiText";
            txtAdiText.Size = new Size(247, 30);
            txtAdiText.TabIndex = 44;
            // 
            // lblAdiNokta
            // 
            lblAdiNokta.AutoSize = true;
            lblAdiNokta.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblAdiNokta.Location = new Point(134, 52);
            lblAdiNokta.Name = "lblAdiNokta";
            lblAdiNokta.Size = new Size(14, 23);
            lblAdiNokta.TabIndex = 42;
            lblAdiNokta.Text = ":";
            // 
            // lblAdi
            // 
            lblAdi.AutoSize = true;
            lblAdi.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblAdi.Location = new Point(16, 52);
            lblAdi.Name = "lblAdi";
            lblAdi.Size = new Size(35, 23);
            lblAdi.TabIndex = 43;
            lblAdi.Text = "Adı";
            // 
            // btnKullaniciEkle
            // 
            btnKullaniciEkle.BackColor = SystemColors.ActiveCaption;
            btnKullaniciEkle.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnKullaniciEkle.ForeColor = SystemColors.Desktop;
            btnKullaniciEkle.ImageAlign = ContentAlignment.TopRight;
            btnKullaniciEkle.Location = new Point(16, 249);
            btnKullaniciEkle.Name = "btnKullaniciEkle";
            btnKullaniciEkle.Size = new Size(385, 58);
            btnKullaniciEkle.TabIndex = 41;
            btnKullaniciEkle.Text = "Ekle";
            btnKullaniciEkle.UseVisualStyleBackColor = false;
            // 
            // lblTipiNokta
            // 
            lblTipiNokta.AutoSize = true;
            lblTipiNokta.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblTipiNokta.Location = new Point(134, 13);
            lblTipiNokta.Name = "lblTipiNokta";
            lblTipiNokta.Size = new Size(14, 23);
            lblTipiNokta.TabIndex = 38;
            lblTipiNokta.Text = ":";
            // 
            // lblTipi
            // 
            lblTipi.AutoSize = true;
            lblTipi.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblTipi.Location = new Point(16, 13);
            lblTipi.Name = "lblTipi";
            lblTipi.Size = new Size(37, 23);
            lblTipi.TabIndex = 39;
            lblTipi.Text = "Tipi";
            // 
            // lblSoyadi
            // 
            lblSoyadi.AutoSize = true;
            lblSoyadi.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblSoyadi.Location = new Point(16, 91);
            lblSoyadi.Name = "lblSoyadi";
            lblSoyadi.Size = new Size(60, 23);
            lblSoyadi.TabIndex = 39;
            lblSoyadi.Text = "Soyadı";
            // 
            // lblSoyadiNokta
            // 
            lblSoyadiNokta.AutoSize = true;
            lblSoyadiNokta.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblSoyadiNokta.Location = new Point(134, 91);
            lblSoyadiNokta.Name = "lblSoyadiNokta";
            lblSoyadiNokta.Size = new Size(14, 23);
            lblSoyadiNokta.TabIndex = 38;
            lblSoyadiNokta.Text = ":";
            // 
            // txtSoyadi
            // 
            txtSoyadi.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtSoyadi.Location = new Point(154, 88);
            txtSoyadi.Name = "txtSoyadi";
            txtSoyadi.Size = new Size(247, 30);
            txtSoyadi.TabIndex = 40;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblEmail.Location = new Point(16, 130);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(58, 23);
            lblEmail.TabIndex = 43;
            lblEmail.Text = "E-mail";
            // 
            // lblEmailNokta
            // 
            lblEmailNokta.AutoSize = true;
            lblEmailNokta.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblEmailNokta.Location = new Point(134, 130);
            lblEmailNokta.Name = "lblEmailNokta";
            lblEmailNokta.Size = new Size(14, 23);
            lblEmailNokta.TabIndex = 42;
            lblEmailNokta.Text = ":";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail.Location = new Point(154, 127);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(247, 30);
            txtEmail.TabIndex = 44;
            // 
            // lblSifre
            // 
            lblSifre.AutoSize = true;
            lblSifre.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblSifre.Location = new Point(16, 169);
            lblSifre.Name = "lblSifre";
            lblSifre.Size = new Size(43, 23);
            lblSifre.TabIndex = 39;
            lblSifre.Text = "Şifre";
            // 
            // lblSifreNokta
            // 
            lblSifreNokta.AutoSize = true;
            lblSifreNokta.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblSifreNokta.Location = new Point(134, 169);
            lblSifreNokta.Name = "lblSifreNokta";
            lblSifreNokta.Size = new Size(14, 23);
            lblSifreNokta.TabIndex = 38;
            lblSifreNokta.Text = ":";
            // 
            // txtSifre
            // 
            txtSifre.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtSifre.Location = new Point(154, 166);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(247, 30);
            txtSifre.TabIndex = 40;
            // 
            // lblDogumTarihi
            // 
            lblDogumTarihi.AutoSize = true;
            lblDogumTarihi.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblDogumTarihi.Location = new Point(16, 208);
            lblDogumTarihi.Name = "lblDogumTarihi";
            lblDogumTarihi.Size = new Size(112, 23);
            lblDogumTarihi.TabIndex = 43;
            lblDogumTarihi.Text = "Doğum Tarihi";
            // 
            // lblDogumTarihiNokta
            // 
            lblDogumTarihiNokta.AutoSize = true;
            lblDogumTarihiNokta.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblDogumTarihiNokta.Location = new Point(134, 208);
            lblDogumTarihiNokta.Name = "lblDogumTarihiNokta";
            lblDogumTarihiNokta.Size = new Size(14, 23);
            lblDogumTarihiNokta.TabIndex = 42;
            lblDogumTarihiNokta.Text = ":";
            // 
            // cbTipi
            // 
            cbTipi.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            cbTipi.FormattingEnabled = true;
            cbTipi.Location = new Point(154, 10);
            cbTipi.Name = "cbTipi";
            cbTipi.Size = new Size(247, 31);
            cbTipi.TabIndex = 45;
            // 
            // dtpDogumTarihi
            // 
            dtpDogumTarihi.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dtpDogumTarihi.Format = DateTimePickerFormat.Short;
            dtpDogumTarihi.Location = new Point(154, 202);
            dtpDogumTarihi.Name = "dtpDogumTarihi";
            dtpDogumTarihi.Size = new Size(247, 30);
            dtpDogumTarihi.TabIndex = 46;
            // 
            // FrmKullaniciEkle
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(417, 317);
            Controls.Add(dtpDogumTarihi);
            Controls.Add(cbTipi);
            Controls.Add(txtEmail);
            Controls.Add(txtAdiText);
            Controls.Add(lblDogumTarihiNokta);
            Controls.Add(lblEmailNokta);
            Controls.Add(lblAdiNokta);
            Controls.Add(lblDogumTarihi);
            Controls.Add(lblEmail);
            Controls.Add(txtSifre);
            Controls.Add(lblAdi);
            Controls.Add(txtSoyadi);
            Controls.Add(lblSifreNokta);
            Controls.Add(btnKullaniciEkle);
            Controls.Add(lblSoyadiNokta);
            Controls.Add(lblSifre);
            Controls.Add(lblSoyadi);
            Controls.Add(lblTipiNokta);
            Controls.Add(lblTipi);
            Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "FrmKullaniciEkle";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kullanıcı Ekle";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtAdiText;
        private Label lblAdiNokta;
        private Label lblAdi;
        private Button btnKullaniciEkle;
        private Label lblTipiNokta;
        private Label lblTipi;
        private Label lblSoyadi;
        private Label lblSoyadiNokta;
        private TextBox txtSoyadi;
        private Label lblEmail;
        private Label lblEmailNokta;
        private TextBox txtEmail;
        private Label lblSifre;
        private Label lblSifreNokta;
        private TextBox txtSifre;
        private Label lblDogumTarihi;
        private Label lblDogumTarihiNokta;
        private ComboBox cbTipi;
        private DateTimePicker dtpDogumTarihi;
    }
}