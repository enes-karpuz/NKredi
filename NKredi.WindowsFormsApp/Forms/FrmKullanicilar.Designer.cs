namespace NKredi.WindowsFormsApp.Forms
{
    partial class FrmKullanicilar
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            btnKullaniciEkle = new Button();
            btnKullaniciGuncelle = new Button();
            btnKullaniciSil = new Button();
            dgvKullanicilar = new DataGridView();
            splitContainer1 = new SplitContainer();
            ((System.ComponentModel.ISupportInitialize)dgvKullanicilar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // btnKullaniciEkle
            // 
            btnKullaniciEkle.BackColor = Color.FromArgb(16, 108, 239);
            btnKullaniciEkle.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnKullaniciEkle.ForeColor = Color.WhiteSmoke;
            btnKullaniciEkle.Location = new Point(12, 12);
            btnKullaniciEkle.Name = "btnKullaniciEkle";
            btnKullaniciEkle.Size = new Size(105, 48);
            btnKullaniciEkle.TabIndex = 3;
            btnKullaniciEkle.Text = "Ekle";
            btnKullaniciEkle.UseVisualStyleBackColor = false;
            btnKullaniciEkle.Click += btnKullaniciEkle_Click;
            // 
            // btnKullaniciGuncelle
            // 
            btnKullaniciGuncelle.BackColor = Color.FromArgb(16, 108, 239);
            btnKullaniciGuncelle.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnKullaniciGuncelle.ForeColor = Color.WhiteSmoke;
            btnKullaniciGuncelle.Location = new Point(123, 12);
            btnKullaniciGuncelle.Name = "btnKullaniciGuncelle";
            btnKullaniciGuncelle.Size = new Size(105, 48);
            btnKullaniciGuncelle.TabIndex = 3;
            btnKullaniciGuncelle.Text = "Güncelle";
            btnKullaniciGuncelle.UseVisualStyleBackColor = false;
            // 
            // btnKullaniciSil
            // 
            btnKullaniciSil.BackColor = Color.FromArgb(16, 108, 239);
            btnKullaniciSil.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnKullaniciSil.ForeColor = Color.WhiteSmoke;
            btnKullaniciSil.Location = new Point(234, 12);
            btnKullaniciSil.Name = "btnKullaniciSil";
            btnKullaniciSil.Size = new Size(105, 48);
            btnKullaniciSil.TabIndex = 3;
            btnKullaniciSil.Text = "Sil";
            btnKullaniciSil.UseVisualStyleBackColor = false;
            // 
            // dgvKullanicilar
            // 
            dgvKullanicilar.AllowUserToAddRows = false;
            dgvKullanicilar.AllowUserToDeleteRows = false;
            dgvKullanicilar.AllowUserToResizeColumns = false;
            dgvKullanicilar.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.Gainsboro;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.Gray;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(239, 147, 16);
            dataGridViewCellStyle1.SelectionForeColor = Color.LightGray;
            dgvKullanicilar.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvKullanicilar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvKullanicilar.BackgroundColor = Color.WhiteSmoke;
            dgvKullanicilar.BorderStyle = BorderStyle.None;
            dgvKullanicilar.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvKullanicilar.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(16, 108, 239);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(239, 147, 16);
            dataGridViewCellStyle2.SelectionForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvKullanicilar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvKullanicilar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.WhiteSmoke;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.Gray;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(239, 147, 16);
            dataGridViewCellStyle3.SelectionForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvKullanicilar.DefaultCellStyle = dataGridViewCellStyle3;
            dgvKullanicilar.Dock = DockStyle.Fill;
            dgvKullanicilar.EnableHeadersVisualStyles = false;
            dgvKullanicilar.GridColor = Color.LightGray;
            dgvKullanicilar.Location = new Point(0, 0);
            dgvKullanicilar.Name = "dgvKullanicilar";
            dgvKullanicilar.ReadOnly = true;
            dgvKullanicilar.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(235, 162, 59);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(16, 108, 239);
            dataGridViewCellStyle4.SelectionForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvKullanicilar.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvKullanicilar.RowHeadersWidth = 51;
            dgvKullanicilar.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.BackColor = Color.WhiteSmoke;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = Color.Gray;
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(239, 147, 16);
            dataGridViewCellStyle5.SelectionForeColor = Color.WhiteSmoke;
            dgvKullanicilar.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dgvKullanicilar.RowTemplate.Height = 29;
            dgvKullanicilar.Size = new Size(800, 377);
            dgvKullanicilar.TabIndex = 4;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.FixedPanel = FixedPanel.Panel1;
            splitContainer1.IsSplitterFixed = true;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(btnKullaniciEkle);
            splitContainer1.Panel1.Controls.Add(btnKullaniciGuncelle);
            splitContainer1.Panel1.Controls.Add(btnKullaniciSil);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(dgvKullanicilar);
            splitContainer1.Size = new Size(800, 450);
            splitContainer1.SplitterDistance = 69;
            splitContainer1.TabIndex = 5;
            // 
            // FrmKullanicilar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(splitContainer1);
            Name = "FrmKullanicilar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kullanıcılar";
            Load += FrmKullanicilar_Load;
            ((System.ComponentModel.ISupportInitialize)dgvKullanicilar).EndInit();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btnKullaniciEkle;
        private Button btnKullaniciGuncelle;
        private Button btnKullaniciSil;
        private DataGridView dgvKullanicilar;
        private SplitContainer splitContainer1;
    }
}