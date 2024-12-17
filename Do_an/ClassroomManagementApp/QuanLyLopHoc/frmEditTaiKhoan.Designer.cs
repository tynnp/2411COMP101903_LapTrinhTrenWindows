namespace QuanLyLopHoc
{
    partial class frmEditTaiKhoan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtSoDienThoai = new System.Windows.Forms.TextBox();
            this.lblSDT = new System.Windows.Forms.Label();
            this.lblThemTaiKhoan = new System.Windows.Forms.Label();
            this.dateSinhNhat = new DevExpress.XtraEditors.DateEdit();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.lblGioiTinh = new System.Windows.Forms.Label();
            this.txtGioiTinh = new System.Windows.Forms.TextBox();
            this.btnXacNhan = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.dateSinhNhat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateSinhNhat.Properties.CalendarTimeProperties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSoDienThoai
            // 
            this.txtSoDienThoai.Location = new System.Drawing.Point(589, 244);
            this.txtSoDienThoai.Name = "txtSoDienThoai";
            this.txtSoDienThoai.Size = new System.Drawing.Size(404, 23);
            this.txtSoDienThoai.TabIndex = 31;
            // 
            // lblSDT
            // 
            this.lblSDT.AutoSize = true;
            this.lblSDT.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblSDT.Location = new System.Drawing.Point(589, 191);
            this.lblSDT.Name = "lblSDT";
            this.lblSDT.Size = new System.Drawing.Size(208, 27);
            this.lblSDT.TabIndex = 30;
            this.lblSDT.Text = "Số điện thoại:";
            // 
            // lblThemTaiKhoan
            // 
            this.lblThemTaiKhoan.AutoSize = true;
            this.lblThemTaiKhoan.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblThemTaiKhoan.ForeColor = System.Drawing.Color.Red;
            this.lblThemTaiKhoan.Location = new System.Drawing.Point(362, 30);
            this.lblThemTaiKhoan.Name = "lblThemTaiKhoan";
            this.lblThemTaiKhoan.Size = new System.Drawing.Size(339, 34);
            this.lblThemTaiKhoan.TabIndex = 29;
            this.lblThemTaiKhoan.Text = "Thao tác tài khoản";
            // 
            // dateSinhNhat
            // 
            this.dateSinhNhat.EditValue = null;
            this.dateSinhNhat.Location = new System.Drawing.Point(84, 244);
            this.dateSinhNhat.Name = "dateSinhNhat";
            this.dateSinhNhat.Properties.BeepOnError = true;
            this.dateSinhNhat.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateSinhNhat.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateSinhNhat.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.Fluent;
            this.dateSinhNhat.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.DateOnlyMaskManager));
            this.dateSinhNhat.Properties.MaskSettings.Set("MaskManagerSignature", "allowNull=False");
            this.dateSinhNhat.Properties.MaskSettings.Set("mask", "d");
            this.dateSinhNhat.Properties.MaskSettings.Set("culture", "vi-VN");
            this.dateSinhNhat.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.False;
            this.dateSinhNhat.Size = new System.Drawing.Size(405, 22);
            this.dateSinhNhat.TabIndex = 28;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(84, 346);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(405, 23);
            this.txtEmail.TabIndex = 27;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblEmail.Location = new System.Drawing.Point(84, 293);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(208, 27);
            this.lblEmail.TabIndex = 26;
            this.lblEmail.Text = "Email liên hệ:";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(84, 142);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(405, 23);
            this.txtHoTen.TabIndex = 25;
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblHoTen.Location = new System.Drawing.Point(84, 89);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(152, 27);
            this.lblHoTen.TabIndex = 24;
            this.lblHoTen.Text = "Họ và tên:";
            // 
            // lblNgaySinh
            // 
            this.lblNgaySinh.AutoSize = true;
            this.lblNgaySinh.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblNgaySinh.Location = new System.Drawing.Point(84, 191);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(152, 27);
            this.lblNgaySinh.TabIndex = 23;
            this.lblNgaySinh.Text = "Ngày sinh:";
            // 
            // lblGioiTinh
            // 
            this.lblGioiTinh.AutoSize = true;
            this.lblGioiTinh.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblGioiTinh.Location = new System.Drawing.Point(589, 89);
            this.lblGioiTinh.Name = "lblGioiTinh";
            this.lblGioiTinh.Size = new System.Drawing.Size(152, 27);
            this.lblGioiTinh.TabIndex = 21;
            this.lblGioiTinh.Text = "Giới tính:";
            // 
            // txtGioiTinh
            // 
            this.txtGioiTinh.Location = new System.Drawing.Point(594, 142);
            this.txtGioiTinh.Name = "txtGioiTinh";
            this.txtGioiTinh.Size = new System.Drawing.Size(399, 23);
            this.txtGioiTinh.TabIndex = 34;
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.Location = new System.Drawing.Point(557, 408);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(94, 29);
            this.btnXacNhan.TabIndex = 35;
            this.btnXacNhan.Text = "Xác nhận";
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(413, 408);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(94, 29);
            this.btnXoa.TabIndex = 35;
            this.btnXoa.Text = "Xóa tài khoản";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // frmEditTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 466);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnXacNhan);
            this.Controls.Add(this.txtGioiTinh);
            this.Controls.Add(this.txtSoDienThoai);
            this.Controls.Add(this.lblSDT);
            this.Controls.Add(this.lblThemTaiKhoan);
            this.Controls.Add(this.dateSinhNhat);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.lblHoTen);
            this.Controls.Add(this.lblNgaySinh);
            this.Controls.Add(this.lblGioiTinh);
            this.Name = "frmEditTaiKhoan";
            this.Text = "frmEditTaiKhoan";
            ((System.ComponentModel.ISupportInitialize)(this.dateSinhNhat.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateSinhNhat.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtSoDienThoai;
        private System.Windows.Forms.Label lblSDT;
        private System.Windows.Forms.Label lblThemTaiKhoan;
        private DevExpress.XtraEditors.DateEdit dateSinhNhat;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.Label lblGioiTinh;
        private System.Windows.Forms.TextBox txtGioiTinh;
        private DevExpress.XtraEditors.SimpleButton btnXacNhan;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
    }
}