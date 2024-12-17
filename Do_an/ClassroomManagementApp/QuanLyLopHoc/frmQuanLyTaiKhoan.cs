using DevExpress.XtraGrid.Views.Grid;
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
    public partial class frmQuanLyTaiKhoan : Form
    {
        public frmQuanLyTaiKhoan()
        {
            InitializeComponent();
        }
        private void frmQuanLyTaiKhoan_Load(object sender, EventArgs e)
        {

            loadDuLieu();
            

        }
        private void loadDuLieu()
        {
            
            DataClasses1DataContext db = new DataClasses1DataContext();

            
            var danhSachTaiKhoan = db.TAIKHOANs.Select(tk => new
            {
                IDUser = tk.IDUser,
                Username = tk.Username,
                Password = new string('*', 8), 
                Level = tk.Level,
                MaGV = tk.MaGV
            });

            // Thêm dữ liệu vào các cột đã thiết kế sẵn
            foreach (var tk in danhSachTaiKhoan)
            {
                dvgTK.Rows.Add(tk.IDUser, tk.Username, tk.Password, tk.Level, tk.MaGV);
            }
        }



        private void panelControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnThaoTacTaiKhoan_Click(object sender, EventArgs e)
        {
            frmThaoTacTaiKhoan frm = new frmThaoTacTaiKhoan();
            frm.Show();
        }

        private void btnThemTaiKhoan_Click(object sender, EventArgs e)
        {
            frmThemTaiKhoan frm=new frmThemTaiKhoan();
            frm.Show();
        }

        
    }
}
