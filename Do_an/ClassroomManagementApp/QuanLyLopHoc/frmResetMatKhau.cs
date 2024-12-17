using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace QuanLyLopHoc
{
    public partial class frmResetMatKhau : DevExpress.XtraEditors.XtraForm
    {
        private TAIKHOAN currentAccount;
        public frmResetMatKhau(TAIKHOAN taikhoan)
        {
            InitializeComponent();
            currentAccount = taikhoan;
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if(txtMatKhauMoi.Text == "" || txtRepeat.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo");
                return;
            }
            if(txtRepeat.Text != txtMatKhauMoi.Text )
            {
                MessageBox.Show("Mật khẩu chưa trùng khớp, hãy nhập lại!", "Thông báo");
                return;
            }
            string matKhauMoi = txtMatKhauMoi.Text;

            // Mã hóa mật khẩu mới
            MD5 md5 = MD5.Create();
            byte[] inputBytes = Encoding.ASCII.GetBytes(matKhauMoi + currentAccount.Username);
            byte[] hashBytes = md5.ComputeHash(inputBytes);

            using (DataClasses1DataContext db = new DataClasses1DataContext())
            {
                TAIKHOAN tk = db.TAIKHOANs.SingleOrDefault(p => p.Username == currentAccount.Username);
                if (tk != null)
                {
                    tk.Password = hashBytes;
                    db.SubmitChanges();
                }
            }

            MessageBox.Show("Đổi mật khẩu thành công!", "Thông báo");
            this.Close();
        }


    }
    }
