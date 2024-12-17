using System;
using System.Linq;
using System.Windows.Forms;

namespace QuanLyLopHoc
{
    public partial class frmQuanLyGiaoVien : Form
    {
        public frmQuanLyGiaoVien()
        {
            InitializeComponent();
            btnFind.ItemClick += btnFind_ItemClick;
            btnThem.ItemClick += btnThem_ItemClick;
            
            dgvGiaoVien.CellEndEdit += dgvGiaoVien_CellEndEdit;
            dgvGiaoVien.SelectionChanged += dgvGiaoVien_SelectionChanged;
        }


        // Sự kiện chỉnh sửa dữ liệu trong ô của DataGridView
        private void dgvGiaoVien_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string teacherCode = dgvGiaoVien.Rows[e.RowIndex].Cells["MaGV"].Value?.ToString();

                if (string.IsNullOrEmpty(teacherCode))
                {
                    MessageBox.Show("Không thể xác định mã giáo viên để cập nhật.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                using (var db = new DataClasses1DataContext())
                {
                    var teacherToUpdate = db.GIAOVIENs.SingleOrDefault(gv => gv.MaGV == teacherCode);
                    if (teacherToUpdate != null)
                    {
                        var editedColumnName = dgvGiaoVien.Columns[e.ColumnIndex].Name;

                        switch (editedColumnName)
                        {
                            case "HoTen":
                                teacherToUpdate.HoTen = dgvGiaoVien.Rows[e.RowIndex].Cells["HoTen"].Value?.ToString().Trim();
                                break;
                            case "NgaySinh":
                                teacherToUpdate.NgaySinh = DateTime.Parse(dgvGiaoVien.Rows[e.RowIndex].Cells["NgaySinh"].Value?.ToString() ?? "01/01/2000");
                                break;
                            case "GioiTinh":
                                teacherToUpdate.GioiTinh = dgvGiaoVien.Rows[e.RowIndex].Cells["GioiTinh"].Value?.ToString().Trim();
                                break;
                            case "SoDienThoai":
                                teacherToUpdate.SoDienThoai = dgvGiaoVien.Rows[e.RowIndex].Cells["SoDienThoai"].Value?.ToString().Trim();
                                break;
                            case "Email":
                                teacherToUpdate.Email = dgvGiaoVien.Rows[e.RowIndex].Cells["Email"].Value?.ToString().Trim();
                                break;
                        }

                        db.SubmitChanges();
                        MessageBox.Show("Cập nhật thông tin giáo viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy giáo viên trong cơ sở dữ liệu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi khi cập nhật thông tin: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Sự kiện chọn ô để tự động chọn cả dòng
        private void dgvGiaoVien_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvGiaoVien.CurrentCell != null)
            {
                dgvGiaoVien.Rows[dgvGiaoVien.CurrentCell.RowIndex].Selected = true;
            }
        }

        private void frmQuanLyGiaoVien_Load(object sender, EventArgs e)
        {
            LoadTeacherData();
        }

        // Hàm tải dữ liệu giáo viên vào DataGridView
        private void LoadTeacherData()
        {
            try
            {
                using (var db = new DataClasses1DataContext())
                {
                    var teacherData = db.GIAOVIENs
                        .Select(gv => new
                        {
                            MaGV = gv.MaGV,
                            HoTen = gv.HoTen,
                            NgaySinh = gv.NgaySinh,
                            GioiTinh = gv.GioiTinh,
                            SoDienThoai = gv.SoDienThoai,
                            Email = gv.Email
                        })
                        .ToList();

                    dgvGiaoVien.DataSource = teacherData;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi khi tải dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Tìm kiếm giáo viên
        private void btnFind_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                using (var db = new DataClasses1DataContext())
                {
                    var query = db.GIAOVIENs.AsQueryable();

                    string maGV = txtMaGV.EditValue?.ToString().Trim();
                    string hoTen = txtHoTen.EditValue?.ToString().Trim();
                    string gioiTinh = txtGioiTinh.EditValue?.ToString().Trim();
                    string soDienThoai = txtSoDienThoai.EditValue?.ToString().Trim();
                    string email = txtEmail.EditValue?.ToString().Trim();

                    // Filter teachers based on account level
                    var teacherWithLevel2 = db.TAIKHOANs.Where(tk => tk.Level == 2)
                                                         .Select(tk => tk.MaGV)
                                                         .ToList();

                    query = query.Where(gv => teacherWithLevel2.Contains(gv.MaGV)); // Only show teachers with Level 2 accounts

                    if (!string.IsNullOrEmpty(maGV))
                        query = query.Where(gv => gv.MaGV.Contains(maGV));
                    if (!string.IsNullOrEmpty(hoTen))
                        query = query.Where(gv => gv.HoTen.Contains(hoTen));
                    if (!string.IsNullOrEmpty(gioiTinh))
                        query = query.Where(gv => gv.GioiTinh.Contains(gioiTinh));
                    if (!string.IsNullOrEmpty(soDienThoai))
                        query = query.Where(gv => gv.SoDienThoai.Contains(soDienThoai));
                    if (!string.IsNullOrEmpty(email))
                        query = query.Where(gv => gv.Email.Contains(email));

                    var teacherData = query
                        .Select(gv => new
                        {
                            MaGV = gv.MaGV,
                            HoTen = gv.HoTen,
                            NgaySinh = gv.NgaySinh,
                            GioiTinh = gv.GioiTinh,
                            SoDienThoai = gv.SoDienThoai,
                            Email = gv.Email
                        })
                        .ToList();

                    if (!teacherData.Any())
                    {
                        MessageBox.Show("Không tìm thấy giáo viên nào!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    dgvGiaoVien.DataSource = teacherData;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi khi tìm kiếm: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        // Thêm giáo viên mới
        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                frmThemTaiKhoan frm = new frmThemTaiKhoan();
                frm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi khi thêm giáo viên: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Cập nhật giáo viên
        private void btnEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                string maGV = txtMaGV.EditValue?.ToString().Trim();  // Changed variable name from MaHS to MaGV

                if (string.IsNullOrEmpty(maGV))
                {
                    MessageBox.Show("Mã giáo viên không được để trống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                using (var db = new DataClasses1DataContext())
                {
                    var teacherToUpdate = db.GIAOVIENs.SingleOrDefault(gv => gv.MaGV == maGV);  // Changed table from HOCSINH to GIAOVIEN

                    if (teacherToUpdate != null)
                    {
                        // Update other properties (keeping MaGV unchanged)
                        teacherToUpdate.HoTen = txtHoTen.EditValue?.ToString().Trim();
                        teacherToUpdate.NgaySinh = DateTime.Parse(txtNgaySinh.EditValue?.ToString() ?? "01/01/2000");
                        teacherToUpdate.GioiTinh = txtGioiTinh.EditValue?.ToString().Trim();
                        teacherToUpdate.SoDienThoai = txtSoDienThoai.EditValue?.ToString().Trim();  // Added new property for phone number
                        teacherToUpdate.Email = txtEmail.EditValue?.ToString().Trim();  // Added new property for email

                        db.SubmitChanges();

                        MessageBox.Show("Cập nhật thông tin giáo viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadTeacherData(); // Reload teacher data into DataGridView
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy giáo viên trong cơ sở dữ liệu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
