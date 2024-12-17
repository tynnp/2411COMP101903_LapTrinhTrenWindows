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
    public partial class frmThaoTacTaiKhoan : DevExpress.XtraEditors.XtraForm
    {
        public frmThaoTacTaiKhoan()
        {
            InitializeComponent();
        }

        private void btnThaoTac_Click(object sender, EventArgs e)
        {
            string hoten = txtTenGiaoVien.Text;
            using (DataClasses1DataContext db = new DataClasses1DataContext())
            {
                var teacher = db.GIAOVIENs.SingleOrDefault(gv => gv.HoTen == hoten);
                if (teacher != null)
                {
                    frmEditTaiKhoan frm = new frmEditTaiKhoan(teacher);
                    frm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Giáo viên không tồn tại, vui lòng nhập lại!", "Thông báo");
                }
            }
        }
    }
}