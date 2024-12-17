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
    public partial class frmEditTaiKhoan : DevExpress.XtraEditors.XtraForm
    {
        private GIAOVIEN selectedTeacher;

        public frmEditTaiKhoan(GIAOVIEN giaovien)
        {
            InitializeComponent();
            selectedTeacher = giaovien;
            LoadTeacherData();
        }

        private void LoadTeacherData()
        {
            // Hiển thị thông tin giáo viên trong các textbox
            txtHoTen.Text = selectedTeacher.HoTen;
            txtEmail.Text = selectedTeacher.Email;
            dateSinhNhat.DateTime = selectedTeacher.NgaySinh; 
            txtGioiTinh.Text = selectedTeacher.GioiTinh;
            txtSoDienThoai.Text = selectedTeacher.SoDienThoai;
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            try
            {
                using (DataClasses1DataContext db = new DataClasses1DataContext())
                {
                    // Tìm giáo viên trong database
                    var teacher = db.GIAOVIENs.SingleOrDefault(gv => gv.MaGV == selectedTeacher.MaGV);
                    if (teacher != null)
                    {
                        // Cập nhật thông tin từ textbox
                        teacher.HoTen = txtHoTen.Text;
                        teacher.Email = txtEmail.Text;
                        teacher.NgaySinh = dateSinhNhat.DateTime;
                        teacher.GioiTinh = txtGioiTinh.Text;
                        teacher.SoDienThoai = txtSoDienThoai.Text;

                        // Lưu thay đổi vào cơ sở dữ liệu
                        db.SubmitChanges();

                        MessageBox.Show("Thông tin đã được cập nhật thành công!", "Thông báo");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy giáo viên này trong cơ sở dữ liệu!", "Thông báo");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra: {ex.Message}", "Lỗi");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                using (DataClasses1DataContext db = new DataClasses1DataContext())
                {
                    // Tìm giáo viên trong database
                    var teacher = db.GIAOVIENs.SingleOrDefault(gv => gv.MaGV == selectedTeacher.MaGV);
                    if (teacher != null)
                    {
                        // Xóa tài khoản liên kết trước (nếu có)
                        var account = db.TAIKHOANs.SingleOrDefault(tk => tk.MaGV == teacher.MaGV);
                        if (account != null)
                        {
                            db.TAIKHOANs.DeleteOnSubmit(account);
                        }

                        // Xóa giáo viên
                        db.GIAOVIENs.DeleteOnSubmit(teacher);
                        db.SubmitChanges();

                        MessageBox.Show("Giáo viên và tài khoản liên quan đã được xóa!", "Thông báo");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy giáo viên này trong cơ sở dữ liệu!", "Thông báo");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra: {ex.Message}", "Lỗi");
            }
        }
    }
}