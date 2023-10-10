using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NKredi.WindowsFormsApp.Forms
{
    public partial class FrmAnaSayfa : Form
    {
        public FrmAnaSayfa()
        {
            InitializeComponent();
        }

        private void FrmAnaSayfa_Load(object sender, EventArgs e)
        {

        }

        private void btnBankalar_Click(object sender, EventArgs e)
        {
            FrmBankalar bankalar = new FrmBankalar();
            bankalar.ShowDialog();
        }

        private void btnKullanici_Click(object sender, EventArgs e)
        {
            FrmKullanicilar kullanicilar = new FrmKullanicilar();
            kullanicilar.ShowDialog();
        }

        private void btnKrediler_Click(object sender, EventArgs e)
        {
            FrmKrediler krediler = new FrmKrediler();
            krediler.ShowDialog();
        }
    }
}
