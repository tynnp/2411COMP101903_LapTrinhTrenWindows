namespace ThucDon
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
            TxtTenMon = new TextBox();
            BtnThem = new Button();
            LstThucDon = new ListBox();
            BtnLay = new Button();
            BtnThoat = new Button();
            LstChon = new ListBox();
            BtnChonHet = new Button();
            BtnTra = new Button();
            BtnTraHet = new Button();
            BtnXoaMon = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(23, 23);
            label1.Name = "label1";
            label1.Size = new Size(93, 28);
            label1.TabIndex = 0;
            label1.Text = "Tên món";
            // 
            // TxtTenMon
            // 
            TxtTenMon.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtTenMon.Location = new Point(145, 20);
            TxtTenMon.Name = "TxtTenMon";
            TxtTenMon.Size = new Size(473, 34);
            TxtTenMon.TabIndex = 1;
            // 
            // BtnThem
            // 
            BtnThem.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnThem.Location = new Point(657, 16);
            BtnThem.Name = "BtnThem";
            BtnThem.Size = new Size(110, 42);
            BtnThem.TabIndex = 2;
            BtnThem.Text = "Thêm";
            BtnThem.UseVisualStyleBackColor = true;
            BtnThem.Click += BtnThem_Click;
            // 
            // LstThucDon
            // 
            LstThucDon.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LstThucDon.FormattingEnabled = true;
            LstThucDon.ItemHeight = 28;
            LstThucDon.Location = new Point(12, 85);
            LstThucDon.Name = "LstThucDon";
            LstThucDon.Size = new Size(341, 564);
            LstThucDon.TabIndex = 3;
            // 
            // BtnLay
            // 
            BtnLay.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnLay.Location = new Point(359, 263);
            BtnLay.Name = "BtnLay";
            BtnLay.Size = new Size(70, 47);
            BtnLay.TabIndex = 4;
            BtnLay.Text = ">";
            BtnLay.UseVisualStyleBackColor = true;
            BtnLay.Click += BtnLay_Click;
            // 
            // BtnThoat
            // 
            BtnThoat.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnThoat.Location = new Point(657, 666);
            BtnThoat.Name = "BtnThoat";
            BtnThoat.Size = new Size(131, 42);
            BtnThoat.TabIndex = 8;
            BtnThoat.Text = "Thoát";
            BtnThoat.UseVisualStyleBackColor = true;
            BtnThoat.Click += BtnThoat_Click;
            // 
            // LstChon
            // 
            LstChon.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LstChon.FormattingEnabled = true;
            LstChon.ItemHeight = 28;
            LstChon.Location = new Point(435, 85);
            LstChon.Name = "LstChon";
            LstChon.Size = new Size(353, 564);
            LstChon.TabIndex = 9;
            // 
            // BtnChonHet
            // 
            BtnChonHet.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnChonHet.Location = new Point(359, 316);
            BtnChonHet.Name = "BtnChonHet";
            BtnChonHet.Size = new Size(70, 47);
            BtnChonHet.TabIndex = 10;
            BtnChonHet.Text = ">>";
            BtnChonHet.UseVisualStyleBackColor = true;
            BtnChonHet.Click += BtnChonHet_Click;
            // 
            // BtnTra
            // 
            BtnTra.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnTra.Location = new Point(359, 369);
            BtnTra.Name = "BtnTra";
            BtnTra.Size = new Size(70, 47);
            BtnTra.TabIndex = 11;
            BtnTra.Text = "<";
            BtnTra.UseVisualStyleBackColor = true;
            BtnTra.Click += BtnTra_Click;
            // 
            // BtnTraHet
            // 
            BtnTraHet.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnTraHet.Location = new Point(359, 422);
            BtnTraHet.Name = "BtnTraHet";
            BtnTraHet.Size = new Size(70, 47);
            BtnTraHet.TabIndex = 12;
            BtnTraHet.Text = "<<";
            BtnTraHet.UseVisualStyleBackColor = true;
            BtnTraHet.Click += BtnTraHet_Click;
            // 
            // BtnXoaMon
            // 
            BtnXoaMon.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnXoaMon.Location = new Point(12, 666);
            BtnXoaMon.Name = "BtnXoaMon";
            BtnXoaMon.Size = new Size(131, 42);
            BtnXoaMon.TabIndex = 13;
            BtnXoaMon.Text = "Xóa món";
            BtnXoaMon.UseVisualStyleBackColor = true;
            BtnXoaMon.Click += BtnXoaMon_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 719);
            Controls.Add(BtnXoaMon);
            Controls.Add(BtnTraHet);
            Controls.Add(BtnTra);
            Controls.Add(BtnChonHet);
            Controls.Add(LstChon);
            Controls.Add(BtnThoat);
            Controls.Add(BtnLay);
            Controls.Add(LstThucDon);
            Controls.Add(BtnThem);
            Controls.Add(TxtTenMon);
            Controls.Add(label1);
            MaximizeBox = false;
            Name = "Form1";
            Text = "Thuc don";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox TxtTenMon;
        private Button BtnThem;
        private ListBox LstThucDon;
        private Button BtnLay;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button BtnThoat;
        private ListBox LstChon;
        private Button BtnChonHet;
        private Button BtnTra;
        private Button BtnTraHet;
        private Button BtnXoaMon;
    }
}
