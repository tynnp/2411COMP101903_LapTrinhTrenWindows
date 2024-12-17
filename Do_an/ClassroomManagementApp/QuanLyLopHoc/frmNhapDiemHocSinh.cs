using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using System;
using System.Linq;
using System.Windows.Forms;

namespace QuanLyLopHoc
{
    public partial class frmNhapDiemHocSinh : Form
    {
        public frmNhapDiemHocSinh()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            using (var db = new DataClasses1DataContext())
            {
                var query = db.DIEMs
                    .Join(db.HOCSINHs,
                          diem => diem.MaHS,
                           hs => hs.MaHS,
                            (diem, hs) => new { diem, hs })
                            .Join(db.MONHOCs,
                            temp => temp.diem.MaMon,
                            mon => mon.MaMon,
                            (temp, mon) => new
          {
              MaHS = temp.hs.MaHS,
              HoTenHS = temp.hs.HoTen,
              HKi = temp.diem.HocKy,
              tenmon = mon.TenMon,
              mamon = mon.MaMon,
              diemso = temp.diem.DiemSo,
              namhoc = temp.diem.NamHoc
          });

                // Xóa tất cả các dòng hiện có trong dataTable trước khi thêm mới
                dataTable.Rows.Clear();

                // Thêm dữ liệu vào các cột đã thiết kế sẵn
                foreach (var hs in query.ToList())
                {
                    dataTable.Rows.Add(hs.MaHS, hs.HoTenHS, hs.HKi, hs.tenmon,hs.mamon, hs.diemso, hs.namhoc);
                }
            }
        }

        private void frmNhapDiemHocSinh_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnFind_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string subjectName = inputSubject.EditValue?.ToString().Trim();
            int schoolTerm = int.TryParse(inputSchoolTerm.EditValue?.ToString(), out int term) ? term : 0;
            int schoolYear = int.TryParse(inputSchoolYear.EditValue?.ToString(), out int year) ? year : 0;

            using (var db = new DataClasses1DataContext())
            {
                var query = db.DIEMs
                            .Join(db.HOCSINHs,
           diem => diem.MaHS,
           hs => hs.MaHS,
           (diem, hs) => new { diem, hs })
     .Join(db.MONHOCs,
           temp => temp.diem.MaMon,
           mon => mon.MaMon,
           (temp, mon) => new { temp.diem, temp.hs, mon })
     .Where(temp => (string.IsNullOrEmpty(subjectName) || temp.mon.TenMon.Contains(subjectName)) &&
                    (schoolTerm == 0 || temp.diem.HocKy == schoolTerm) &&
                    (schoolYear == 0 || temp.diem.NamHoc == schoolYear))
     .Select(temp => new
     {
         MaHS = temp.hs.MaHS,
         HoTenHS = temp.hs.HoTen,
         HKi = temp.diem.HocKy,
         tenmon = temp.mon.TenMon,
         mamon = temp.mon.MaMon,
         diemso = temp.diem.DiemSo,
         namhoc = temp.diem.NamHoc
     });


                dataTable.Rows.Clear();

                foreach (var hs in query.ToList())
                {
                    dataTable.Rows.Add(hs.MaHS, hs.HoTenHS, hs.HKi, hs.tenmon,hs.mamon, hs.diemso, hs.namhoc);
                }

                if (!query.Any())
                {
                    MessageBox.Show("Không tìm thấy dữ liệu phù hợp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnModifyingStd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (var db = new DataClasses1DataContext())
            {
                string studentCode = studentCodeEdit.EditValue?.ToString().Trim();
                string subjectName = subjectCodeEdit.EditValue?.ToString().Trim();
                int schoolTerm = int.TryParse(schoolTermEdit.EditValue?.ToString(), out int term) ? term : 0;
                int schoolYear = int.TryParse(schoolYearEdit.EditValue?.ToString(), out int year) ? year : 0;
                double score = double.TryParse(scoreEdit.EditValue?.ToString(), out double s) ? s : 0.0;

                var diemToUpdate = db.DIEMs.FirstOrDefault(d => d.MaHS == studentCode &&
                                                                d.MaMon == subjectName &&
                                                                d.HocKy == schoolTerm &&
                                                                d.NamHoc == schoolYear);

                if (diemToUpdate != null)
                {
                    diemToUpdate.DiemSo = score;
                    db.SubmitChanges();
                    MessageBox.Show("Cập nhật điểm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy dữ liệu để cập nhật!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnAddingStd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (var db = new DataClasses1DataContext())
            {
                string studentCode = studentCodeEdit.EditValue?.ToString().Trim();
                string subjectName = subjectCodeEdit.EditValue?.ToString().Trim();
                int schoolTerm = int.TryParse(schoolTermEdit.EditValue?.ToString(), out int term) ? term : 0;
                int schoolYear = int.TryParse(schoolYearEdit.EditValue?.ToString(), out int year) ? year : 0;
                double score = double.TryParse(scoreEdit.EditValue?.ToString(), out double s) ? s : 0.0;

                var diemExist = db.DIEMs.FirstOrDefault(d => d.MaHS == studentCode &&
                                                            d.MaMon == subjectName &&
                                                            d.HocKy == schoolTerm &&
                                                            d.NamHoc == schoolYear);

                if (diemExist != null)
                {
                    MessageBox.Show("Điểm đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                DIEM newDiem = new DIEM
                {
                    MaHS = studentCode,
                    MaMon = subjectName,
                    HocKy = schoolTerm,
                    NamHoc = schoolYear,
                    DiemSo = score
                };

                db.DIEMs.InsertOnSubmit(newDiem);
                db.SubmitChanges();
                MessageBox.Show("Thêm điểm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
            }
        }

        private void btnDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (var db = new DataClasses1DataContext())
            {
                string studentCode = studentCodeEdit.EditValue?.ToString().Trim();
                string subjectName = subjectCodeEdit.EditValue?.ToString().Trim();
                int schoolTerm = int.TryParse(schoolTermEdit.EditValue?.ToString(), out int term) ? term : 0;
                int schoolYear = int.TryParse(schoolYearEdit.EditValue?.ToString(), out int year) ? year : 0;

                var diemToDelete = db.DIEMs.FirstOrDefault(d => d.MaHS == studentCode &&
                                                                d.MaMon == subjectName &&
                                                                d.HocKy == schoolTerm &&
                                                                d.NamHoc == schoolYear);

                if (diemToDelete != null)
                {
                    db.DIEMs.DeleteOnSubmit(diemToDelete);
                    db.SubmitChanges();
                    MessageBox.Show("Xóa điểm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy dữ liệu để xóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}