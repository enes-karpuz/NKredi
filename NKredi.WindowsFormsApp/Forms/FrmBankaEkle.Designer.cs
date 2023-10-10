namespace NKredi.WindowsFormsApp.Forms
{
    partial class FrmBankaEkle
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
            txtKisaAd = new TextBox();
            lblKisaAd = new Label();
            lblAdNokta = new Label();
            lblAd = new Label();
            txtAd = new TextBox();
            btnBankaEkle = new Button();
            lblBankaKisaNokta = new Label();
            SuspendLayout();
            // 
            // txtKisaAd
            // 
            txtKisaAd.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtKisaAd.Location = new Point(172, 8);
            txtKisaAd.Name = "txtKisaAd";
            txtKisaAd.Size = new Size(220, 30);
            txtKisaAd.TabIndex = 7;
            // 
            // lblKisaAd
            // 
            lblKisaAd.AutoSize = true;
            lblKisaAd.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblKisaAd.Location = new Point(10, 11);
            lblKisaAd.Name = "lblKisaAd";
            lblKisaAd.Size = new Size(136, 23);
            lblKisaAd.TabIndex = 5;
            lblKisaAd.Text = "Banka Kısaltması";
            // 
            // lblAdNokta
            // 
            lblAdNokta.AutoSize = true;
            lblAdNokta.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblAdNokta.Location = new Point(152, 47);
            lblAdNokta.Name = "lblAdNokta";
            lblAdNokta.Size = new Size(14, 23);
            lblAdNokta.TabIndex = 6;
            lblAdNokta.Text = ":";
            // 
            // lblAd
            // 
            lblAd.AutoSize = true;
            lblAd.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblAd.Location = new Point(10, 47);
            lblAd.Name = "lblAd";
            lblAd.Size = new Size(86, 23);
            lblAd.TabIndex = 5;
            lblAd.Text = "Banka Adı";
            // 
            // txtAd
            // 
            txtAd.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtAd.Location = new Point(172, 44);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(220, 30);
            txtAd.TabIndex = 7;
            // 
            // btnBankaEkle
            // 
            btnBankaEkle.BackColor = SystemColors.ActiveCaption;
            btnBankaEkle.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnBankaEkle.ForeColor = SystemColors.Desktop;
            btnBankaEkle.ImageAlign = ContentAlignment.TopRight;
            btnBankaEkle.Location = new Point(10, 80);
            btnBankaEkle.Name = "btnBankaEkle";
            btnBankaEkle.Size = new Size(382, 39);
            btnBankaEkle.TabIndex = 8;
            btnBankaEkle.Text = "Banka Ekle";
            btnBankaEkle.UseVisualStyleBackColor = false;
            // 
            // lblBankaKisaNokta
            // 
            lblBankaKisaNokta.AutoSize = true;
            lblBankaKisaNokta.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblBankaKisaNokta.Location = new Point(152, 11);
            lblBankaKisaNokta.Name = "lblBankaKisaNokta";
            lblBankaKisaNokta.Size = new Size(14, 23);
            lblBankaKisaNokta.TabIndex = 6;
            lblBankaKisaNokta.Text = ":";
            // 
            // FrmBankaVerileriEkle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(402, 126);
            Controls.Add(btnBankaEkle);
            Controls.Add(txtAd);
            Controls.Add(txtKisaAd);
            Controls.Add(lblAd);
            Controls.Add(lblBankaKisaNokta);
            Controls.Add(lblAdNokta);
            Controls.Add(lblKisaAd);
            Name = "FrmBankaVerileriEkle";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Banka Verileri Ekle";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtKisaAd;
        private Label lblKisaAd;
        private Label lblAdNokta;
        private Label lblAd;
        private TextBox txtAd;
        private Button btnBankaEkle;
        private Label lblBankaKisaNokta;
    }
}