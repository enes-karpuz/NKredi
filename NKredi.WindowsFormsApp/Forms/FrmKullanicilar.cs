using Nkredi.BusinessLogicLayer;
using NKredi.DataAccessLayer.Entities;

namespace NKredi.WindowsFormsApp.Forms
{
    public partial class FrmKullanicilar : Form
    {
        public FrmKullanicilar()
        {
            InitializeComponent();
        }

        private void FrmKullanicilar_Load(object sender, EventArgs e)
        {
            SKullanici sKullanici = new SKullanici();
            List<Kullanici> kullaniciListesi = sKullanici.GetirKullaniciListesi();

            dgvKullanicilar.DataSource = kullaniciListesi;
            dgvKullanicilar.Columns["Id"].HeaderText = "ID";
            dgvKullanicilar.Columns["Tipi"].HeaderText = "TİPİ";
            dgvKullanicilar.Columns["Ad"].HeaderText = "AD";
            dgvKullanicilar.Columns["Soyad"].HeaderText = "SOYAD";
            dgvKullanicilar.Columns["email"].HeaderText = "EMAİL";
            dgvKullanicilar.Columns["Sifre"].HeaderText = "ŞİFRE";
            dgvKullanicilar.Columns["DogumTarihi"].HeaderText = "DOĞUM TARİHİ";
        }

        private void btnKullaniciEkle_Click(object sender, EventArgs e)
        {
            FrmKullaniciEkle frmKullaniciEkle = new FrmKullaniciEkle();
            frmKullaniciEkle.ShowDialog();
        }
    }
}
