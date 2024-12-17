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
    public partial class frmQuanLyLichDay : Form
    {
        public frmQuanLyLichDay()
        {
            InitializeComponent();
            loadcbbPC();
        }

        private void loadcbbPC()
        {
            DataClasses1DataContext db = new DataClasses1DataContext();

            // Lớp
            comboBoxLopPC.DataSource = db.LOPs
                                         .Select(lop => new { lop.MaLop, lop.TenLop })
                                         .ToList();
            comboBoxLopPC.DisplayMember = "TenLop"; // Hiển thị tên lớp
            comboBoxLopPC.ValueMember = "MaLop";   // Gán mã lớp làm giá trị

            // Giáo viên
            comboBoxGiaoVien.DataSource = db.TAIKHOANs
                                   .Where(tk => tk.Level == 2) // Thêm điều kiện lọc
                                   .Join(db.GIAOVIENs,
                                         tk => tk.MaGV,
                                         gv => gv.MaGV,
                                         (tk, gv) => new { gv.MaGV, gv.HoTen })
                                   .ToList();

           
            comboBoxGiaoVien.DisplayMember = "HoTen"; // Hiển thị họ tên
            comboBoxGiaoVien.ValueMember = "MaGV";   // Gán mã giáo viên làm giá trị

            // Môn học
            comboBoxMonHocPC.DataSource = db.MONHOCs
                                            .Select(mon => new { mon.MaMon, mon.TenMon })
                                            .ToList();
            comboBoxMonHocPC.DisplayMember = "TenMon"; // Hiển thị tên môn học
            comboBoxMonHocPC.ValueMember = "MaMon";   // Gán mã môn học làm giá trị
        }


        private void ThemPhanCong()
        {
            DataClasses1DataContext db = new DataClasses1DataContext();

            // Tạo mới bản ghi phân công
            var phanCong = new PHANCONG
            {
                MaGV = comboBoxGiaoVien.SelectedValue.ToString(),
                MaMon = comboBoxMonHocPC.SelectedValue.ToString(),
                MaLop = comboBoxLopPC.SelectedValue.ToString(),
                NamHoc = int.Parse(comboBoxNamPC.SelectedItem.ToString())
            };

            // Thêm vào cơ sở dữ liệu
            db.PHANCONGs.InsertOnSubmit(phanCong);
            db.SubmitChanges();

            // Lấy tên giáo viên và tên môn học
            string tenGiaoVien = comboBoxGiaoVien.Text;
            string tenMon = comboBoxMonHocPC.Text;

            // Tạo chuỗi phân công chỉ chứa tên giáo viên và tên môn
            string phanCongString = $"{tenGiaoVien}, {tenMon}";

            // Cập nhật vào DataGridView
            // Giả sử bạn đã có một DataGridView tên là drvPC
            drvPC.Rows.Add(phanCongString); // Thêm vào dòng mới

            MessageBox.Show("Phân công được thêm thành công!", "Thông báo");
        }


        /*private void loadLichDay()
        {
            DataClasses1DataContext db = new DataClasses1DataContext();

            var lichDay = db.LICHDAYs
                            .Join(db.GIAOVIENs, ld => ld.MaGV, gv => gv.MaGV, (ld, gv) => new { ld, gv })
                            .Join(db.LOPs, temp => temp.ld.MaLop, lop => lop.MaLop, (temp, lop) => new { temp.ld, temp.gv, lop })
                            .Join(db.MONHOCs, temp => temp.ld.MaMon, mon => mon.MaMon, (temp, mon) => new
                            {
                                temp.ld.NgayTrongTuan,
                                temp.ld.TietBatDau,
                                temp.ld.SoTiet,
                                temp.ld.NamHoc,
                                temp.ld.HocKy,
                                temp.gv.HoTen,
                                temp.lop.TenLop,
                                mon.TenMon
                            })
                            .ToList();

            dvgLichDay.DataSource = lichDay;
        }
        */


        private void btnXoa_Click(object sender, EventArgs e)
        {

        }

        

        private void xtraTabXepTKB_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gridControlPhanCong_Click(object sender, EventArgs e)
        {

        }

        private void xtraTabPCD_Paint(object sender, PaintEventArgs e)
        {

        }

        private void xtraTabPPCT_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelControl5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dropDownBtnPhanMon_Click(object sender, EventArgs e)
        {

        }

        private void xtraTabQLLD_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxLopPC_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnThemPC_Click(object sender, EventArgs e)
        {
            // Lấy dữ liệu từ ComboBox
            string tenGiaoVien = comboBoxGiaoVien.Text; // Lấy tên giáo viên
            string tenMon = comboBoxMonHocPC.Text; // Lấy tên môn học

            // Gộp thông tin
            string phanCong = $"{tenGiaoVien}, {tenMon}";

            // Kiểm tra xem vị trí cell đã được chọn hay chưa
            if (selectedRowIndex >= 0 && selectedColumnIndex >= 0)
            {
                // Cập nhật dữ liệu vào cell đã chọn
                drvPC.Rows[selectedRowIndex].Cells[selectedColumnIndex].Value = phanCong;
                MessageBox.Show("Thêm thông tin phân công thành công!", "Thông báo");
            }
            else
            {
                MessageBox.Show("Vui lòng chọn cell trong bảng trước khi thêm dữ liệu!", "Lỗi");
            }
        }


        private int selectedRowIndex = -1;
        private int selectedColumnIndex = -1;

        private void drvPC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Lưu vị trí cell được click
                selectedRowIndex = e.RowIndex;
                selectedColumnIndex = e.ColumnIndex;

                // Lấy dữ liệu từ cell
                string thongTin = drvPC.Rows[e.RowIndex].Cells[e.ColumnIndex].Value?.ToString();

                if (!string.IsNullOrEmpty(thongTin))
                {
                    // Phân tích chuỗi để lấy giá trị từng phần
                    string[] parts = thongTin.Split(',');
                    foreach (var part in parts)
                    {
                        if (part.Contains("Lớp:"))
                        {
                            comboBoxLopPC.SelectedItem = part.Replace("Lớp:", "").Trim();
                        }
                        else if (part.Contains("Giáo viên:"))
                        {
                            comboBoxGiaoVien.SelectedItem = part.Replace("Giáo viên:", "").Trim();
                        }
                        else if (part.Contains("Môn học:"))
                        {
                            comboBoxMonHocPC.SelectedItem = part.Replace("Môn học:", "").Trim();
                        }
                        else if (part.Contains("Năm học:"))
                        {
                            comboBoxNamPC.SelectedItem = part.Replace("Năm học:", "").Trim();
                        }
                        else if (part.Contains("Học kỳ:"))
                        {
                            comboBoxHKPC.SelectedItem = part.Replace("Học kỳ:", "").Trim();
                        }
                    }

                    MessageBox.Show("Dữ liệu đã được tải lại vào các ComboBox.", "Thông báo");
                }
            }
        }


        private void btnXoaPC_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có cell nào được chọn hay chưa
            if (selectedRowIndex >= 0 && selectedColumnIndex >= 0)
            {
                // Xóa dữ liệu trong cell đã chọn
                drvPC.Rows[selectedRowIndex].Cells[selectedColumnIndex].Value = null;
                MessageBox.Show("Đã xóa thông tin trong cell được chọn.", "Thông báo");
            }
            else
            {
                MessageBox.Show("Vui lòng chọn cell trong bảng trước khi xóa!", "Lỗi");
            }
        }
        private void btnSuaPC_Click(object sender, EventArgs e)
        {
            string tenGiaoVien = comboBoxGiaoVien.Text; // Lấy tên giáo viên
            string tenMon = comboBoxMonHocPC.Text; // Lấy tên môn học

            // Gộp thông tin
            string phanCong = $"{tenGiaoVien}, {tenMon}";

            // Kiểm tra xem vị trí cell đã được chọn hay chưa
            if (selectedRowIndex >= 0 && selectedColumnIndex >= 0)
            {
                // Cập nhật dữ liệu vào cell đã chọn
                drvPC.Rows[selectedRowIndex].Cells[selectedColumnIndex].Value = phanCong;
                MessageBox.Show("Sửa thông tin phân công thành công!", "Thông báo");
            }
            else
            {
                MessageBox.Show("Vui lòng chọn cell trong bảng trước khi thêm dữ liệu!", "Lỗi");
            }
        }
    }
}
