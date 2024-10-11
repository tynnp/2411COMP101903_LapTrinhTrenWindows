namespace TinhTong
{
    partial class frmTinhTong
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
            this.labNhapSo = new System.Windows.Forms.Label();
            this.txtN = new System.Windows.Forms.TextBox();
            this.btnTinh = new System.Windows.Forms.Button();
            this.grKetQua = new System.Windows.Forms.GroupBox();
            this.labS_1 = new System.Windows.Forms.Label();
            this.labS_2 = new System.Windows.Forms.Label();
            this.txtS_1 = new System.Windows.Forms.TextBox();
            this.txtS_2 = new System.Windows.Forms.TextBox();
            this.grKetQua.SuspendLayout();
            this.SuspendLayout();
            // 
            // labNhapSo
            // 
            this.labNhapSo.AutoSize = true;
            this.labNhapSo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labNhapSo.Location = new System.Drawing.Point(28, 28);
            this.labNhapSo.Name = "labNhapSo";
            this.labNhapSo.Size = new System.Drawing.Size(282, 25);
            this.labNhapSo.TabIndex = 0;
            this.labNhapSo.Text = "Nhập vào số nguyên dương N: ";
            // 
            // txtN
            // 
            this.txtN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtN.Location = new System.Drawing.Point(332, 25);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(151, 30);
            this.txtN.TabIndex = 1;
            // 
            // btnTinh
            // 
            this.btnTinh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTinh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnTinh.Location = new System.Drawing.Point(514, 16);
            this.btnTinh.Name = "btnTinh";
            this.btnTinh.Size = new System.Drawing.Size(132, 48);
            this.btnTinh.TabIndex = 2;
            this.btnTinh.Text = "Tính tổng";
            this.btnTinh.UseVisualStyleBackColor = true;
            this.btnTinh.Click += new System.EventHandler(this.btnTinh_Click);
            // 
            // grKetQua
            // 
            this.grKetQua.Controls.Add(this.txtS_2);
            this.grKetQua.Controls.Add(this.txtS_1);
            this.grKetQua.Controls.Add(this.labS_2);
            this.grKetQua.Controls.Add(this.labS_1);
            this.grKetQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grKetQua.ForeColor = System.Drawing.SystemColors.Highlight;
            this.grKetQua.Location = new System.Drawing.Point(33, 81);
            this.grKetQua.Name = "grKetQua";
            this.grKetQua.Size = new System.Drawing.Size(613, 136);
            this.grKetQua.TabIndex = 3;
            this.grKetQua.TabStop = false;
            this.grKetQua.Text = "Kết quả";
            // 
            // labS_1
            // 
            this.labS_1.AutoSize = true;
            this.labS_1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labS_1.Location = new System.Drawing.Point(28, 39);
            this.labS_1.Name = "labS_1";
            this.labS_1.Size = new System.Drawing.Size(43, 25);
            this.labS_1.TabIndex = 0;
            this.labS_1.Text = "S =";
            // 
            // labS_2
            // 
            this.labS_2.AutoSize = true;
            this.labS_2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.labS_2.Location = new System.Drawing.Point(28, 90);
            this.labS_2.Name = "labS_2";
            this.labS_2.Size = new System.Drawing.Size(48, 25);
            this.labS_2.TabIndex = 0;
            this.labS_2.Text = "S = ";
            // 
            // txtS_1
            // 
            this.txtS_1.ForeColor = System.Drawing.Color.Blue;
            this.txtS_1.Location = new System.Drawing.Point(77, 36);
            this.txtS_1.Name = "txtS_1";
            this.txtS_1.Size = new System.Drawing.Size(497, 30);
            this.txtS_1.TabIndex = 1;
            // 
            // txtS_2
            // 
            this.txtS_2.ForeColor = System.Drawing.Color.Red;
            this.txtS_2.Location = new System.Drawing.Point(77, 87);
            this.txtS_2.Name = "txtS_2";
            this.txtS_2.Size = new System.Drawing.Size(497, 30);
            this.txtS_2.TabIndex = 2;
            // 
            // frmTinhTong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(684, 229);
            this.Controls.Add(this.grKetQua);
            this.Controls.Add(this.btnTinh);
            this.Controls.Add(this.txtN);
            this.Controls.Add(this.labNhapSo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "frmTinhTong";
            this.Text = "TinhTong";
            this.grKetQua.ResumeLayout(false);
            this.grKetQua.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labNhapSo;
        private System.Windows.Forms.TextBox txtN;
        private System.Windows.Forms.Button btnTinh;
        private System.Windows.Forms.GroupBox grKetQua;
        private System.Windows.Forms.TextBox txtS_1;
        private System.Windows.Forms.Label labS_2;
        private System.Windows.Forms.Label labS_1;
        private System.Windows.Forms.TextBox txtS_2;
    }
}

