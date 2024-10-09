using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoLonNhatNhoNhat
{
    public partial class FrmChuongTrinh : Form
    {
        public FrmChuongTrinh()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            double a = double.Parse(txtA.Text);
            double b = double.Parse(txtB.Text);
            double c = double.Parse(txtC.Text); 

            double max = Math.Max(a, Math.Max(b, c));
            double min = Math.Min(a, Math.Min(b, c));

            txtSoLonNhat.Text = max.ToString();
            txtSoNhoNhat.Text = min.ToString();
        }
    }
}
