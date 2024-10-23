using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TruyenDuLieu
{
    public partial class FrmXuat : Form
    {
        const int KCLE = 10;
        const int KCBUTTON = 10;
        const int RONG = 60;
        const int CAO = 60;
        public FrmXuat(int soDong, int soCot)
        {
            InitializeComponent();

            Button button;
            for (int i = 0; i < soDong; i++)
            {
                for (int j = 0; j < soCot; j++)
                {
                    button = new Button();
                    button.Left = KCLE + (KCBUTTON + RONG) * i;
                    button.Top = KCLE + (KCBUTTON + CAO) * j;
                    button.Text = $"{i+1}, {j+1}";
                    button.Height = CAO;
                    button.Width = RONG;
                    button.Click += ClickButton;
                    this.Controls.Add(button);
                }
            }

            this.ClientSize = new Size(KCLE + (KCBUTTON + RONG) * soDong, KCLE + (KCBUTTON + CAO) * soCot);
        }

        public void ClickButton(object sender, EventArgs e)
        {
            MessageBox.Show("Đây là ô (" + (sender as Button).Text + ")"); 
        }
    }
}
