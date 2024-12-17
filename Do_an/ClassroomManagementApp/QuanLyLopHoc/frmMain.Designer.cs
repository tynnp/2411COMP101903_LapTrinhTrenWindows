namespace QuanLyLopHoc
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.accMenu = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.accQuanLyTaiKhoan = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accQuanLyHocSinh = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accQuanLyGiaoVien = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accQuanLyGiangDay = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accNhapDiemHocsinh = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accHuongDanSuDung = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accGioiThieu = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnOwnControl = new DevExpress.XtraEditors.SimpleButton();
            this.lblTenFormDangMo = new DevExpress.XtraEditors.LabelControl();
            this.panelBody = new DevExpress.XtraEditors.PanelControl();
            this.popupOwnControl = new DevExpress.XtraBars.PopupControlContainer(this.components);
            this.btnProfile = new DevExpress.XtraEditors.SimpleButton();
            this.btnSignOut = new DevExpress.XtraEditors.SimpleButton();
            this.btnChangePassword = new DevExpress.XtraEditors.SimpleButton();
            this.barManagerDateTime = new DevExpress.XtraBars.BarManager(this.components);
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barTime = new DevExpress.XtraBars.BarStaticItem();
            this.barDate = new DevExpress.XtraBars.BarStaticItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            ((System.ComponentModel.ISupportInitialize)(this.accMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelBody)).BeginInit();
            this.panelBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.popupOwnControl)).BeginInit();
            this.popupOwnControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barManagerDateTime)).BeginInit();
            this.SuspendLayout();
            // 
            // accMenu
            // 
            this.accMenu.Appearance.AccordionControl.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accMenu.Appearance.AccordionControl.ForeColor = System.Drawing.Color.White;
            this.accMenu.Appearance.AccordionControl.Options.UseFont = true;
            this.accMenu.Appearance.AccordionControl.Options.UseForeColor = true;
            this.accMenu.Appearance.Hint.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accMenu.Appearance.Hint.Options.UseFont = true;
            this.accMenu.Appearance.Item.Default.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accMenu.Appearance.Item.Default.Options.UseFont = true;
            this.accMenu.Appearance.Item.Disabled.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accMenu.Appearance.Item.Disabled.Options.UseFont = true;
            this.accMenu.Appearance.Item.Hovered.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accMenu.Appearance.Item.Hovered.Options.UseFont = true;
            this.accMenu.Appearance.Item.Normal.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accMenu.Appearance.Item.Normal.Options.UseFont = true;
            this.accMenu.Appearance.Item.Pressed.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accMenu.Appearance.Item.Pressed.Options.UseFont = true;
            this.accMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.accMenu.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accQuanLyTaiKhoan,
            this.accQuanLyHocSinh,
            this.accQuanLyGiaoVien,
            this.accQuanLyGiangDay,
            this.accNhapDiemHocsinh,
            this.accHuongDanSuDung,
            this.accGioiThieu});
            this.accMenu.Location = new System.Drawing.Point(0, 0);
            this.accMenu.Margin = new System.Windows.Forms.Padding(8);
            this.accMenu.Name = "accMenu";
            this.accMenu.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Hidden;
            this.accMenu.Size = new System.Drawing.Size(243, 515);
            this.accMenu.TabIndex = 0;
            this.accMenu.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu;
            // 
            // accQuanLyTaiKhoan
            // 
            this.accQuanLyTaiKhoan.ImageOptions.Image = global::QuanLyLopHoc.Properties.Resources.user;
            this.accQuanLyTaiKhoan.ImageOptions.ImageLayoutMode = DevExpress.XtraBars.Navigation.ImageLayoutMode.Stretch;
            this.accQuanLyTaiKhoan.Name = "accQuanLyTaiKhoan";
            this.accQuanLyTaiKhoan.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accQuanLyTaiKhoan.Text = "Quản lý tài khoản";
            this.accQuanLyTaiKhoan.Click += new System.EventHandler(this.accQuanLyTaiKhoan_Click);
            // 
            // accQuanLyHocSinh
            // 
            this.accQuanLyHocSinh.ImageOptions.Image = global::QuanLyLopHoc.Properties.Resources.hocsinh;
            this.accQuanLyHocSinh.ImageOptions.ImageLayoutMode = DevExpress.XtraBars.Navigation.ImageLayoutMode.Stretch;
            this.accQuanLyHocSinh.Name = "accQuanLyHocSinh";
            this.accQuanLyHocSinh.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accQuanLyHocSinh.Text = "Quản lý học sinh";
            this.accQuanLyHocSinh.Click += new System.EventHandler(this.accQuanLyHocSinh_Click);
            // 
            // accQuanLyGiaoVien
            // 
            this.accQuanLyGiaoVien.ImageOptions.Image = global::QuanLyLopHoc.Properties.Resources.giaovien;
            this.accQuanLyGiaoVien.ImageOptions.ImageLayoutMode = DevExpress.XtraBars.Navigation.ImageLayoutMode.Stretch;
            this.accQuanLyGiaoVien.Name = "accQuanLyGiaoVien";
            this.accQuanLyGiaoVien.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accQuanLyGiaoVien.Text = "Quản lý giáo viên";
            this.accQuanLyGiaoVien.Click += new System.EventHandler(this.accQuanLyGiaoVien_Click);
            // 
            // accQuanLyGiangDay
            // 
            this.accQuanLyGiangDay.ImageOptions.Image = global::QuanLyLopHoc.Properties.Resources.lichday;
            this.accQuanLyGiangDay.ImageOptions.ImageLayoutMode = DevExpress.XtraBars.Navigation.ImageLayoutMode.Stretch;
            this.accQuanLyGiangDay.Name = "accQuanLyGiangDay";
            this.accQuanLyGiangDay.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accQuanLyGiangDay.Text = "Quản lý giảng dạy";
            this.accQuanLyGiangDay.Click += new System.EventHandler(this.accQuanLyLichDay_Click);
            // 
            // accNhapDiemHocsinh
            // 
            this.accNhapDiemHocsinh.ImageOptions.Image = global::QuanLyLopHoc.Properties.Resources.diem;
            this.accNhapDiemHocsinh.ImageOptions.ImageLayoutMode = DevExpress.XtraBars.Navigation.ImageLayoutMode.Stretch;
            this.accNhapDiemHocsinh.Name = "accNhapDiemHocsinh";
            this.accNhapDiemHocsinh.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accNhapDiemHocsinh.Text = "Nhập điểm học sinh";
            this.accNhapDiemHocsinh.Click += new System.EventHandler(this.accNhapDiemHocSinh_Click);
            // 
            // accHuongDanSuDung
            // 
            this.accHuongDanSuDung.ImageOptions.Image = global::QuanLyLopHoc.Properties.Resources.huongdan;
            this.accHuongDanSuDung.ImageOptions.ImageLayoutMode = DevExpress.XtraBars.Navigation.ImageLayoutMode.Stretch;
            this.accHuongDanSuDung.Name = "accHuongDanSuDung";
            this.accHuongDanSuDung.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accHuongDanSuDung.Text = "Hướng dẫn sử dụng";
            this.accHuongDanSuDung.Click += new System.EventHandler(this.accHuongDanSuDung_Click);
            // 
            // accGioiThieu
            // 
            this.accGioiThieu.ImageOptions.Image = global::QuanLyLopHoc.Properties.Resources.gioithieu;
            this.accGioiThieu.ImageOptions.ImageLayoutMode = DevExpress.XtraBars.Navigation.ImageLayoutMode.Stretch;
            this.accGioiThieu.Name = "accGioiThieu";
            this.accGioiThieu.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accGioiThieu.Text = "Giới thiệu";
            this.accGioiThieu.Click += new System.EventHandler(this.accGioiThieu_Click);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnOwnControl);
            this.panelControl1.Controls.Add(this.lblTenFormDangMo);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(243, 0);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(8);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1266, 66);
            this.panelControl1.TabIndex = 1;
            // 
            // btnOwnControl
            // 
            this.btnOwnControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOwnControl.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOwnControl.Appearance.Options.UseFont = true;
            this.btnOwnControl.Location = new System.Drawing.Point(977, 18);
            this.btnOwnControl.Margin = new System.Windows.Forms.Padding(6);
            this.btnOwnControl.Name = "btnOwnControl";
            this.btnOwnControl.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnOwnControl.Size = new System.Drawing.Size(274, 33);
            this.btnOwnControl.TabIndex = 3;
            this.btnOwnControl.Text = "xinChaoUser";
            this.btnOwnControl.Click += new System.EventHandler(this.btnOwnControl_Click);
            // 
            // lblTenFormDangMo
            // 
            this.lblTenFormDangMo.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenFormDangMo.Appearance.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblTenFormDangMo.Appearance.Options.UseFont = true;
            this.lblTenFormDangMo.Appearance.Options.UseForeColor = true;
            this.lblTenFormDangMo.Location = new System.Drawing.Point(15, 30);
            this.lblTenFormDangMo.Margin = new System.Windows.Forms.Padding(8);
            this.lblTenFormDangMo.Name = "lblTenFormDangMo";
            this.lblTenFormDangMo.Size = new System.Drawing.Size(159, 21);
            this.lblTenFormDangMo.TabIndex = 1;
            this.lblTenFormDangMo.Text = "Chưa mở form nào";
            // 
            // panelBody
            // 
            this.panelBody.Controls.Add(this.popupOwnControl);
            this.panelBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBody.Location = new System.Drawing.Point(243, 66);
            this.panelBody.Margin = new System.Windows.Forms.Padding(8);
            this.panelBody.Name = "panelBody";
            this.panelBody.Size = new System.Drawing.Size(1266, 449);
            this.panelBody.TabIndex = 2;
            // 
            // popupOwnControl
            // 
            this.popupOwnControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.popupOwnControl.Controls.Add(this.btnProfile);
            this.popupOwnControl.Controls.Add(this.btnSignOut);
            this.popupOwnControl.Controls.Add(this.btnChangePassword);
            this.popupOwnControl.Location = new System.Drawing.Point(1021, 5);
            this.popupOwnControl.Manager = this.barManagerDateTime;
            this.popupOwnControl.Name = "popupOwnControl";
            this.popupOwnControl.Size = new System.Drawing.Size(275, 305);
            this.popupOwnControl.TabIndex = 3;
            this.popupOwnControl.Visible = false;
            // 
            // btnProfile
            // 
            this.btnProfile.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfile.Appearance.Options.UseFont = true;
            this.btnProfile.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnProfile.ImageOptions.SvgImage")));
            this.btnProfile.Location = new System.Drawing.Point(27, 24);
            this.btnProfile.Margin = new System.Windows.Forms.Padding(6);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnProfile.Size = new System.Drawing.Size(199, 78);
            this.btnProfile.TabIndex = 0;
            this.btnProfile.Text = "Hồ sơ của tôi";
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // btnSignOut
            // 
            this.btnSignOut.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignOut.Appearance.Options.UseFont = true;
            this.btnSignOut.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSignOut.ImageOptions.SvgImage")));
            this.btnSignOut.Location = new System.Drawing.Point(27, 215);
            this.btnSignOut.Margin = new System.Windows.Forms.Padding(10);
            this.btnSignOut.Name = "btnSignOut";
            this.btnSignOut.Size = new System.Drawing.Size(199, 69);
            this.btnSignOut.TabIndex = 2;
            this.btnSignOut.Text = "Đăng xuất ";
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangePassword.Appearance.Options.UseFont = true;
            this.btnChangePassword.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnChangePassword.ImageOptions.SvgImage")));
            this.btnChangePassword.Location = new System.Drawing.Point(27, 116);
            this.btnChangePassword.Margin = new System.Windows.Forms.Padding(8);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnChangePassword.Size = new System.Drawing.Size(199, 74);
            this.btnChangePassword.TabIndex = 1;
            this.btnChangePassword.Text = "Đổi mật khẩu";
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // barManagerDateTime
            // 
            this.barManagerDateTime.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar3});
            this.barManagerDateTime.DockControls.Add(this.barDockControlTop);
            this.barManagerDateTime.DockControls.Add(this.barDockControlBottom);
            this.barManagerDateTime.DockControls.Add(this.barDockControlLeft);
            this.barManagerDateTime.DockControls.Add(this.barDockControlRight);
            this.barManagerDateTime.Form = this;
            this.barManagerDateTime.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barTime,
            this.barDate});
            this.barManagerDateTime.MaxItemId = 2;
            this.barManagerDateTime.StatusBar = this.bar3;
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barTime),
            new DevExpress.XtraBars.LinkPersistInfo(this.barDate)});
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barTime
            // 
            this.barTime.Caption = "đồng hồ";
            this.barTime.Id = 0;
            this.barTime.Name = "barTime";
            // 
            // barDate
            // 
            this.barDate.Caption = "lịch";
            this.barDate.Id = 1;
            this.barDate.Name = "barDate";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManagerDateTime;
            this.barDockControlTop.Size = new System.Drawing.Size(1509, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 515);
            this.barDockControlBottom.Manager = this.barManagerDateTime;
            this.barDockControlBottom.Size = new System.Drawing.Size(1509, 27);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManagerDateTime;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 515);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1509, 0);
            this.barDockControlRight.Manager = this.barManagerDateTime;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 515);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1509, 542);
            this.Controls.Add(this.panelBody);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.accMenu);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.IconOptions.Image = global::QuanLyLopHoc.Properties.Resources.logo;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMain";
            this.Text = "Quản lý lớp học";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.accMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelBody)).EndInit();
            this.panelBody.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.popupOwnControl)).EndInit();
            this.popupOwnControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.barManagerDateTime)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Navigation.AccordionControl accMenu;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accQuanLyHocSinh;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelBody;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accQuanLyGiaoVien;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accQuanLyGiangDay;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accNhapDiemHocsinh;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accQuanLyTaiKhoan;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accHuongDanSuDung;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accGioiThieu;
        private DevExpress.XtraEditors.LabelControl lblTenFormDangMo;
        private DevExpress.XtraEditors.SimpleButton btnOwnControl;
        private DevExpress.XtraEditors.SimpleButton btnProfile;
        private DevExpress.XtraEditors.SimpleButton btnSignOut;
        private DevExpress.XtraEditors.SimpleButton btnChangePassword;
        private DevExpress.XtraBars.PopupControlContainer popupOwnControl;
        private DevExpress.XtraBars.BarManager barManagerDateTime;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarStaticItem barTime;
        private DevExpress.XtraBars.BarStaticItem barDate;
    }
}

