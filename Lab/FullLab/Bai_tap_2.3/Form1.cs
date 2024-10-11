using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DocSo
{
    public partial class frmDocSo : Form
    {
        public frmDocSo()
        {
            InitializeComponent();
        }

        private void txtNhapSo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNhapSo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string text = txtNhapSo.Text;
                string textRes = "";
                int number = Convert.ToInt32(text);

                switch (number)
                {
                    case 0: 
                        textRes = "Không";
                        break;
                    case 1:
                        textRes = "Một";
                        break;
                    case 2:
                        textRes = "Hai";
                        break;
                    case 3:
                        textRes = "Ba";
                        break;
                    case 4:
                        textRes = "Bốn";
                        break;
                    case 5:
                        textRes = "Năm";
                        break;
                    case 6:
                        textRes = "Sáu";
                        break;
                    case 7:
                        textRes = "Bảy";
                        break;
                    case 8:
                        textRes = "Tám";
                        break;
                    case 9:
                        textRes = "Chín";
                        break;
                }

                txtKetQua.Text = textRes;       
            }
        }
    }
}
