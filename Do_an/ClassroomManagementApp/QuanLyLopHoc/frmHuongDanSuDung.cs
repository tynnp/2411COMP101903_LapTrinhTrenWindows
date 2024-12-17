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
    public partial class frmHuongDanSuDung : Form
    {
        public frmHuongDanSuDung()
        {
            InitializeComponent();
        }

        private void accQLTKthem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thực hiện chức năng thêm tài khoản người dùng.\n " +
                "Người dùng tiến hành nhập các thông tin được yêu cầu để tạo tài khoản: \n" +
                "Tên tài khoản, mật khẩu, Email liên hệ, Họ tên, ngày sinh và giới tinh. Sau đó tiến hành lựa chọn quyền hạn của tài khoản. \n" +
                "nhấn [thêm tài khoản] để tiến hành thêm, nhấn [Thoát] để kết thúc", "Thêm tài khoản", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void accQLTKxoa_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thực hiện chức năng xóa tài khoản người dùng.\n " , "Xóa tài khoản", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void accQLTKsua_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thực hiện chức năng sửa thông tin tài khoản người dùng.\n " +
               " \n", "Sửa tài khoản", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void accQLHSthem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thực hiện chức năng thêm thông tin của một học sinh.\n " +
                "Người dùng tiến hành nhập các thông tin được yêu cầu để tạo mới một học sinh: \n" +
                "Mã học sinh, họ tên học sinh, ngày sinh, giới tính, địa chỉ, mã lớp học \n" +
                "Nếu thành công thông tin học sinh sẽ được lưu trữ vào cơ sở dữ liệu, ngược lại hiển thị thông báo lỗi", "Thêm học sinh", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void accQLHStimkiem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thực hiện chức năng tìm kiếm thông tin của một học sinh.\n ", "Tìm kiếm học sinh", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void accQLHSxoa_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thực hiện chức năng xóa thông tin của một học sinh.\n ", "Xóa học sinh", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void accQLHSsua_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thực hiện chức năng sửa thông tin của một học sinh.\n ", "Sửa thông tin học sinh", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void accQLHSchuyenlop_Click(object sender, EventArgs e)
        {

        }

        private void accQLLDphanphoi_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Phân phối chương trình\r\n-Chọn khối học, lớp học, phần môn\r\n-Bảng hiện phân phối chương trình gồm số thứ tự, tiết, tên bài, ghi chú và phần môn", "Phân phối chương trình", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void accQLLDphancong_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Phân công dạy\r\n-Chọn lớp, giáo viên, môn, năm, học kỳ\r\n-Bảng hiện lịch dạy gồm buổi và các ngày trong tuần\r\n-Chọn nút thêm/xóa/sửa để thực hiện thao tác tương ứng", "Phân công dạy", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void accNDHStimkiem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thực hiện việc tìm kiếm và hiển thị danh sách điểm của học sinh theo những tiêu chí sau\n" +
                "Lớp \n" +
                "Phân môn \n" +
               "Học kì \n" +
               "Năm học" , "Tìm kiếm danh sách điểm", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void accQLGVthem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thực hiện chức năng thêm thông tin của một giáo viên theo form yêu cầu.\n ", "Thêm giáo viên", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void accQLGVsua_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thực hiện chức năng sửa thông tin của một giáo viên.\n ", "Sửa thông tin giáo viên", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void accQLGVtimkiem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thực hiện chức năng tìm kiếm thông tin của một giáo viên theo thông tin nhập vào.\n ", "Tìm giáo viên", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void accQLLDxeptkb_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thực hiện chức năng xếp thời khóa biểu giảng dạy và học tập cho học sinh và giáo viên.\n ", "Xếp thời khóa biểu", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void accNDHSthem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tiến hành nhập điểm học sinh theo những thông tin đã nhập vào.\n ", "Nhập điểm học sinh", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void accNDHSsua_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tiến hành sửa điểm học sinh theo những thông tin đã nhập vào (không cho phép sửa đổi thông tin học sinh).\n ", "Sửa điểm học sinh", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
