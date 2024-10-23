namespace NhaKhoa
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            TxtTenKhachHang = new TextBox();
            ChBoxCaoVoi = new CheckBox();
            ChBoxTayTrang = new CheckBox();
            label3 = new Label();
            label4 = new Label();
            NrNhoRang = new NumericUpDown();
            NrTramRang = new NumericUpDown();
            label5 = new Label();
            label8 = new Label();
            TxtTongTien = new TextBox();
            label9 = new Label();
            BtnTinhTien = new Button();
            BtnXoa = new Button();
            BtnThoat = new Button();
            label10 = new Label();
            label11 = new Label();
            ((System.ComponentModel.ISupportInitialize)NrNhoRang).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NrTramRang).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(90, 9);
            label1.Name = "label1";
            label1.Size = new Size(312, 41);
            label1.TabIndex = 0;
            label1.Text = "DỊCH VỤ NHA KHOA";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(12, 77);
            label2.Name = "label2";
            label2.Size = new Size(160, 28);
            label2.TabIndex = 1;
            label2.Text = "Tên khách hàng";
            // 
            // TxtTenKhachHang
            // 
            TxtTenKhachHang.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            TxtTenKhachHang.Location = new Point(181, 74);
            TxtTenKhachHang.Name = "TxtTenKhachHang";
            TxtTenKhachHang.Size = new Size(313, 34);
            TxtTenKhachHang.TabIndex = 2;
            // 
            // ChBoxCaoVoi
            // 
            ChBoxCaoVoi.AutoSize = true;
            ChBoxCaoVoi.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            ChBoxCaoVoi.Location = new Point(12, 133);
            ChBoxCaoVoi.Name = "ChBoxCaoVoi";
            ChBoxCaoVoi.Size = new Size(104, 32);
            ChBoxCaoVoi.TabIndex = 3;
            ChBoxCaoVoi.Text = "Cạo vôi";
            ChBoxCaoVoi.UseVisualStyleBackColor = true;
            // 
            // ChBoxTayTrang
            // 
            ChBoxTayTrang.AutoSize = true;
            ChBoxTayTrang.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            ChBoxTayTrang.Location = new Point(12, 187);
            ChBoxTayTrang.Name = "ChBoxTayTrang";
            ChBoxTayTrang.Size = new Size(125, 32);
            ChBoxTayTrang.TabIndex = 4;
            ChBoxTayTrang.Text = "Tẩy trắng";
            ChBoxTayTrang.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.Location = new Point(12, 246);
            label3.Name = "label3";
            label3.Size = new Size(101, 28);
            label3.TabIndex = 5;
            label3.Text = "Nhổ răng";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.Location = new Point(12, 304);
            label4.Name = "label4";
            label4.Size = new Size(108, 28);
            label4.TabIndex = 6;
            label4.Text = "Trám răng";
            // 
            // NrNhoRang
            // 
            NrNhoRang.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            NrNhoRang.Location = new Point(126, 244);
            NrNhoRang.Name = "NrNhoRang";
            NrNhoRang.Size = new Size(82, 34);
            NrNhoRang.TabIndex = 7;
            NrNhoRang.ValueChanged += NrNhoRang_ValueChanged;
            // 
            // NrTramRang
            // 
            NrTramRang.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            NrTramRang.Location = new Point(126, 302);
            NrTramRang.Name = "NrTramRang";
            NrTramRang.Size = new Size(82, 34);
            NrTramRang.TabIndex = 8;
            NrTramRang.ValueChanged += NrTramRang_ValueChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label5.ForeColor = Color.Blue;
            label5.Location = new Point(360, 134);
            label5.Name = "label5";
            label5.Size = new Size(134, 28);
            label5.TabIndex = 9;
            label5.Text = "100000 VNĐ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label8.ForeColor = Color.Blue;
            label8.Location = new Point(348, 188);
            label8.Name = "label8";
            label8.Size = new Size(146, 28);
            label8.TabIndex = 12;
            label8.Text = "1500000 VNĐ";
            // 
            // TxtTongTien
            // 
            TxtTongTien.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            TxtTongTien.ForeColor = Color.Red;
            TxtTongTien.Location = new Point(126, 377);
            TxtTongTien.Name = "TxtTongTien";
            TxtTongTien.ReadOnly = true;
            TxtTongTien.Size = new Size(368, 34);
            TxtTongTien.TabIndex = 14;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label9.Location = new Point(12, 380);
            label9.Name = "label9";
            label9.Size = new Size(103, 28);
            label9.TabIndex = 13;
            label9.Text = "Tổng tiền";
            // 
            // BtnTinhTien
            // 
            BtnTinhTien.Cursor = Cursors.Hand;
            BtnTinhTien.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            BtnTinhTien.ForeColor = Color.Red;
            BtnTinhTien.Location = new Point(12, 450);
            BtnTinhTien.Name = "BtnTinhTien";
            BtnTinhTien.Size = new Size(146, 56);
            BtnTinhTien.TabIndex = 15;
            BtnTinhTien.Text = "Tính tiền";
            BtnTinhTien.UseVisualStyleBackColor = true;
            BtnTinhTien.Click += BtnTinhTien_Click;
            // 
            // BtnXoa
            // 
            BtnXoa.Cursor = Cursors.Hand;
            BtnXoa.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            BtnXoa.ForeColor = Color.Red;
            BtnXoa.Location = new Point(181, 450);
            BtnXoa.Name = "BtnXoa";
            BtnXoa.Size = new Size(146, 56);
            BtnXoa.TabIndex = 16;
            BtnXoa.Text = "Xóa";
            BtnXoa.UseVisualStyleBackColor = true;
            BtnXoa.Click += BtnXoa_Click;
            // 
            // BtnThoat
            // 
            BtnThoat.Cursor = Cursors.Hand;
            BtnThoat.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            BtnThoat.ForeColor = Color.Red;
            BtnThoat.Location = new Point(348, 450);
            BtnThoat.Name = "BtnThoat";
            BtnThoat.Size = new Size(146, 56);
            BtnThoat.TabIndex = 17;
            BtnThoat.Text = "Thoát";
            BtnThoat.UseVisualStyleBackColor = true;
            BtnThoat.Click += BtnThoat_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label10.ForeColor = Color.Blue;
            label10.Location = new Point(360, 304);
            label10.Name = "label10";
            label10.Size = new Size(134, 28);
            label10.TabIndex = 18;
            label10.Text = "200000 VNĐ";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label11.ForeColor = Color.Blue;
            label11.Location = new Point(360, 246);
            label11.Name = "label11";
            label11.Size = new Size(134, 28);
            label11.TabIndex = 19;
            label11.Text = "150000 VNĐ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(503, 518);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(BtnThoat);
            Controls.Add(BtnXoa);
            Controls.Add(BtnTinhTien);
            Controls.Add(TxtTongTien);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label5);
            Controls.Add(NrTramRang);
            Controls.Add(NrNhoRang);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(ChBoxTayTrang);
            Controls.Add(ChBoxCaoVoi);
            Controls.Add(TxtTenKhachHang);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)NrNhoRang).EndInit();
            ((System.ComponentModel.ISupportInitialize)NrTramRang).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox TxtTenKhachHang;
        private CheckBox ChBoxCaoVoi;
        private CheckBox ChBoxTayTrang;
        private Label label3;
        private Label label4;
        private NumericUpDown NrNhoRang;
        private NumericUpDown NrTramRang;
        private Label label5;
        private Label label8;
        private TextBox TxtTongTien;
        private Label label9;
        private Button BtnTinhTien;
        private Button BtnXoa;
        private Button BtnThoat;
        private Label label10;
        private Label label11;
    }
}
