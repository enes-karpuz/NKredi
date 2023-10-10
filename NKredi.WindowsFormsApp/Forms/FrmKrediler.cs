using Nkredi.BusinessLogicLayer;
using NKredi.DataAccessLayer.Entities;
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

namespace NKredi.WindowsFormsApp.Forms
{
    public partial class FrmKrediler : Form
    {
        SKredi sKredi = new SKredi();
        SKrediOranlari sKrediOranlari = new SKrediOranlari();

        public FrmKrediler()
        {
            InitializeComponent();
            sKredi.GetirKredi();
            dgvKrediler.DataSource = sKredi.GetirKredi();

            var source = new BindingSource();
            List<Kredi> kredi = new List<Kredi>();
            source.DataSource = kredi;
            dgvKrediler.DataSource = source;
        }

        private void btnKrediEkle_Click(object sender, EventArgs e)
        {
            FrmKrediEkle frmKrediEkle = new FrmKrediEkle();
            frmKrediEkle.ShowDialog();
        }
    }
}