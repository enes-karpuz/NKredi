namespace NKredi.WindowsFormsApp.Forms
{
    partial class FrmBankalar
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
            dgvBankalar = new DataGridView();
            btnBankaSil = new Button();
            btnBankaGuncelle = new Button();
            btnBankaEkle = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvBankalar).BeginInit();
            SuspendLayout();
            // 
            // dgvBankalar
            // 
            dgvBankalar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBankalar.Location = new Point(12, 66);
            dgvBankalar.Name = "dgvBankalar";
            dgvBankalar.RowHeadersWidth = 51;
            dgvBankalar.RowTemplate.Height = 29;
            dgvBankalar.Size = new Size(776, 372);
            dgvBankalar.TabIndex = 8;
            // 
            // btnBankaSil
            // 
            btnBankaSil.BackColor = SystemColors.ActiveCaption;
            btnBankaSil.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnBankaSil.ForeColor = SystemColors.Desktop;
            btnBankaSil.ImageAlign = ContentAlignment.TopRight;
            btnBankaSil.Location = new Point(234, 12);
            btnBankaSil.Name = "btnBankaSil";
            btnBankaSil.Size = new Size(105, 48);
            btnBankaSil.TabIndex = 5;
            btnBankaSil.Text = "Sil";
            btnBankaSil.UseVisualStyleBackColor = false;
            // 
            // btnBankaGuncelle
            // 
            btnBankaGuncelle.BackColor = SystemColors.ActiveCaption;
            btnBankaGuncelle.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnBankaGuncelle.ForeColor = SystemColors.Desktop;
            btnBankaGuncelle.ImageAlign = ContentAlignment.TopRight;
            btnBankaGuncelle.Location = new Point(123, 12);
            btnBankaGuncelle.Name = "btnBankaGuncelle";
            btnBankaGuncelle.Size = new Size(105, 48);
            btnBankaGuncelle.TabIndex = 6;
            btnBankaGuncelle.Text = "Güncelle";
            btnBankaGuncelle.UseVisualStyleBackColor = false;
            // 
            // btnBankaEkle
            // 
            btnBankaEkle.BackColor = SystemColors.ActiveCaption;
            btnBankaEkle.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnBankaEkle.ForeColor = SystemColors.Desktop;
            btnBankaEkle.ImageAlign = ContentAlignment.TopRight;
            btnBankaEkle.Location = new Point(12, 12);
            btnBankaEkle.Name = "btnBankaEkle";
            btnBankaEkle.Size = new Size(105, 48);
            btnBankaEkle.TabIndex = 7;
            btnBankaEkle.Text = "Ekle";
            btnBankaEkle.UseVisualStyleBackColor = false;
            btnBankaEkle.Click += btnBankaEkle_Click;
            // 
            // FrmBankalar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvBankalar);
            Controls.Add(btnBankaSil);
            Controls.Add(btnBankaGuncelle);
            Controls.Add(btnBankaEkle);
            Name = "FrmBankalar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bankalar";
            ((System.ComponentModel.ISupportInitialize)dgvBankalar).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvBankalar;
        private Button btnBankaSil;
        private Button btnBankaGuncelle;
        private Button btnBankaEkle;
    }
}