namespace QuanLyLopHoc
{
    partial class frmResetMatKhau
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
            this.btnXacNhan = new DevExpress.XtraEditors.SimpleButton();
            this.lblRepeat = new DevExpress.XtraEditors.LabelControl();
            this.lblMKnew = new DevExpress.XtraEditors.LabelControl();
            this.txtRepeat = new DevExpress.XtraEditors.TextEdit();
            this.txtMatKhauMoi = new DevExpress.XtraEditors.TextEdit();
            this.panellblReset = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtRepeat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMatKhauMoi.Properties)).BeginInit();
            this.panellblReset.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.Location = new System.Drawing.Point(157, 256);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(153, 29);
            this.btnXacNhan.TabIndex = 13;
            this.btnXacNhan.Text = "Xác nhận";
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // lblRepeat
            // 
            this.lblRepeat.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRepeat.Appearance.Options.UseFont = true;
            this.lblRepeat.Location = new System.Drawing.Point(128, 160);
            this.lblRepeat.Name = "lblRepeat";
            this.lblRepeat.Size = new System.Drawing.Size(134, 21);
            this.lblRepeat.TabIndex = 10;
            this.lblRepeat.Text = "Nhập lại mật khẩu";
            // 
            // lblMKnew
            // 
            this.lblMKnew.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMKnew.Appearance.Options.UseFont = true;
            this.lblMKnew.Location = new System.Drawing.Point(128, 91);
            this.lblMKnew.Name = "lblMKnew";
            this.lblMKnew.Size = new System.Drawing.Size(100, 21);
            this.lblMKnew.TabIndex = 9;
            this.lblMKnew.Text = "Mật khẩu mới";
            // 
            // txtRepeat
            // 
            this.txtRepeat.Location = new System.Drawing.Point(128, 191);
            this.txtRepeat.Name = "txtRepeat";
            this.txtRepeat.Size = new System.Drawing.Size(244, 22);
            this.txtRepeat.TabIndex = 12;
            // 
            // txtMatKhauMoi
            // 
            this.txtMatKhauMoi.Location = new System.Drawing.Point(128, 120);
            this.txtMatKhauMoi.Name = "txtMatKhauMoi";
            this.txtMatKhauMoi.Size = new System.Drawing.Size(244, 22);
            this.txtMatKhauMoi.TabIndex = 11;
            // 
            // panellblReset
            // 
            this.panellblReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panellblReset.Controls.Add(this.label1);
            this.panellblReset.Dock = System.Windows.Forms.DockStyle.Top;
            this.panellblReset.Location = new System.Drawing.Point(0, 0);
            this.panellblReset.Name = "panellblReset";
            this.panellblReset.Size = new System.Drawing.Size(513, 72);
            this.panellblReset.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(188, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đổi mật khẩu";
            // 
            // frmResetMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 325);
            this.Controls.Add(this.panellblReset);
            this.Controls.Add(this.btnXacNhan);
            this.Controls.Add(this.txtRepeat);
            this.Controls.Add(this.txtMatKhauMoi);
            this.Controls.Add(this.lblRepeat);
            this.Controls.Add(this.lblMKnew);
            this.Name = "frmResetMatKhau";
            this.Text = "frmResetMatKhau";
            ((System.ComponentModel.ISupportInitialize)(this.txtRepeat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMatKhauMoi.Properties)).EndInit();
            this.panellblReset.ResumeLayout(false);
            this.panellblReset.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnXacNhan;
        private DevExpress.XtraEditors.TextEdit txtRepeat;
        private DevExpress.XtraEditors.TextEdit txtMatKhauMoi;
        private DevExpress.XtraEditors.LabelControl lblRepeat;
        private DevExpress.XtraEditors.LabelControl lblMKnew;
        private System.Windows.Forms.Panel panellblReset;
        private System.Windows.Forms.Label label1;
    }
}