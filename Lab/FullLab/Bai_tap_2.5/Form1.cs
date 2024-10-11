using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TinhLuyThua
{
    public partial class frmTongLuyThua : Form
    {
        public frmTongLuyThua()
        {
            InitializeComponent();
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txtSoN.Text);
            double x = double.Parse(txtSoX.Text);

            string ketQua1 = "X";
            string ketQua2 = x.ToString();
            string ketQua3 = x.ToString();
            double ketQua4 = x;

            for (int i = 2; i <= n; i++)
            {
                ketQua1 += $" + X^{i}";
                ketQua2 += $" + {x}^{i}";
                ketQua3 += $" + {Math.Pow(x, i)}";
                ketQua4 += Math.Pow(x, i);
            }

            txtKetQua1.Text = ketQua1;
            txtKetQua2.Text = ketQua2;
            txtKetQua3.Text = ketQua3;
            txtKetQua4.Text = ketQua4.ToString();
        }
    }
}
