using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NKredi.WindowsFormApp
{
    public partial class FrmMainMenu : Form
    {
        public FrmMainMenu()
        {
            InitializeComponent();
        }

        private void BtnGetirKullanici_Click(object sender, EventArgs e)
        {
            SKullanici sKullanici = new SKullanici();
            sKullanici.GetirKullaniciListesi();
        }
    }
}
