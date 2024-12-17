namespace QuanLyLopHoc
{
    partial class frmThaoTacTaiKhoan
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
            this.lblTenGiaoVien = new System.Windows.Forms.Label();
            this.txtTenGiaoVien = new System.Windows.Forms.TextBox();
            this.btnThaoTac = new DevExpress.XtraEditors.SimpleButton();
            this.lblTitleEdit = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTenGiaoVien
            // 
            this.lblTenGiaoVien.AutoSize = true;
            this.lblTenGiaoVien.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTenGiaoVien.Location = new System.Drawing.Point(87, 62);
            this.lblTenGiaoVien.Name = "lblTenGiaoVien";
            this.lblTenGiaoVien.Size = new System.Drawing.Size(102, 17);
            this.lblTenGiaoVien.TabIndex = 0;
            this.lblTenGiaoVien.Text = "Tên giáo viên:";
            // 
            // txtTenGiaoVien
            // 
            this.txtTenGiaoVien.Location = new System.Drawing.Point(205, 59);
            this.txtTenGiaoVien.Name = "txtTenGiaoVien";
            this.txtTenGiaoVien.Size = new System.Drawing.Size(292, 23);
            this.txtTenGiaoVien.TabIndex = 1;
            // 
            // btnThaoTac
            // 
            this.btnThaoTac.Location = new System.Drawing.Point(262, 121);
            this.btnThaoTac.Name = "btnThaoTac";
            this.btnThaoTac.Size = new System.Drawing.Size(94, 29);
            this.btnThaoTac.TabIndex = 2;
            this.btnThaoTac.Text = "Thao tác";
            this.btnThaoTac.Click += new System.EventHandler(this.btnThaoTac_Click);
            // 
            // lblTitleEdit
            // 
            this.lblTitleEdit.AutoSize = true;
            this.lblTitleEdit.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTitleEdit.ForeColor = System.Drawing.Color.Red;
            this.lblTitleEdit.Location = new System.Drawing.Point(215, -2);
            this.lblTitleEdit.Name = "lblTitleEdit";
            this.lblTitleEdit.Size = new System.Drawing.Size(238, 32);
            this.lblTitleEdit.TabIndex = 3;
            this.lblTitleEdit.Text = "Nhập tên giáo viên";
            // 
            // frmThaoTacTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 173);
            this.Controls.Add(this.lblTitleEdit);
            this.Controls.Add(this.btnThaoTac);
            this.Controls.Add(this.txtTenGiaoVien);
            this.Controls.Add(this.lblTenGiaoVien);
            this.Name = "frmThaoTacTaiKhoan";
            this.Text = "EditTaiKhoan";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTenGiaoVien;
        private System.Windows.Forms.TextBox txtTenGiaoVien;
        private DevExpress.XtraEditors.SimpleButton btnThaoTac;
        private System.Windows.Forms.Label lblTitleEdit;
    }
}