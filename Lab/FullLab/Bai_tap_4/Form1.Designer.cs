namespace TruyenDuLieu
{
    partial class FrmNhapLieu
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
            TxtSoDong = new TextBox();
            TxtSoCot = new TextBox();
            BtnKhoiTao = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 24);
            label1.Name = "label1";
            label1.Size = new Size(65, 20);
            label1.TabIndex = 0;
            label1.Text = "Số dòng";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 94);
            label2.Name = "label2";
            label2.Size = new Size(51, 20);
            label2.TabIndex = 1;
            label2.Text = "Số cột";
            // 
            // TxtSoDong
            // 
            TxtSoDong.Location = new Point(107, 21);
            TxtSoDong.Name = "TxtSoDong";
            TxtSoDong.Size = new Size(334, 27);
            TxtSoDong.TabIndex = 2;
            // 
            // TxtSoCot
            // 
            TxtSoCot.Location = new Point(107, 91);
            TxtSoCot.Name = "TxtSoCot";
            TxtSoCot.Size = new Size(334, 27);
            TxtSoCot.TabIndex = 3;
            // 
            // BtnKhoiTao
            // 
            BtnKhoiTao.Location = new Point(479, 36);
            BtnKhoiTao.Name = "BtnKhoiTao";
            BtnKhoiTao.Size = new Size(84, 64);
            BtnKhoiTao.TabIndex = 4;
            BtnKhoiTao.Text = "Khởi tạo";
            BtnKhoiTao.UseVisualStyleBackColor = true;
            BtnKhoiTao.Click += BtnKhoiTao_Click;
            // 
            // FrmNhapLieu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(597, 148);
            Controls.Add(BtnKhoiTao);
            Controls.Add(TxtSoCot);
            Controls.Add(TxtSoDong);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmNhapLieu";
            Text = "Nhap Lieu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox TxtSoDong;
        private TextBox TxtSoCot;
        private Button BtnKhoiTao;
    }
}
