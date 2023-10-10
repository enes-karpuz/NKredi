using Nkredi.BusinessLogicLayer;
using NKredi.DataAccessLayer.Entities;

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
            TxtEPosta.Text = "enes@nkredi.com";
            TxtSifre.Text = "123456";
            SKullanici kullaniciService = new SKullanici();
            FrmAnaMenu frmAnaMenu = new FrmAnaMenu();
            frmAnaMenu.Hide();

            if (kullaniciService.IsPasswordCorrect(new Kullanici() { email = TxtEPosta.Text, Sifre = TxtSifre.Text }))
            {
                FrmAnaSayfa frmAnaSayfa = new FrmAnaSayfa();
                MessageBox.Show("Başarılı Giriş");
                Hide();
                frmAnaSayfa.ShowDialog();
            }
            else
            {
                MessageBox.Show("Email veya Şifre Hatalı!");
                Close();
                frmAnaMenu.ShowDialog();
            }
        }
    }
}
