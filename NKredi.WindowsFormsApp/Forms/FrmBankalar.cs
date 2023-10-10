namespace NKredi.WindowsFormsApp.Forms
{
    public partial class FrmBankalar : Form
    {
        public FrmBankalar()
        {
            InitializeComponent();
        }

        private void btnBankaEkle_Click(object sender, EventArgs e)
        {
            FrmBankaEkle frmBankaEkle = new FrmBankaEkle();
            frmBankaEkle.ShowDialog();
        }
    }
}
