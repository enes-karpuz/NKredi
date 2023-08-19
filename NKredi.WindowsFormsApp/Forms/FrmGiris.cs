using Microsoft.VisualBasic;
using Nkredi.BusinessLogicLayer;
using NKredi.DataAccessLayer;
using NKredi.DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NKredi.WindowsFormsApp.Forms
{
    public partial class FrmGiris : Form
    {
        public FrmGiris()
        {
            InitializeComponent();
        }

        private void BtnGiris_Click(object sender, EventArgs e)
        {
            SKullanici kullaniciService = new SKullanici();
            FrmAnaMenu frmAnaMenu = new FrmAnaMenu();
            frmAnaMenu.Hide();

            
            if (kullaniciService.IsPasswordCorrect(new Kullanici(){ email = TxtEPosta.Text,Sifre = TxtSifre.Text}))
            {
                FrmAnaSayfa frmAnaSayfa = new FrmAnaSayfa();
                MessageBox.Show("Başarılı Giriş");
                Hide();
                frmAnaSayfa.ShowDialog();
            }
            else
            {
                MessageBox.Show("Email ve ya Şifre Hatalı!");
                Close();
                frmAnaMenu.ShowDialog();
            }
            
        }
    }
}
