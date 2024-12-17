namespace QuanLyLopHoc
{
    partial class frmDoiMatKhau
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.ownPw = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.newPw = new DevExpress.XtraEditors.TextEdit();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.NewPwAgain = new DevExpress.XtraEditors.TextEdit();
            this.submitResetPw = new DevExpress.XtraEditors.SimpleButton();
            this.toastNotificationsManager1 = new DevExpress.XtraBars.ToastNotifications.ToastNotificationsManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ownPw.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newPw.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NewPwAgain.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toastNotificationsManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(101, 56);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(128, 21);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Mật khẩu hiện tại";
            // 
            // ownPw
            // 
            this.ownPw.Location = new System.Drawing.Point(101, 84);
            this.ownPw.Name = "ownPw";
            this.ownPw.Size = new System.Drawing.Size(244, 22);
            this.ownPw.TabIndex = 1;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(101, 121);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(100, 21);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Mật khẩu mới";
            this.labelControl2.Click += new System.EventHandler(this.labelControl2_Click);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(101, 190);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(134, 21);
            this.labelControl3.TabIndex = 3;
            this.labelControl3.Text = "Nhập lại mật khẩu";
            this.labelControl3.Click += new System.EventHandler(this.labelControl3_Click);
            // 
            // newPw
            // 
            this.newPw.Location = new System.Drawing.Point(101, 150);
            this.newPw.Name = "newPw";
            this.newPw.Size = new System.Drawing.Size(244, 22);
            this.newPw.TabIndex = 4;
            // 
            // NewPwAgain
            // 
            this.NewPwAgain.Location = new System.Drawing.Point(101, 221);
            this.NewPwAgain.Name = "NewPwAgain";
            this.NewPwAgain.Size = new System.Drawing.Size(244, 22);
            this.NewPwAgain.TabIndex = 5;
            // 
            // submitResetPw
            // 
            this.submitResetPw.Location = new System.Drawing.Point(140, 261);
            this.submitResetPw.Name = "submitResetPw";
            this.submitResetPw.Size = new System.Drawing.Size(153, 29);
            this.submitResetPw.TabIndex = 6;
            this.submitResetPw.Text = "Hoàn thành";
            this.submitResetPw.Click += new System.EventHandler(this.submitResetPw_Click);
            // 
            // toastNotificationsManager1
            // 
            this.toastNotificationsManager1.ApplicationId = "cfc5278b-ebe2-400e-b3ad-7c6553a32487";
            // 
            // frmDoiMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 365);
            this.Controls.Add(this.submitResetPw);
            this.Controls.Add(this.NewPwAgain);
            this.Controls.Add(this.newPw);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.ownPw);
            this.Controls.Add(this.labelControl1);
            this.Name = "frmDoiMatKhau";
            this.Text = "Đổi mật khẩu";
            this.Load += new System.EventHandler(this.frmDoiMatKhau_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ownPw.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newPw.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NewPwAgain.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toastNotificationsManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit ownPw;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit newPw;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private DevExpress.XtraEditors.TextEdit NewPwAgain;
        private DevExpress.XtraEditors.SimpleButton submitResetPw;
        private DevExpress.XtraBars.ToastNotifications.ToastNotificationsManager toastNotificationsManager1;
    }
}