using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MayTinhCoBan
{
    public partial class frmTinhGiaTri : Form
    {
        public frmTinhGiaTri()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtSoHangThuNhat.Text);
            int b = int.Parse(txtSoHangThuHai.Text);
            double res = 0;

            if (radCong.Checked)
            {
                res = a + b;
            }

            if (radTru.Checked)
            {
                res = a - b;
            }

            if (radNhan.Checked) 
            {
                res = a * b;
            }

            if (radChia.Checked)
            {
                res = (double) a / b;
            }

            txtKetQua.Text = res.ToString();
        }
    }
}
