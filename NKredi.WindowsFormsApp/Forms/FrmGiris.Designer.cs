namespace NKredi.WindowsFormsApp.Forms
{
    partial class FrmGiris
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
            TxtSifre = new TextBox();
            label4 = new Label();
            TxtEPosta = new TextBox();
            label3 = new Label();
            BtnGiris = new Button();
            SuspendLayout();
            // 
            // TxtSifre
            // 
            TxtSifre.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TxtSifre.Location = new Point(120, 65);
            TxtSifre.Name = "TxtSifre";
            TxtSifre.PasswordChar = '*';
            TxtSifre.Size = new Size(222, 34);
            TxtSifre.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(61, 68);
            label4.Name = "label4";
            label4.Size = new Size(51, 28);
            label4.TabIndex = 12;
            label4.Text = "Şifre";
            // 
            // TxtEPosta
            // 
            TxtEPosta.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TxtEPosta.Location = new Point(120, 25);
            TxtEPosta.Name = "TxtEPosta";
            TxtEPosta.Size = new Size(222, 34);
            TxtEPosta.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(37, 28);
            label3.Name = "label3";
            label3.Size = new Size(77, 28);
            label3.TabIndex = 10;
            label3.Text = "E-Posta";
            // 
            // BtnGiris
            // 
            BtnGiris.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            BtnGiris.Location = new Point(37, 105);
            BtnGiris.Name = "BtnGiris";
            BtnGiris.Size = new Size(305, 70);
            BtnGiris.TabIndex = 15;
            BtnGiris.Text = "Giriş";
            BtnGiris.UseVisualStyleBackColor = true;
            BtnGiris.Click += BtnGiris_Click;
            // 
            // FrmGiris
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(379, 201);
            Controls.Add(BtnGiris);
            Controls.Add(TxtSifre);
            Controls.Add(label4);
            Controls.Add(TxtEPosta);
            Controls.Add(label3);
            Name = "FrmGiris";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Giriş Yap";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TxtSifre;
        private Label label4;
        private TextBox TxtEPosta;
        private Label label3;
        private Button BtnGiris;
    }
}