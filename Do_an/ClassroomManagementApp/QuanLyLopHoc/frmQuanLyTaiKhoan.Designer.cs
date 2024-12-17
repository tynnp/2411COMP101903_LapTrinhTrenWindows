namespace QuanLyLopHoc
{
    partial class frmQuanLyTaiKhoan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuanLyTaiKhoan));
            this.tAIKHOANBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cK_QLHS_DBDataSet = new QuanLyLopHoc.CK_QLHS_DBDataSet();
            this.cKQLHSDBDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cK_QLHS_DBDataSet1 = new QuanLyLopHoc.CK_QLHS_DBDataSet();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.panelControlQLTKtable = new DevExpress.XtraEditors.PanelControl();
            this.panelControlQLTK = new DevExpress.XtraEditors.PanelControl();
            this.btnThaoTacTaiKhoan = new DevExpress.XtraEditors.SimpleButton();
            this.btnThemTaiKhoan = new DevExpress.XtraEditors.SimpleButton();
            this.tAIKHOANTableAdapter = new QuanLyLopHoc.CK_QLHS_DBDataSetTableAdapters.TAIKHOANTableAdapter();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.taikhoanTableAdapter1 = new QuanLyLopHoc.CK_QLHS_DBDataSetTableAdapters.TAIKHOANTableAdapter();
            this.dvgTK = new System.Windows.Forms.DataGridView();
            this.colMaTaiKhoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenDangNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMatKhau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLoaiTaiKhoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tAIKHOANBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cK_QLHS_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cKQLHSDBDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cK_QLHS_DBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlQLTKtable)).BeginInit();
            this.panelControlQLTKtable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlQLTK)).BeginInit();
            this.panelControlQLTK.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgTK)).BeginInit();
            this.SuspendLayout();
            // 
            // tAIKHOANBindingSource
            // 
            this.tAIKHOANBindingSource.DataMember = "TAIKHOAN";
            this.tAIKHOANBindingSource.DataSource = this.cK_QLHS_DBDataSet;
            // 
            // cK_QLHS_DBDataSet
            // 
            this.cK_QLHS_DBDataSet.DataSetName = "CK_QLHS_DBDataSet";
            this.cK_QLHS_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cKQLHSDBDataSet1BindingSource
            // 
            this.cKQLHSDBDataSet1BindingSource.DataSource = this.cK_QLHS_DBDataSet1;
            this.cKQLHSDBDataSet1BindingSource.Position = 0;
            // 
            // cK_QLHS_DBDataSet1
            // 
            this.cK_QLHS_DBDataSet1.DataSetName = "CK_QLHS_DBDataSet";
            this.cK_QLHS_DBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.panelControlQLTKtable);
            this.panelControl1.Controls.Add(this.panelControlQLTK);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1659, 769);
            this.panelControl1.TabIndex = 8;
            this.panelControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.panelControl1_Paint);
            // 
            // panelControlQLTKtable
            // 
            this.panelControlQLTKtable.Controls.Add(this.dvgTK);
            this.panelControlQLTKtable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControlQLTKtable.Location = new System.Drawing.Point(2, 61);
            this.panelControlQLTKtable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelControlQLTKtable.Name = "panelControlQLTKtable";
            this.panelControlQLTKtable.Size = new System.Drawing.Size(1655, 706);
            this.panelControlQLTKtable.TabIndex = 4;
            // 
            // panelControlQLTK
            // 
            this.panelControlQLTK.Controls.Add(this.btnThaoTacTaiKhoan);
            this.panelControlQLTK.Controls.Add(this.btnThemTaiKhoan);
            this.panelControlQLTK.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControlQLTK.Location = new System.Drawing.Point(2, 2);
            this.panelControlQLTK.Name = "panelControlQLTK";
            this.panelControlQLTK.Size = new System.Drawing.Size(1655, 59);
            this.panelControlQLTK.TabIndex = 3;
            // 
            // btnThaoTacTaiKhoan
            // 
            this.btnThaoTacTaiKhoan.Location = new System.Drawing.Point(151, 21);
            this.btnThaoTacTaiKhoan.Name = "btnThaoTacTaiKhoan";
            this.btnThaoTacTaiKhoan.Size = new System.Drawing.Size(149, 29);
            this.btnThaoTacTaiKhoan.TabIndex = 0;
            this.btnThaoTacTaiKhoan.Text = "Thao tác";
            this.btnThaoTacTaiKhoan.Click += new System.EventHandler(this.btnThaoTacTaiKhoan_Click);
            // 
            // btnThemTaiKhoan
            // 
            this.btnThemTaiKhoan.Location = new System.Drawing.Point(5, 21);
            this.btnThemTaiKhoan.Name = "btnThemTaiKhoan";
            this.btnThemTaiKhoan.Size = new System.Drawing.Size(94, 29);
            this.btnThemTaiKhoan.TabIndex = 0;
            this.btnThemTaiKhoan.Text = "Thêm";
            this.btnThemTaiKhoan.Click += new System.EventHandler(this.btnThemTaiKhoan_Click);
            // 
            // tAIKHOANTableAdapter
            // 
            this.tAIKHOANTableAdapter.ClearBeforeFill = true;
            // 
            // taikhoanTableAdapter1
            // 
            this.taikhoanTableAdapter1.ClearBeforeFill = true;
            // 
            // dvgTK
            // 
            this.dvgTK.AllowUserToAddRows = false;
            this.dvgTK.AllowUserToDeleteRows = false;
            this.dvgTK.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dvgTK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgTK.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaTaiKhoan,
            this.colTenDangNhap,
            this.colMatKhau,
            this.colLoaiTaiKhoan,
            this.colMaGV});
            this.dvgTK.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvgTK.Location = new System.Drawing.Point(2, 2);
            this.dvgTK.Name = "dvgTK";
            this.dvgTK.ReadOnly = true;
            this.dvgTK.RowHeadersWidth = 51;
            this.dvgTK.RowTemplate.Height = 24;
            this.dvgTK.Size = new System.Drawing.Size(1651, 702);
            this.dvgTK.TabIndex = 0;
            // 
            // colMaTaiKhoan
            // 
            this.colMaTaiKhoan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.colMaTaiKhoan.DataPropertyName = "MaTK";
            this.colMaTaiKhoan.HeaderText = "Mã tài khoản";
            this.colMaTaiKhoan.MinimumWidth = 6;
            this.colMaTaiKhoan.Name = "colMaTaiKhoan";
            this.colMaTaiKhoan.ReadOnly = true;
            this.colMaTaiKhoan.Width = 109;
            // 
            // colTenDangNhap
            // 
            this.colTenDangNhap.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTenDangNhap.DataPropertyName = "TenDangNhap";
            this.colTenDangNhap.HeaderText = "Tên đăng nhập";
            this.colTenDangNhap.MinimumWidth = 6;
            this.colTenDangNhap.Name = "colTenDangNhap";
            this.colTenDangNhap.ReadOnly = true;
            // 
            // colMatKhau
            // 
            this.colMatKhau.DataPropertyName = "MatKhau";
            this.colMatKhau.HeaderText = "Mật khẩu";
            this.colMatKhau.MinimumWidth = 6;
            this.colMatKhau.Name = "colMatKhau";
            this.colMatKhau.ReadOnly = true;
            this.colMatKhau.Width = 125;
            // 
            // colLoaiTaiKhoan
            // 
            this.colLoaiTaiKhoan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.colLoaiTaiKhoan.DataPropertyName = "LoaiTaiKhoan";
            this.colLoaiTaiKhoan.HeaderText = "Mức quyền hạn";
            this.colLoaiTaiKhoan.MinimumWidth = 6;
            this.colLoaiTaiKhoan.Name = "colLoaiTaiKhoan";
            this.colLoaiTaiKhoan.ReadOnly = true;
            this.colLoaiTaiKhoan.Width = 123;
            // 
            // colMaGV
            // 
            this.colMaGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.colMaGV.DataPropertyName = "MaGV";
            this.colMaGV.HeaderText = "Mã giáo viên";
            this.colMaGV.MinimumWidth = 6;
            this.colMaGV.Name = "colMaGV";
            this.colMaGV.ReadOnly = true;
            this.colMaGV.Width = 108;
            // 
            // frmQuanLyTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1659, 769);
            this.Controls.Add(this.panelControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmQuanLyTaiKhoan";
            this.Text = "Quản lý tài khoản";
            this.Load += new System.EventHandler(this.frmQuanLyTaiKhoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tAIKHOANBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cK_QLHS_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cKQLHSDBDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cK_QLHS_DBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControlQLTKtable)).EndInit();
            this.panelControlQLTKtable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControlQLTK)).EndInit();
            this.panelControlQLTK.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgTK)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControlQLTK;
        private DevExpress.XtraEditors.SimpleButton btnThaoTacTaiKhoan;
        private DevExpress.XtraEditors.SimpleButton btnThemTaiKhoan;
        private DevExpress.XtraEditors.PanelControl panelControlQLTKtable;
        private CK_QLHS_DBDataSet cK_QLHS_DBDataSet;
        private System.Windows.Forms.BindingSource tAIKHOANBindingSource;
        private CK_QLHS_DBDataSetTableAdapters.TAIKHOANTableAdapter tAIKHOANTableAdapter;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private CK_QLHS_DBDataSet cK_QLHS_DBDataSet1;
        private CK_QLHS_DBDataSetTableAdapters.TAIKHOANTableAdapter taikhoanTableAdapter1;
        private System.Windows.Forms.BindingSource cKQLHSDBDataSet1BindingSource;
        private System.Windows.Forms.DataGridView dvgTK;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaTaiKhoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenDangNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMatKhau;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLoaiTaiKhoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaGV;
    }
}