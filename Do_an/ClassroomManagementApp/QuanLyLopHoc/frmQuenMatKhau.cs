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

namespace QuanLyLopHoc
{
    public partial class frmQuenMatKhau : DevExpress.XtraEditors.XtraForm
    {
        public frmQuenMatKhau()
        {
            InitializeComponent();
        }

        private void btnGuiXacNhan_Click(object sender, EventArgs e)
        {
            if(txtUsername.Text == "" || txtEmail.Text == "" || txtHoTen.Text == "" || dateSinhNhat.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo");
                return;
            }
            string user = txtUsername.Text.Trim();
            string email = txtEmail.Text.Trim();
            string hoten = txtHoTen.Text.Trim();
            DateTime ngaysinh = dateSinhNhat.DateTime;

            
            DataClasses1DataContext db = new DataClasses1DataContext();

            try
            {
                // Kiểm tra thông tin người dùng trong cơ sở dữ liệu
                var taiKhoan = db.TAIKHOANs
                 .Join(db.GIAOVIENs,
                       tk => tk.MaGV,
                       gv => gv.MaGV,
                       (tk, gv) => new { tk, gv })
                 .Where(joined => joined.tk.Username == user &&
                                  joined.gv.Email == email &&
                                  joined.gv.HoTen == hoten &&
                                  joined.gv.NgaySinh == ngaysinh)
                 .Select(joined => joined.tk)
                 .SingleOrDefault();



                // Nếu tìm thấy tài khoản, mở form đặt lại mật khẩu
                if (taiKhoan != null)
                {
                    MessageBox.Show("Thông tin xác nhận chính xác. Tiếp tục đặt lại mật khẩu.", "Thông báo");
                    this.Close();
                    frmResetMatKhau frmReset = new frmResetMatKhau(taiKhoan);
                    frmReset.ShowDialog();
                }
                else
                {
                    // Nếu không tìm thấy tài khoản, hiển thị thông báo lỗi
                    MessageBox.Show("Thông tin không chính xác. Vui lòng kiểm tra lại!", "Thông báo");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi");
            }
        }
    }
    }
