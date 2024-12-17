using DevExpress.XtraEditors;
using System;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace QuanLyLopHoc
{
    public partial class frmThemTaiKhoan : DevExpress.XtraEditors.XtraForm
    {
        public frmThemTaiKhoan()
        {
            InitializeComponent();
            dateSinhNhat.Properties.MinValue = new DateTime(1950, 1, 1);
            dateSinhNhat.Properties.MaxValue = new DateTime(2000, 12, 31);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text == "" || txtHoTen.Text == "" || txtUsername.Text == "" || txtPassword.Text == "" || dateSinhNhat.Text == "" || txtGioiTinh.Text == "")
            {
                MessageBox.Show("Vui lòng nhập thông tin", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string hoten = txtHoTen.Text;
            string email = txtEmail.Text;
            string magv = Guid.NewGuid().ToString().Substring(0, 20); // Sử dụng GUID để tạo mã giáo viên duy nhất
            string gioitinh = txtGioiTinh.Text;
            DateTime ngaysinh = dateSinhNhat.DateTime;
            int level = -1;
            string selectedValue = comboBoxLV.SelectedItem.ToString();

            if (comboBoxLV.SelectedItem != null && comboBoxLV.SelectedItem.ToString() == "Admin")
            {
                level = 0;
            }
            else if (comboBoxLV.SelectedItem != null && comboBoxLV.SelectedItem.ToString() == "Giáo vụ")
            {
                level = 1;
            }
            else
                level = 2;

            // Mã hóa mật khẩu
            MD5 md5 = MD5.Create();
            byte[] inputBytes = Encoding.ASCII.GetBytes(password + username);
            byte[] hashBytes = md5.ComputeHash(inputBytes);

            // Tạo và thêm dữ liệu vào database
            DataClasses1DataContext db = new DataClasses1DataContext();

            TAIKHOAN tk = new TAIKHOAN
            {
                Username = username,
                Password = hashBytes,
                MaGV = magv,
                DateCreated = DateTime.Now,
                Level = level
            };

            GIAOVIEN gv = new GIAOVIEN
            {
                MaGV = magv,
                HoTen = hoten,
                Email = email,
                NgaySinh = ngaysinh,
                GioiTinh = gioitinh
            };

            db.TAIKHOANs.InsertOnSubmit(tk);
            db.GIAOVIENs.InsertOnSubmit(gv);
            db.SubmitChanges();

            MessageBox.Show("Đã thêm tài khoản thành công!", "Thông báo", MessageBoxButtons.OK);
            this.Close();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
