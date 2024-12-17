using System;
using System.Linq;
using System.Windows.Forms;

namespace QuanLyLopHoc
{
    public partial class frmQuanLyHocSinh : Form
    {
        public frmQuanLyHocSinh()
        {
            InitializeComponent();
            btnFind.ItemClick += btnFind_ItemClick;
            btnThem.ItemClick += btnThem_ItemClick;
            btnFilter.ItemClick += BtnFilter_ItemClick;
            dgvHocSinh.UserDeletingRow += dgvHocSinh_UserDeletingRow;
            dgvHocSinh.CellEndEdit += dgvHocSinh_CellEndEdit;
            dgvHocSinh.SelectionChanged += dgvHocSinh_SelectionChanged;
        }

        // Sự kiện xóa dòng trong DataGridView
        private void dgvHocSinh_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            try
            {
                string studentCode = e.Row.Cells["MaHS"].Value?.ToString();

                if (string.IsNullOrEmpty(studentCode))
                {
                    MessageBox.Show("Không thể xác định mã học sinh để xóa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    e.Cancel = true;
                    return;
                }

                using (var db = new DataClasses1DataContext())
                {
                    var studentToDelete = db.HOCSINHs.SingleOrDefault(hs => hs.MaHS == studentCode);
                    if (studentToDelete != null)
                    {
                        db.HOCSINHs.DeleteOnSubmit(studentToDelete);
                        db.SubmitChanges();
                        MessageBox.Show("Xóa học sinh thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy học sinh trong cơ sở dữ liệu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        e.Cancel = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi khi xóa học sinh: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
            }
        }

        // Sự kiện chỉnh sửa dữ liệu trong ô của DataGridView
        private void dgvHocSinh_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string studentCode = dgvHocSinh.Rows[e.RowIndex].Cells["MaHS"].Value?.ToString();

                if (string.IsNullOrEmpty(studentCode))
                {
                    MessageBox.Show("Không thể xác định mã học sinh để cập nhật.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                using (var db = new DataClasses1DataContext())
                {
                    var studentToUpdate = db.HOCSINHs.SingleOrDefault(hs => hs.MaHS == studentCode);
                    if (studentToUpdate != null)
                    {
                        var editedColumnName = dgvHocSinh.Columns[e.ColumnIndex].Name;

                        switch (editedColumnName)
                        {
                            case "HoTen":
                                studentToUpdate.HoTen = dgvHocSinh.Rows[e.RowIndex].Cells["HoTen"].Value?.ToString().Trim();
                                break;
                            case "NgaySinh":
                                studentToUpdate.NgaySinh = DateTime.Parse(dgvHocSinh.Rows[e.RowIndex].Cells["NgaySinh"].Value?.ToString() ?? "01/01/2000");
                                break;
                            case "GioiTinh":
                                studentToUpdate.GioiTinh = dgvHocSinh.Rows[e.RowIndex].Cells["GioiTinh"].Value?.ToString().Trim();
                                break;
                            case "DiaChi":
                                studentToUpdate.DiaChi = dgvHocSinh.Rows[e.RowIndex].Cells["DiaChi"].Value?.ToString().Trim();
                                break;
                            case "MaLop":
                                studentToUpdate.MaLop = dgvHocSinh.Rows[e.RowIndex].Cells["MaLop"].Value?.ToString().Trim();
                                break;
                        }

                        db.SubmitChanges();
                        MessageBox.Show("Cập nhật thông tin học sinh thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy học sinh trong cơ sở dữ liệu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi khi cập nhật thông tin: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Sự kiện chọn ô để tự động chọn cả dòng
        private void dgvHocSinh_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvHocSinh.CurrentCell != null)
            {
                dgvHocSinh.Rows[dgvHocSinh.CurrentCell.RowIndex].Selected = true;
            }
        }

        private void BtnFilter_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
        }

        private void frmQuanLyHocSinh_Load(object sender, EventArgs e)
        {
            LoadStudentData();
        }

        // Hàm tải dữ liệu học sinh vào DataGridView
        private void LoadStudentData()
        {
            try
            {
                using (var db = new DataClasses1DataContext())
                {
                    var studentData = db.HOCSINHs
                        .Select(hs => new
                        {
                            MaHS = hs.MaHS,
                            HoTen = hs.HoTen,
                            NgaySinh = hs.NgaySinh,
                            GioiTinh = hs.GioiTinh,
                            DiaChi = hs.DiaChi,
                            MaLop = hs.MaLop
                        })
                        .ToList();

                    dgvHocSinh.DataSource = studentData;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi khi tải dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // Tìm kiếm học sinh
        private void btnFind_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                using (var db = new DataClasses1DataContext())
                {
                    var query = db.HOCSINHs.AsQueryable();

                    string maHS = txtMaHS.EditValue?.ToString().Trim();
                    string hoTen = txtHoTen.EditValue?.ToString().Trim();
                    string gioiTinh = txtGioiTinh.EditValue?.ToString().Trim();
                    string diaChi = txtDiaChi.EditValue?.ToString().Trim();
                    string maLop = txtMaLop.EditValue?.ToString().Trim();

                    if (!string.IsNullOrEmpty(maHS))
                        query = query.Where(hs => hs.MaHS.Contains(maHS));
                    if (!string.IsNullOrEmpty(hoTen))
                        query = query.Where(hs => hs.HoTen.Contains(hoTen));
                    if (!string.IsNullOrEmpty(gioiTinh))
                        query = query.Where(hs => hs.GioiTinh.Contains(gioiTinh));
                    if (!string.IsNullOrEmpty(diaChi))
                        query = query.Where(hs => hs.DiaChi.Contains(diaChi));
                    if (!string.IsNullOrEmpty(maLop))
                        query = query.Where(hs => hs.MaLop == maLop);

                    var studentData = query
                        .Select(hs => new
                        {
                            MaHS = hs.MaHS,
                            HoTen = hs.HoTen,
                            NgaySinh = hs.NgaySinh,
                            GioiTinh = hs.GioiTinh,
                            DiaChi = hs.DiaChi,
                            MaLop = hs.MaLop
                        })
                        .ToList();

                    if (!studentData.Any())
                    {
                        MessageBox.Show("Không tìm thấy học sinh nào!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    dgvHocSinh.DataSource = studentData;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi khi tìm kiếm: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Thêm học sinh mới
        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                using (var db = new DataClasses1DataContext())
                {
                    var newStudent = new HOCSINH
                    {
                        MaHS = txtMaHS.EditValue?.ToString().Trim(),
                        HoTen = txtHoTen.EditValue?.ToString().Trim(),
                        NgaySinh = DateTime.Parse(txtNgaySinh.EditValue?.ToString() ?? "01/01/2000"),
                        GioiTinh = txtGioiTinh.EditValue?.ToString().Trim(),
                        DiaChi = txtDiaChi.EditValue?.ToString().Trim(),
                        MaLop = txtMaLop.EditValue?.ToString().Trim()
                    };

                    db.HOCSINHs.InsertOnSubmit(newStudent);
                    db.SubmitChanges();

                    MessageBox.Show("Thêm học sinh thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadStudentData();  // Cập nhật lại DataGridView
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi khi thêm học sinh: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Lọc học sinh theo tên lớp
        private void btnFilter_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                using (var db = new DataClasses1DataContext())
                {
                    string className = txtFilterTenLop.EditValue?.ToString().Trim();

                    if (string.IsNullOrEmpty(className))
                    {
                        MessageBox.Show("Vui lòng nhập tên lớp để lọc!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Lấy danh sách các lớp có tên lớp phù hợp
                    var classList = db.LOPs
                                      .Where(lop => lop.TenLop.Contains(className))
                                      .Select(lop => lop.MaLop)
                                      .ToList();

                    if (!classList.Any())
                    {
                        MessageBox.Show("Không tìm thấy lớp học này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    // Lọc học sinh thuộc các lớp đã tìm thấy
                    var studentData = db.HOCSINHs
                                        .Where(hs => classList.Contains(hs.MaLop))
                                        .Select(hs => new
                                        {
                                            MaHS = hs.MaHS,
                                            HoTen = hs.HoTen,
                                            NgaySinh = hs.NgaySinh,
                                            GioiTinh = hs.GioiTinh,
                                            DiaChi = hs.DiaChi,
                                            MaLop = hs.MaLop
                                        })
                                        .ToList();

                    if (!studentData.Any())
                    {
                        MessageBox.Show("Không tìm thấy học sinh nào trong lớp này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    // Hiển thị dữ liệu lên DataGridView
                    dgvHocSinh.DataSource = studentData;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi khi lọc học sinh: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void dgvHocSinh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtHoTen_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (dgvHocSinh.CurrentCell == null)
                {
                    MessageBox.Show("Vui lòng chọn ô chứa mã học sinh cần xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Lấy mã học sinh từ ô hiện tại
                string maHS = dgvHocSinh.CurrentCell.Value?.ToString().Trim();

                if (string.IsNullOrEmpty(maHS))
                {
                    MessageBox.Show("Không tìm thấy mã học sinh.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Xác nhận xóa học sinh
                DialogResult confirmResult = MessageBox.Show("Bạn có chắc chắn muốn xóa học sinh này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmResult != DialogResult.Yes) return;

                // Xóa học sinh trong database
                using (var db = new DataClasses1DataContext())
                {
                    var studentToDelete = db.HOCSINHs.SingleOrDefault(hs => hs.MaHS == maHS);

                    if (studentToDelete != null)
                    {
                        db.HOCSINHs.DeleteOnSubmit(studentToDelete);
                        db.SubmitChanges();

                        MessageBox.Show("Xóa học sinh thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadStudentData(); // Tải lại dữ liệu lên DataGridView
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy học sinh trong cơ sở dữ liệu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi khi xóa học sinh: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvHocSinh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Đảm bảo chỉ số hàng hợp lệ
            {
                // Lấy dòng hiện tại được chọn
                DataGridViewRow row = dgvHocSinh.Rows[e.RowIndex];

                // Đưa dữ liệu từ dòng được chọn vào TextBox
                txtMaHS.EditValue = row.Cells["MaHS"].Value?.ToString().Trim();
                txtHoTen.EditValue = row.Cells["HoTen"].Value?.ToString().Trim();
                txtNgaySinh.EditValue = row.Cells["NgaySinh"].Value?.ToString().Trim();
                txtGioiTinh.EditValue = row.Cells["GioiTinh"].Value?.ToString().Trim();
                txtDiaChi.EditValue = row.Cells["DiaChi"].Value?.ToString().Trim();
                txtMaLop.EditValue = row.Cells["MaLop"].Value?.ToString().Trim();
            }
        }

        private void btnEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                string maHS = txtMaHS.EditValue?.ToString().Trim();

                if (string.IsNullOrEmpty(maHS))
                {
                    MessageBox.Show("Mã học sinh không được để trống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                using (var db = new DataClasses1DataContext())
                {
                    var studentToUpdate = db.HOCSINHs.SingleOrDefault(hs => hs.MaHS == maHS);

                    if (studentToUpdate != null)
                    {
                        // Cập nhật các thuộc tính khác (không thay đổi MaHS)
                        studentToUpdate.HoTen = txtHoTen.EditValue?.ToString().Trim();
                        studentToUpdate.NgaySinh = DateTime.Parse(txtNgaySinh.EditValue?.ToString() ?? "01/01/2000");
                        studentToUpdate.GioiTinh = txtGioiTinh.EditValue?.ToString().Trim();
                        studentToUpdate.DiaChi = txtDiaChi.EditValue?.ToString().Trim();
                        studentToUpdate.MaLop = txtMaLop.EditValue?.ToString().Trim();

                        db.SubmitChanges();

                        MessageBox.Show("Cập nhật thông tin học sinh thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadStudentData(); // Tải lại dữ liệu lên DataGridView
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy học sinh trong cơ sở dữ liệu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi khi cập nhật thông tin: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



    }
}
