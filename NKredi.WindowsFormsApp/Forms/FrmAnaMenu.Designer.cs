namespace NKredi.WindowsFormsApp
{
    partial class FrmAnaMenu
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
            BtnGirisYap = new Button();
            BtnKayitOl = new Button();
            LblHosgeldiniz = new Label();
            SuspendLayout();
            // 
            // BtnGirisYap
            // 
            BtnGirisYap.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            BtnGirisYap.Location = new Point(35, 122);
            BtnGirisYap.Name = "BtnGirisYap";
            BtnGirisYap.Size = new Size(729, 74);
            BtnGirisYap.TabIndex = 0;
            BtnGirisYap.Text = "Giriş Yap";
            BtnGirisYap.UseVisualStyleBackColor = true;
            BtnGirisYap.Click += BtnGirisYap_Click;
            // 
            // BtnKayitOl
            // 
            BtnKayitOl.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            BtnKayitOl.Location = new Point(35, 202);
            BtnKayitOl.Name = "BtnKayitOl";
            BtnKayitOl.Size = new Size(729, 74);
            BtnKayitOl.TabIndex = 1;
            BtnKayitOl.Text = "Kayıt Ol";
            BtnKayitOl.UseVisualStyleBackColor = true;
            BtnKayitOl.Click += BtnKayitOl_Click;
            // 
            // LblHosgeldiniz
            // 
            LblHosgeldiniz.AutoSize = true;
            LblHosgeldiniz.Font = new Font("Segoe UI", 28.2F, FontStyle.Regular, GraphicsUnit.Point);
            LblHosgeldiniz.Location = new Point(35, 35);
            LblHosgeldiniz.Name = "LblHosgeldiniz";
            LblHosgeldiniz.Size = new Size(729, 62);
            LblHosgeldiniz.TabIndex = 2;
            LblHosgeldiniz.Text = "NKredi Uygulamasına Hoşgeldiniz";
            LblHosgeldiniz.Click += LblHosgeldiniz_Click;
            // 
            // FrmAnaMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(798, 301);
            Controls.Add(LblHosgeldiniz);
            Controls.Add(BtnKayitOl);
            Controls.Add(BtnGirisYap);
            Name = "FrmAnaMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "NKredi";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnGirisYap;
        private Button BtnKayitOl;
        private Label LblHosgeldiniz;
    }
}