namespace QuanLyLopHoc
{
    partial class frmHoSoCuaToi
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
            this.labelMainTitle = new DevExpress.XtraEditors.LabelControl();
            this.lbName = new System.Windows.Forms.Label();
            this.viewName = new System.Windows.Forms.TextBox();
            this.btnsubmit = new DevExpress.XtraEditors.SimpleButton();
            this.viewGT = new System.Windows.Forms.TextBox();
            this.viewPhN = new System.Windows.Forms.TextBox();
            this.viPhN = new System.Windows.Forms.Label();
            this.viewNS = new DevExpress.XtraEditors.DateEdit();
            this.viewEm = new System.Windows.Forms.TextBox();
            this.lbEm = new System.Windows.Forms.Label();
            this.lbNSinh = new System.Windows.Forms.Label();
            this.lbGT = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.viewNS.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewNS.Properties.CalendarTimeProperties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelMainTitle
            // 
            this.labelMainTitle.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMainTitle.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelMainTitle.Appearance.Options.UseFont = true;
            this.labelMainTitle.Appearance.Options.UseForeColor = true;
            this.labelMainTitle.Location = new System.Drawing.Point(256, 29);
            this.labelMainTitle.Name = "labelMainTitle";
            this.labelMainTitle.Size = new System.Drawing.Size(151, 28);
            this.labelMainTitle.TabIndex = 0;
            this.labelMainTitle.Text = "Hồ sơ của tôi";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbName.Location = new System.Drawing.Point(117, 82);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(152, 27);
            this.lbName.TabIndex = 25;
            this.lbName.Text = "Họ và tên:";
            // 
            // viewName
            // 
            this.viewName.Location = new System.Drawing.Point(122, 121);
            this.viewName.Name = "viewName";
            this.viewName.Size = new System.Drawing.Size(405, 23);
            this.viewName.TabIndex = 26;
            this.viewName.TextChanged += new System.EventHandler(this.viewName_TextChanged);
            // 
            // btnsubmit
            // 
            this.btnsubmit.Location = new System.Drawing.Point(276, 464);
            this.btnsubmit.Name = "btnsubmit";
            this.btnsubmit.Size = new System.Drawing.Size(94, 29);
            this.btnsubmit.TabIndex = 44;
            this.btnsubmit.Text = "OK";
            this.btnsubmit.Click += new System.EventHandler(this.btnsubmit_Click);
            // 
            // viewGT
            // 
            this.viewGT.Location = new System.Drawing.Point(122, 259);
            this.viewGT.Name = "viewGT";
            this.viewGT.Size = new System.Drawing.Size(399, 23);
            this.viewGT.TabIndex = 43;
            this.viewGT.TextChanged += new System.EventHandler(this.viewGT_TextChanged);
            // 
            // viewPhN
            // 
            this.viewPhN.Location = new System.Drawing.Point(117, 324);
            this.viewPhN.Name = "viewPhN";
            this.viewPhN.Size = new System.Drawing.Size(404, 23);
            this.viewPhN.TabIndex = 42;
            this.viewPhN.TextChanged += new System.EventHandler(this.viewPhN_TextChanged);
            // 
            // viPhN
            // 
            this.viPhN.AutoSize = true;
            this.viPhN.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.viPhN.Location = new System.Drawing.Point(117, 294);
            this.viPhN.Name = "viPhN";
            this.viPhN.Size = new System.Drawing.Size(208, 27);
            this.viPhN.TabIndex = 41;
            this.viPhN.Text = "Số điện thoại:";
            // 
            // viewNS
            // 
            this.viewNS.EditValue = null;
            this.viewNS.Location = new System.Drawing.Point(122, 191);
            this.viewNS.Name = "viewNS";
            this.viewNS.Properties.BeepOnError = true;
            this.viewNS.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.viewNS.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.viewNS.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.Fluent;
            this.viewNS.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.DateOnlyMaskManager));
            this.viewNS.Properties.MaskSettings.Set("MaskManagerSignature", "allowNull=False");
            this.viewNS.Properties.MaskSettings.Set("mask", "d");
            this.viewNS.Properties.MaskSettings.Set("culture", "vi-VN");
            this.viewNS.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.False;
            this.viewNS.Size = new System.Drawing.Size(405, 22);
            this.viewNS.TabIndex = 40;
            this.viewNS.EditValueChanged += new System.EventHandler(this.viewNS_EditValueChanged);
            // 
            // viewEm
            // 
            this.viewEm.Location = new System.Drawing.Point(116, 407);
            this.viewEm.Name = "viewEm";
            this.viewEm.Size = new System.Drawing.Size(405, 23);
            this.viewEm.TabIndex = 39;
            this.viewEm.TextChanged += new System.EventHandler(this.viewEm_TextChanged);
            // 
            // lbEm
            // 
            this.lbEm.AutoSize = true;
            this.lbEm.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbEm.Location = new System.Drawing.Point(117, 364);
            this.lbEm.Name = "lbEm";
            this.lbEm.Size = new System.Drawing.Size(208, 27);
            this.lbEm.TabIndex = 38;
            this.lbEm.Text = "Email liên hệ:";
            // 
            // lbNSinh
            // 
            this.lbNSinh.AutoSize = true;
            this.lbNSinh.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbNSinh.Location = new System.Drawing.Point(117, 158);
            this.lbNSinh.Name = "lbNSinh";
            this.lbNSinh.Size = new System.Drawing.Size(152, 27);
            this.lbNSinh.TabIndex = 37;
            this.lbNSinh.Text = "Ngày sinh:";
            // 
            // lbGT
            // 
            this.lbGT.AutoSize = true;
            this.lbGT.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbGT.Location = new System.Drawing.Point(117, 229);
            this.lbGT.Name = "lbGT";
            this.lbGT.Size = new System.Drawing.Size(152, 27);
            this.lbGT.TabIndex = 36;
            this.lbGT.Text = "Giới tính:";
            // 
            // frmHoSoCuaToi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 566);
            this.Controls.Add(this.btnsubmit);
            this.Controls.Add(this.viewGT);
            this.Controls.Add(this.viewPhN);
            this.Controls.Add(this.viPhN);
            this.Controls.Add(this.viewNS);
            this.Controls.Add(this.viewEm);
            this.Controls.Add(this.lbEm);
            this.Controls.Add(this.lbNSinh);
            this.Controls.Add(this.lbGT);
            this.Controls.Add(this.viewName);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.labelMainTitle);
            this.Name = "frmHoSoCuaToi";
            this.Text = "Hồ sơ của tôi";
            ((System.ComponentModel.ISupportInitialize)(this.viewNS.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewNS.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelMainTitle;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.TextBox viewName;
        private DevExpress.XtraEditors.SimpleButton btnsubmit;
        private System.Windows.Forms.TextBox viewGT;
        private System.Windows.Forms.TextBox viewPhN;
        private System.Windows.Forms.Label viPhN;
        private DevExpress.XtraEditors.DateEdit viewNS;
        private System.Windows.Forms.TextBox viewEm;
        private System.Windows.Forms.Label lbEm;
        private System.Windows.Forms.Label lbNSinh;
        private System.Windows.Forms.Label lbGT;
    }
}