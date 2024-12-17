using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace QuanLyLopHoc
{
    public partial class frmDangNhap : DevExpress.XtraEditors.XtraForm
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void btnQuenMatKhau_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmQuenMatKhau frmQuenMatKhau = new frmQuenMatKhau();
            frmQuenMatKhau.ShowDialog();
            this.Show();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string user = txtUsername.Text;
            string password = txtPassword.Text;

            if (user == "" && password == "")
            {
                MessageBox.Show("Vui lòng nhập thông tin!", "Thông báo", MessageBoxButtons.OK);
                txtUsername.Focus();
            }
            else
            {
                DataClasses1DataContext db = new DataClasses1DataContext();

                // Lấy thông tin tài khoản từ database
                TAIKHOAN tk = db.TAIKHOANs.SingleOrDefault(p => p.Username == user);

                // Kiểm tra tài khoản tồn tại
                if (tk != null)
                {
                    GIAOVIEN gv = db.GIAOVIENs.SingleOrDefault(p => p.MaGV == tk.MaGV);
                    MD5 md5 = MD5.Create();
                    byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(password + user);
                    byte[] hashBytes = md5.ComputeHash(inputBytes);

                    // So sánh mật khẩu
                    if (tk.Password == hashBytes) // Dùng SequenceEqual để so sánh mảng byte
                    {
                        if (chkGhiNho.Checked)
                        {
                            Properties.Settings.Default.RememberMe = true;
                            Properties.Settings.Default.UserName = user;
                            Properties.Settings.Default.Password = password; // Lưu mật khẩu
                            Properties.Settings.Default.Save();
                        }
                        else
                        {
                            Properties.Settings.Default.RememberMe = false;
                            Properties.Settings.Default.UserName = "";
                            Properties.Settings.Default.Password = "";
                            Properties.Settings.Default.Save();
                        }

                        // Kiểm tra quyền truy cập (Level)
                        if (tk.Level == 0)
                        {
                            MessageBox.Show("Xin chào admin", "Thông báo", MessageBoxButtons.OK);
                            this.Hide();
                            frmMain frm = new frmMain(gv.HoTen, 0);
                            frm.ShowDialog();
                            this.Show();
                        }
                        else if (tk.Level == 1)
                        {
                            MessageBox.Show("Xin chào giáo vụ!", "Thông báo", MessageBoxButtons.OK);
                            this.Hide();
                            frmMain frm = new frmMain(gv.HoTen, 1);
                            frm.ShowDialog();
                            this.Show();
                        }
                        else if (tk.Level == 2)
                        {
                            MessageBox.Show("Xin chào giáo viên!", "Thông báo", MessageBoxButtons.OK);
                            this.Hide();
                            frmMain frm = new frmMain(gv.HoTen, 2);
                            frm.ShowDialog();
                            this.Show();
                        }

                        this.Close();
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Thông tin không hợp lệ!", "Thông báo", MessageBoxButtons.OK);
                        txtUsername.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Tên đăng nhập không tồn tại!", "Thông báo", MessageBoxButtons.OK);
                    txtUsername.Focus();
                }
            }
        }


        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.RememberMe)
            {
                // Điền thông tin tài khoản và mật khẩu đã lưu
                txtUsername.Text = Properties.Settings.Default.UserName ?? "";
                txtPassword.Text = Properties.Settings.Default.Password ?? "";
                chkGhiNho.Checked = true;
            }
            else
            {
                // Nếu không bật ghi nhớ, để trống các trường
                txtUsername.Text = "";
                txtPassword.Text = "";
                chkGhiNho.Checked = false;
            }

            DataClasses1DataContext db = new DataClasses1DataContext();
            if (!db.TAIKHOANs.Any())
            {

                MD5 md5 = MD5.Create();
                byte[] inputBytes = Encoding.ASCII.GetBytes("1234" + "admin");
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                string maGV = Guid.NewGuid().ToString().Substring(0, 20);

                TAIKHOAN adminUser = new TAIKHOAN
                {
                    Username = "admin",
                    Password = hashBytes,
                    DateCreated = DateTime.Now,
                    Level = 0,
                    MaGV = maGV
                };

                GIAOVIEN gv = new GIAOVIEN
                {
                    MaGV = maGV,
                    HoTen = "Cao Vo Tuan Kiet",
                    Email = "admin@gmail.com",
                    NgaySinh = DateTime.Parse("02/20/2005"),
                    GioiTinh = "NAM"
                };

                db.GIAOVIENs.InsertOnSubmit(gv);
                db.TAIKHOANs.InsertOnSubmit(adminUser);
                db.SubmitChanges();
            }
        }
        
    }
}