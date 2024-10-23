namespace HienThiTen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (CboTitle.Text.Length > 0 && TxtFirstName.Text.Length > 0 && TxtLastName.Text.Length > 0)
            {
                var chuoi = $"{CboTitle.Text} {TxtFirstName.Text} {TxtLastName.Text}";
                LstDanhSach.Items.Add(chuoi);
                TxtFirstName.Text = TxtLastName.Text = "";
                CboTitle.Text = "";
            }
            else
            {
                MessageBox.Show("Chương nhập đủ dữ liệu!");
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            CboTitle.Text = "";
            TxtFirstName.Text = TxtLastName.Text = "";
            LstDanhSach.Items.Clear();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("Đóng chương trình", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                Application.Exit();
            } 
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
