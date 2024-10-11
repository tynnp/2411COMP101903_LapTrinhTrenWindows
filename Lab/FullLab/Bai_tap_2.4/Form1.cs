using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TinhTong
{
    public partial class frmTinhTong : Form
    {
        public frmTinhTong()
        {
            InitializeComponent();
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            string text  = txtN.Text;

            if (!string.IsNullOrEmpty(text))
            {
                int number = int.Parse(text);
                string daySo = "1";
                int ketQua = 1;
                
                for (int i = 2; i <= number; i++)
                {
                    ketQua += i;
                    daySo += $"+{i}";
                }

                txtS_1.Text = daySo;
                txtS_2.Text = ketQua.ToString();
            }

            else
            {
                txtN.Text = "Null!";
            }
        }
    }
}
