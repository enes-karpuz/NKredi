using NKredi.WindowsFormsApp.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NKredi.WindowsFormsApp
{
    public partial class FrmAnaMenu : Form
    {
        public FrmAnaMenu()
        {
            InitializeComponent();
        }

        private void BtnGirisYap_Click(object sender, EventArgs e)
        {
            FrmGiris frmGiris = new();
            frmGiris.ShowDialog();
        }

        private void BtnKayitOl_Click(object sender, EventArgs e)
        {
            FrmKayitOl frmKayitOl = new();
            frmKayitOl.ShowDialog();
        }

        private void LblHosgeldiniz_Click(object sender, EventArgs e)
        {

        }
    }
}
