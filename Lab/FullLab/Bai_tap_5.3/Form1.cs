namespace NhaKhoa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            TxtTenKhachHang.Text = TxtTongTien.Text = "";
            ChBoxCaoVoi.Checked = false;
            ChBoxTayTrang.Checked = false;
            NrNhoRang.Value = NrTramRang.Value = 0;
        }

        private void BtnThoat_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("Thoát chương trình?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void BtnTinhTien_Click(object sender, EventArgs e)
        {
            long tienCaoVoi, tienTayTrang, tienNhoRang, tienTramRang, tongTien;
            if (ChBoxCaoVoi.Checked == true)
            {
                tienCaoVoi = 100000;
            }
            else
            {
                tienCaoVoi = 0;
            }

            if (ChBoxTayTrang.Checked == true)
            {
                tienTayTrang = 1500000;
            }
            else
            {
                tienTayTrang = 0;
            }

            tienNhoRang = 150000 * (long)NrNhoRang.Value;
            tienTramRang = 200000 * (long)NrTramRang.Value;
            tongTien = tienCaoVoi + tienNhoRang + tienTramRang + tienTayTrang;

            TxtTongTien.Text = tongTien.ToString();
        }

        private void NrNhoRang_ValueChanged(object sender, EventArgs e)
        {
            NrNhoRang.Maximum = 35;
            NrNhoRang.Minimum = 0;
        }

        private void NrTramRang_ValueChanged(object sender, EventArgs e)
        {
            NrTramRang.Maximum = 35;
            NrNhoRang.Minimum = 0;
        }
    }
}
