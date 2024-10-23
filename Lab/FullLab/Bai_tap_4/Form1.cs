namespace TruyenDuLieu
{
    public partial class FrmNhapLieu : Form
    {
        public FrmNhapLieu()
        {
            InitializeComponent();
        }

        private void BtnKhoiTao_Click(object sender, EventArgs e)
        {
            int soCot = int.Parse(TxtSoCot.Text);
            int soDong = int.Parse(TxtSoDong.Text);
            var form = new FrmXuat(soDong, soCot);
            form.ShowDialog();
        }
    }
}
