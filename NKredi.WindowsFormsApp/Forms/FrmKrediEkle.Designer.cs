namespace NKredi.WindowsFormsApp.Forms
{
    partial class FrmKrediEkle
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
            txtKrediEkle = new TextBox();
            lblTuruNokta = new Label();
            lblTuru = new Label();
            btnKrediTuruEkle = new Button();
            txtKrediOrani = new TextBox();
            lvlKrediOraniNokta = new Label();
            lblKrediOrani = new Label();
            btnKrediOraniEkle = new Button();
            SuspendLayout();
            // 
            // txtKrediEkle
            // 
            txtKrediEkle.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtKrediEkle.Location = new Point(134, 6);
            txtKrediEkle.Name = "txtKrediEkle";
            txtKrediEkle.Size = new Size(220, 30);
            txtKrediEkle.TabIndex = 32;
            // 
            // lblTuruNokta
            // 
            lblTuruNokta.AutoSize = true;
            lblTuruNokta.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblTuruNokta.Location = new Point(114, 9);
            lblTuruNokta.Name = "lblTuruNokta";
            lblTuruNokta.Size = new Size(14, 23);
            lblTuruNokta.TabIndex = 30;
            lblTuruNokta.Text = ":";
            // 
            // lblTuru
            // 
            lblTuru.AutoSize = true;
            lblTuru.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblTuru.Location = new Point(12, 9);
            lblTuru.Name = "lblTuru";
            lblTuru.Size = new Size(89, 23);
            lblTuru.TabIndex = 31;
            lblTuru.Text = "Kredi Türü";
            // 
            // btnKrediTuruEkle
            // 
            btnKrediTuruEkle.BackColor = SystemColors.ActiveCaption;
            btnKrediTuruEkle.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnKrediTuruEkle.ForeColor = SystemColors.Desktop;
            btnKrediTuruEkle.ImageAlign = ContentAlignment.TopRight;
            btnKrediTuruEkle.Location = new Point(12, 78);
            btnKrediTuruEkle.Name = "btnKrediTuruEkle";
            btnKrediTuruEkle.Size = new Size(342, 50);
            btnKrediTuruEkle.TabIndex = 29;
            btnKrediTuruEkle.Text = "Kredi Ekle";
            btnKrediTuruEkle.UseVisualStyleBackColor = false;
            // 
            // txtKrediOrani
            // 
            txtKrediOrani.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtKrediOrani.Location = new Point(134, 42);
            txtKrediOrani.Name = "txtKrediOrani";
            txtKrediOrani.Size = new Size(220, 30);
            txtKrediOrani.TabIndex = 36;
            // 
            // lvlKrediOraniNokta
            // 
            lvlKrediOraniNokta.AutoSize = true;
            lvlKrediOraniNokta.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lvlKrediOraniNokta.Location = new Point(114, 45);
            lvlKrediOraniNokta.Name = "lvlKrediOraniNokta";
            lvlKrediOraniNokta.Size = new Size(14, 23);
            lvlKrediOraniNokta.TabIndex = 34;
            lvlKrediOraniNokta.Text = ":";
            // 
            // lblKrediOrani
            // 
            lblKrediOrani.AutoSize = true;
            lblKrediOrani.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblKrediOrani.Location = new Point(12, 45);
            lblKrediOrani.Name = "lblKrediOrani";
            lblKrediOrani.Size = new Size(96, 23);
            lblKrediOrani.TabIndex = 35;
            lblKrediOrani.Text = "Kredi Oranı";
            // 
            // btnKrediOraniEkle
            // 
            btnKrediOraniEkle.BackColor = SystemColors.ActiveCaption;
            btnKrediOraniEkle.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnKrediOraniEkle.ForeColor = SystemColors.Desktop;
            btnKrediOraniEkle.ImageAlign = ContentAlignment.TopRight;
            btnKrediOraniEkle.Location = new Point(12, 134);
            btnKrediOraniEkle.Name = "btnKrediOraniEkle";
            btnKrediOraniEkle.Size = new Size(342, 50);
            btnKrediOraniEkle.TabIndex = 33;
            btnKrediOraniEkle.Text = "Kredi Orani Ekle";
            btnKrediOraniEkle.UseVisualStyleBackColor = false;
            // 
            // FrmKrediEkle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(367, 196);
            Controls.Add(txtKrediOrani);
            Controls.Add(lvlKrediOraniNokta);
            Controls.Add(lblKrediOrani);
            Controls.Add(btnKrediOraniEkle);
            Controls.Add(txtKrediEkle);
            Controls.Add(lblTuruNokta);
            Controls.Add(lblTuru);
            Controls.Add(btnKrediTuruEkle);
            Name = "FrmKrediEkle";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kredi Ekle";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtKrediEkle;
        private Label lblTuruNokta;
        private Label lblTuru;
        private Button btnKrediTuruEkle;
        private TextBox txtKrediOrani;
        private Label lvlKrediOraniNokta;
        private Label lblKrediOrani;
        private Button btnKrediOraniEkle;
    }
}