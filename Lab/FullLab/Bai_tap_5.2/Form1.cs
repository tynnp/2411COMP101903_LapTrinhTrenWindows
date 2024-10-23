namespace ThucDon
{
    public partial class Form1 : Form
    {
        List<Object> itemChon = new List<object>();
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            if (TxtTenMon.Text.Length > 0)
            {
                LstThucDon.Items.Add(TxtTenMon.Text);
                TxtTenMon.Text = "";
            }
            else
            {
                MessageBox.Show("Chưa nhập tên món!");
            }
        }

        private void BtnThoat_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("Thoát chương trình", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void BtnLay_Click(object sender, EventArgs e)
        {
            if (LstThucDon.SelectedItem != null && !itemChon.Contains(LstThucDon.SelectedItem)) 
            {   
                itemChon.Add(LstThucDon.SelectedItem);
                LstChon.Items.Add(LstThucDon.SelectedItem);
            }
        }
        private void BtnChonHet_Click(object sender, EventArgs e)
        {
            List<Object> itemToMove = new List<Object>();

            foreach (var item in LstThucDon.Items)
            {
                itemToMove.Add(item);
            }

            foreach (var item in itemToMove)
            {
                if (!itemChon.Contains(item)) { 
                    LstChon.Items.Add(item);
                    itemChon.Add(item);
                }
            }
        }

        private void BtnTra_Click(object sender, EventArgs e)
        {
            if (LstChon.SelectedItem != null)
            {
                itemChon.Remove(LstChon.SelectedItem);
                LstChon.Items.Remove(LstChon.SelectedItem);
            }
        }

        private void BtnTraHet_Click(object sender, EventArgs e)
        {
            LstChon.Items.Clear();
            itemChon.Clear();
        }

        private void BtnXoaMon_Click(object sender, EventArgs e)
        {
            if (LstThucDon.SelectedItem != null)
            {
                LstThucDon.Items.Remove(LstThucDon.SelectedItem);
            }
        }
    }
}
