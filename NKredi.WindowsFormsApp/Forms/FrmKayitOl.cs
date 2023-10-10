using Nkredi.BusinessLogicLayer;
using NKredi.DataAccessLayer.Entities;

namespace NKredi.WindowsFormsApp.Forms
{
    public partial class FrmKayitOl : Form
    {
        public FrmKayitOl()
        {
            InitializeComponent();
        }

        private void FrmKayitOl_Load(object sender, EventArgs e)
        {
            SKullaniciTipi kullaniciTipiServisi = new();
            CmbTipi.DataSource = kullaniciTipiServisi.GetirKullaniciTipiListesi();
            CmbTipi.DisplayMember = "Tipi";
            CmbTipi.ValueMember = "Id";
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {            
            Kullanici kullanici = new()
            {
                Tipi = CmbTipi.SelectedIndex,
                Ad = TxtAdi.Text,
                Soyad = TxtSoyadi.Text,
                email = TxtEPosta.Text,
                Sifre = TxtSifre.Text,
                DogumTarihi = DtpDogumTarihi.Value
            };

            SKullanici kullaniciServisi = new();
            if (kullaniciServisi.EkleKullanici(kullanici))
            {
                MessageBox.Show("Kayıt başarıyla oluşturuldu.");
            }
            else
            {
                MessageBox.Show("Hata, kayıt oluşturulamadı.");
            }
        }
    }
}
