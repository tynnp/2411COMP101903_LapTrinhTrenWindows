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
                int number;

                if (!int.TryParse(text, out number) || number < 0 || number > 999)
                {
                    txtKetQua.Text = "Vui lòng nhập số từ 0 đến 999";
                    return;
                }

                string textRes = DocSoBaChuSo(number);
                txtKetQua.Text = textRes;
            }
        }

        private string DocSoChu(int number)
        {
            switch (number)
            {
                case 0: return "không";
                case 1: return "một";
                case 2: return "hai";
                case 3: return "ba";
                case 4: return "bốn";
                case 5: return "năm";
                case 6: return "sáu";
                case 7: return "bảy";
                case 8: return "tám";
                case 9: return "chín";
                default: return "";
            }
        }

        private string DocSoBaChuSo(int number)
        {
            int tram = number / 100;         
            int chuc = (number / 10) % 10;   
            int donVi = number % 10;         

            string result = "";

            if (tram > 0)
            {
                result += DocSoChu(tram) + " trăm";
            }

            if (chuc > 0)
            {
                if (chuc == 1)
                {
                    result += " mười";
                }
                else
                {
                    result += " " + DocSoChu(chuc) + " mươi";
                }
            }
            else if (tram > 0 && donVi > 0)
            {
                result += " lẻ";
            }

            if (donVi > 0)
            {
                if (chuc == 1 && donVi == 5)
                {
                    result += " lăm";
                }
                else if (chuc > 1 && donVi == 1)
                {
                    result += " mốt";
                }
                else
                {
                    result += " " + DocSoChu(donVi);
                }
            }

            if (number == 0)
            {
                result = "không";
            }

            return result.Trim();
        }
    }
}
