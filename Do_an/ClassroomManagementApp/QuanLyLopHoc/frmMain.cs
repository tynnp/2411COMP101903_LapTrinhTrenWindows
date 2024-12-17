using QuanLyLopHoc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanLyLopHoc
{
    public partial class frmMain : DevExpress.XtraEditors.XtraForm
    {
        private Form currenFormChild;
        private Timer timer;
        public frmMain(string user, int level)
        {
            InitializeComponent();
            btnOwnControl.Text = "Xin chào, " + user;

            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            timer.Start();

            if (level == 1 || level == 2)
            {
                accQuanLyTaiKhoan.Enabled = false;
            }

            if (level == 1)
            {
                accNhapDiemHocsinh.Enabled = false;
            }

            if (level == 2)
            {
                accQuanLyGiaoVien.Enabled = false;
                accQuanLyGiangDay.Enabled = false;
            }

        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            barTime.Caption = DateTime.Now.ToString("HH:mm:ss");
            barDate.Caption = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void OpenChildForm(Form childForm)
        {
            if (currenFormChild != null)
            {
                currenFormChild.Close();
            }

            // Test truyền dữ liệu
            lblTenFormDangMo.Text = childForm.Text;

            currenFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelBody.Controls.Add(currenFormChild);
            panelBody.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void accQuanLyHocSinh_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmQuanLyHocSinh());
        }

        private void accQuanLyGiaoVien_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmQuanLyGiaoVien());
        }

        private void accQuanLyLichDay_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmQuanLyLichDay());
        }

        private void accNhapDiemHocSinh_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmNhapDiemHocSinh());
        }


        private void accQuanLyTaiKhoan_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmQuanLyTaiKhoan());
        }

        private void accHuongDanSuDung_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmHuongDanSuDung());
        }

        private void accGioiThieu_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmGioiThieu());
        }

        private void btnOwnControl_Click(object sender, EventArgs e)
        {
            popupOwnControl.Appearance.BackColor = Color.White;
            Point popupPosition = btnOwnControl.PointToScreen(new Point(0, btnOwnControl.Height + 15));
            popupOwnControl.ShowPopup(popupPosition);
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            OpenChildForm (new frmDoiMatKhau ());

        }


        private void btnProfile_Click(object sender, EventArgs e)
        {
            OpenChildForm (new frmHoSoCuaToi ());
        }
    }
}
