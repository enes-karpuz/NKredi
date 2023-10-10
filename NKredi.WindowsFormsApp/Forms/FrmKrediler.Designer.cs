namespace NKredi.WindowsFormsApp.Forms
{
    partial class FrmKrediler
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
            dgvKrediler = new DataGridView();
            btnKrediSil = new Button();
            btnKrediGuncelle = new Button();
            btnKrediEkle = new Button();
            dgvKrediOrani = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvKrediler).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvKrediOrani).BeginInit();
            SuspendLayout();
            // 
            // dgvKrediler
            // 
            dgvKrediler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKrediler.Location = new Point(12, 66);
            dgvKrediler.Name = "dgvKrediler";
            dgvKrediler.RowHeadersWidth = 51;
            dgvKrediler.RowTemplate.Height = 29;
            dgvKrediler.Size = new Size(776, 184);
            dgvKrediler.TabIndex = 12;
            // 
            // btnKrediSil
            // 
            btnKrediSil.BackColor = SystemColors.ActiveCaption;
            btnKrediSil.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnKrediSil.ForeColor = SystemColors.Desktop;
            btnKrediSil.ImageAlign = ContentAlignment.TopRight;
            btnKrediSil.Location = new Point(234, 12);
            btnKrediSil.Name = "btnKrediSil";
            btnKrediSil.Size = new Size(105, 48);
            btnKrediSil.TabIndex = 9;
            btnKrediSil.Text = "Sil";
            btnKrediSil.UseVisualStyleBackColor = false;
            // 
            // btnKrediGuncelle
            // 
            btnKrediGuncelle.BackColor = SystemColors.ActiveCaption;
            btnKrediGuncelle.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnKrediGuncelle.ForeColor = SystemColors.Desktop;
            btnKrediGuncelle.ImageAlign = ContentAlignment.TopRight;
            btnKrediGuncelle.Location = new Point(123, 12);
            btnKrediGuncelle.Name = "btnKrediGuncelle";
            btnKrediGuncelle.Size = new Size(105, 48);
            btnKrediGuncelle.TabIndex = 10;
            btnKrediGuncelle.Text = "Güncelle";
            btnKrediGuncelle.UseVisualStyleBackColor = false;
            // 
            // btnKrediEkle
            // 
            btnKrediEkle.BackColor = SystemColors.ActiveCaption;
            btnKrediEkle.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnKrediEkle.ForeColor = SystemColors.Desktop;
            btnKrediEkle.ImageAlign = ContentAlignment.TopRight;
            btnKrediEkle.Location = new Point(12, 12);
            btnKrediEkle.Name = "btnKrediEkle";
            btnKrediEkle.Size = new Size(105, 48);
            btnKrediEkle.TabIndex = 11;
            btnKrediEkle.Text = "Ekle";
            btnKrediEkle.UseVisualStyleBackColor = false;
            btnKrediEkle.Click += btnKrediEkle_Click;
            // 
            // dgvKrediOrani
            // 
            dgvKrediOrani.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKrediOrani.Location = new Point(12, 256);
            dgvKrediOrani.Name = "dgvKrediOrani";
            dgvKrediOrani.RowHeadersWidth = 51;
            dgvKrediOrani.RowTemplate.Height = 29;
            dgvKrediOrani.Size = new Size(776, 182);
            dgvKrediOrani.TabIndex = 12;
            // 
            // FrmKrediler
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvKrediOrani);
            Controls.Add(dgvKrediler);
            Controls.Add(btnKrediSil);
            Controls.Add(btnKrediGuncelle);
            Controls.Add(btnKrediEkle);
            Name = "FrmKrediler";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Krediler";
            ((System.ComponentModel.ISupportInitialize)dgvKrediler).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvKrediOrani).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvKrediler;
        private Button btnKrediSil;
        private Button btnKrediGuncelle;
        private Button btnKrediEkle;
        private DataGridView dgvKrediOrani;
    }
}