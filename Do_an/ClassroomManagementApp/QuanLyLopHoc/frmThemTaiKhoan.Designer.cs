namespace QuanLyLopHoc
{
    partial class frmThemTaiKhoan
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
            this.panelRight = new System.Windows.Forms.Panel();
            this.btnThoat = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblMatKhau = new System.Windows.Forms.Label();
            this.lblThemTaiKhoan = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.dateSinhNhat = new DevExpress.XtraEditors.DateEdit();
            this.txtGioiTinh = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.lblGioiTinh = new System.Windows.Forms.Label();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.labelLv = new System.Windows.Forms.Label();
            this.comboBoxLV = new System.Windows.Forms.ComboBox();
            this.panelRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateSinhNhat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateSinhNhat.Properties.CalendarTimeProperties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelRight
            // 
            this.panelRight.BackColor = System.Drawing.Color.White;
            this.panelRight.Controls.Add(this.comboBoxLV);
            this.panelRight.Controls.Add(this.labelLv);
            this.panelRight.Controls.Add(this.btnThoat);
            this.panelRight.Controls.Add(this.txtPassword);
            this.panelRight.Controls.Add(this.lblMatKhau);
            this.panelRight.Controls.Add(this.lblThemTaiKhoan);
            this.panelRight.Controls.Add(this.btnThem);
            this.panelRight.Controls.Add(this.dateSinhNhat);
            this.panelRight.Controls.Add(this.txtGioiTinh);
            this.panelRight.Controls.Add(this.txtEmail);
            this.panelRight.Controls.Add(this.lblEmail);
            this.panelRight.Controls.Add(this.txtHoTen);
            this.panelRight.Controls.Add(this.lblHoTen);
            this.panelRight.Controls.Add(this.lblGioiTinh);
            this.panelRight.Controls.Add(this.lblNgaySinh);
            this.panelRight.Controls.Add(this.txtUsername);
            this.panelRight.Controls.Add(this.lblUsername);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRight.Location = new System.Drawing.Point(0, 0);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(986, 489);
            this.panelRight.TabIndex = 1;
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThoat.Location = new System.Drawing.Point(787, 413);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(135, 50);
            this.btnThoat.TabIndex = 21;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(28, 251);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(404, 23);
            this.txtPassword.TabIndex = 18;
            // 
            // lblMatKhau
            // 
            this.lblMatKhau.AutoSize = true;
            this.lblMatKhau.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblMatKhau.Location = new System.Drawing.Point(28, 196);
            this.lblMatKhau.Name = "lblMatKhau";
            this.lblMatKhau.Size = new System.Drawing.Size(208, 27);
            this.lblMatKhau.TabIndex = 17;
            this.lblMatKhau.Text = "Nhập mật khẩu:";
            // 
            // lblThemTaiKhoan
            // 
            this.lblThemTaiKhoan.AutoSize = true;
            this.lblThemTaiKhoan.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblThemTaiKhoan.ForeColor = System.Drawing.Color.Red;
            this.lblThemTaiKhoan.Location = new System.Drawing.Point(342, 33);
            this.lblThemTaiKhoan.Name = "lblThemTaiKhoan";
            this.lblThemTaiKhoan.Size = new System.Drawing.Size(267, 34);
            this.lblThemTaiKhoan.TabIndex = 16;
            this.lblThemTaiKhoan.Text = "Thêm tài khoản";
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThem.Location = new System.Drawing.Point(580, 413);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(135, 50);
            this.btnThem.TabIndex = 14;
            this.btnThem.Text = "Thêm tài khoản";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // dateSinhNhat
            // 
            this.dateSinhNhat.EditValue = null;
            this.dateSinhNhat.Location = new System.Drawing.Point(546, 245);
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
            this.dateSinhNhat.TabIndex = 13;
            // 
            // txtGioiTinh
            // 
            this.txtGioiTinh.Location = new System.Drawing.Point(546, 357);
            this.txtGioiTinh.Name = "txtGioiTinh";
            this.txtGioiTinh.Size = new System.Drawing.Size(405, 23);
            this.txtGioiTinh.TabIndex = 10;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(28, 357);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(405, 23);
            this.txtEmail.TabIndex = 10;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblEmail.Location = new System.Drawing.Point(28, 302);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(208, 27);
            this.lblEmail.TabIndex = 9;
            this.lblEmail.Text = "Email liên hệ:";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(546, 143);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(405, 23);
            this.txtHoTen.TabIndex = 8;
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblHoTen.Location = new System.Drawing.Point(546, 90);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(152, 27);
            this.lblHoTen.TabIndex = 7;
            this.lblHoTen.Text = "Họ và tên:";
            // 
            // lblGioiTinh
            // 
            this.lblGioiTinh.AutoSize = true;
            this.lblGioiTinh.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblGioiTinh.Location = new System.Drawing.Point(546, 302);
            this.lblGioiTinh.Name = "lblGioiTinh";
            this.lblGioiTinh.Size = new System.Drawing.Size(152, 27);
            this.lblGioiTinh.TabIndex = 5;
            this.lblGioiTinh.Text = "Giới tính:";
            // 
            // lblNgaySinh
            // 
            this.lblNgaySinh.AutoSize = true;
            this.lblNgaySinh.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblNgaySinh.Location = new System.Drawing.Point(546, 192);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(152, 27);
            this.lblNgaySinh.TabIndex = 5;
            this.lblNgaySinh.Text = "Ngày sinh:";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(28, 145);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(404, 23);
            this.txtUsername.TabIndex = 4;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblUsername.Location = new System.Drawing.Point(28, 90);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(208, 27);
            this.lblUsername.TabIndex = 3;
            this.lblUsername.Text = "Tên tài khoản:";
            // 
            // labelLv
            // 
            this.labelLv.AutoSize = true;
            this.labelLv.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelLv.Location = new System.Drawing.Point(28, 424);
            this.labelLv.Name = "labelLv";
            this.labelLv.Size = new System.Drawing.Size(152, 27);
            this.labelLv.TabIndex = 22;
            this.labelLv.Text = "Quyền hạn:";
            // 
            // comboBoxLV
            // 
            this.comboBoxLV.FormattingEnabled = true;
            this.comboBoxLV.Items.AddRange(new object[] {
            "Admin",
            "Giáo vụ",
            "Giáo viên"});
            this.comboBoxLV.Location = new System.Drawing.Point(186, 428);
            this.comboBoxLV.Name = "comboBoxLV";
            this.comboBoxLV.Size = new System.Drawing.Size(246, 24);
            this.comboBoxLV.TabIndex = 23;
            // 
            // frmThemTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 489);
            this.Controls.Add(this.panelRight);
            this.Name = "frmThemTaiKhoan";
            this.Text = "ThemTaiKhoan";
            this.panelRight.ResumeLayout(false);
            this.panelRight.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateSinhNhat.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateSinhNhat.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.Label lblThemTaiKhoan;
        private System.Windows.Forms.Button btnThem;
        private DevExpress.XtraEditors.DateEdit dateSinhNhat;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblMatKhau;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.TextBox txtGioiTinh;
        private System.Windows.Forms.Label lblGioiTinh;
        private System.Windows.Forms.ComboBox comboBoxLV;
        private System.Windows.Forms.Label labelLv;
    }
}