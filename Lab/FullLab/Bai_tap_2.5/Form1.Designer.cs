namespace TinhLuyThua
{
    partial class frmTongLuyThua
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
            this.labSoN = new System.Windows.Forms.Label();
            this.labSoX = new System.Windows.Forms.Label();
            this.txtSoN = new System.Windows.Forms.TextBox();
            this.txtSoX = new System.Windows.Forms.TextBox();
            this.btnTinh = new System.Windows.Forms.Button();
            this.grKetQua = new System.Windows.Forms.GroupBox();
            this.labKetQua1 = new System.Windows.Forms.Label();
            this.labKetQua2 = new System.Windows.Forms.Label();
            this.labKetQua3 = new System.Windows.Forms.Label();
            this.labKetQua4 = new System.Windows.Forms.Label();
            this.txtKetQua1 = new System.Windows.Forms.TextBox();
            this.txtKetQua2 = new System.Windows.Forms.TextBox();
            this.txtKetQua3 = new System.Windows.Forms.TextBox();
            this.txtKetQua4 = new System.Windows.Forms.TextBox();
            this.grKetQua.SuspendLayout();
            this.SuspendLayout();
            // 
            // labSoN
            // 
            this.labSoN.AutoSize = true;
            this.labSoN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labSoN.Location = new System.Drawing.Point(24, 24);
            this.labSoN.Name = "labSoN";
            this.labSoN.Size = new System.Drawing.Size(282, 25);
            this.labSoN.TabIndex = 0;
            this.labSoN.Text = "Nhập vào số nguyên dương N: ";
            // 
            // labSoX
            // 
            this.labSoX.AutoSize = true;
            this.labSoX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labSoX.Location = new System.Drawing.Point(24, 74);
            this.labSoX.Name = "labSoX";
            this.labSoX.Size = new System.Drawing.Size(194, 25);
            this.labSoX.TabIndex = 1;
            this.labSoX.Text = "Nhập vào số thực X: ";
            // 
            // txtSoN
            // 
            this.txtSoN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoN.Location = new System.Drawing.Point(351, 21);
            this.txtSoN.Name = "txtSoN";
            this.txtSoN.Size = new System.Drawing.Size(328, 30);
            this.txtSoN.TabIndex = 2;
            // 
            // txtSoX
            // 
            this.txtSoX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoX.Location = new System.Drawing.Point(351, 71);
            this.txtSoX.Name = "txtSoX";
            this.txtSoX.Size = new System.Drawing.Size(328, 30);
            this.txtSoX.TabIndex = 3;
            // 
            // btnTinh
            // 
            this.btnTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTinh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnTinh.Location = new System.Drawing.Point(726, 21);
            this.btnTinh.Name = "btnTinh";
            this.btnTinh.Size = new System.Drawing.Size(157, 80);
            this.btnTinh.TabIndex = 4;
            this.btnTinh.Text = "Tính tổng";
            this.btnTinh.UseVisualStyleBackColor = true;
            this.btnTinh.Click += new System.EventHandler(this.btnTinh_Click);
            // 
            // grKetQua
            // 
            this.grKetQua.Controls.Add(this.txtKetQua4);
            this.grKetQua.Controls.Add(this.txtKetQua3);
            this.grKetQua.Controls.Add(this.txtKetQua2);
            this.grKetQua.Controls.Add(this.txtKetQua1);
            this.grKetQua.Controls.Add(this.labKetQua4);
            this.grKetQua.Controls.Add(this.labKetQua3);
            this.grKetQua.Controls.Add(this.labKetQua2);
            this.grKetQua.Controls.Add(this.labKetQua1);
            this.grKetQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grKetQua.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.grKetQua.Location = new System.Drawing.Point(29, 128);
            this.grKetQua.Name = "grKetQua";
            this.grKetQua.Size = new System.Drawing.Size(854, 267);
            this.grKetQua.TabIndex = 5;
            this.grKetQua.TabStop = false;
            this.grKetQua.Text = "Kết quả";
            // 
            // labKetQua1
            // 
            this.labKetQua1.AutoSize = true;
            this.labKetQua1.ForeColor = System.Drawing.Color.Black;
            this.labKetQua1.Location = new System.Drawing.Point(34, 47);
            this.labKetQua1.Name = "labKetQua1";
            this.labKetQua1.Size = new System.Drawing.Size(48, 25);
            this.labKetQua1.TabIndex = 0;
            this.labKetQua1.Text = "S = ";
            // 
            // labKetQua2
            // 
            this.labKetQua2.AutoSize = true;
            this.labKetQua2.ForeColor = System.Drawing.Color.Black;
            this.labKetQua2.Location = new System.Drawing.Point(34, 102);
            this.labKetQua2.Name = "labKetQua2";
            this.labKetQua2.Size = new System.Drawing.Size(48, 25);
            this.labKetQua2.TabIndex = 1;
            this.labKetQua2.Text = "S = ";
            // 
            // labKetQua3
            // 
            this.labKetQua3.AutoSize = true;
            this.labKetQua3.ForeColor = System.Drawing.Color.Black;
            this.labKetQua3.Location = new System.Drawing.Point(34, 162);
            this.labKetQua3.Name = "labKetQua3";
            this.labKetQua3.Size = new System.Drawing.Size(48, 25);
            this.labKetQua3.TabIndex = 2;
            this.labKetQua3.Text = "S = ";
            // 
            // labKetQua4
            // 
            this.labKetQua4.AutoSize = true;
            this.labKetQua4.ForeColor = System.Drawing.Color.Black;
            this.labKetQua4.Location = new System.Drawing.Point(34, 221);
            this.labKetQua4.Name = "labKetQua4";
            this.labKetQua4.Size = new System.Drawing.Size(48, 25);
            this.labKetQua4.TabIndex = 3;
            this.labKetQua4.Text = "S = ";
            // 
            // txtKetQua1
            // 
            this.txtKetQua1.ForeColor = System.Drawing.Color.Blue;
            this.txtKetQua1.Location = new System.Drawing.Point(99, 44);
            this.txtKetQua1.Name = "txtKetQua1";
            this.txtKetQua1.Size = new System.Drawing.Size(715, 30);
            this.txtKetQua1.TabIndex = 4;
            // 
            // txtKetQua2
            // 
            this.txtKetQua2.ForeColor = System.Drawing.Color.Red;
            this.txtKetQua2.Location = new System.Drawing.Point(99, 99);
            this.txtKetQua2.Name = "txtKetQua2";
            this.txtKetQua2.Size = new System.Drawing.Size(715, 30);
            this.txtKetQua2.TabIndex = 5;
            // 
            // txtKetQua3
            // 
            this.txtKetQua3.ForeColor = System.Drawing.Color.Blue;
            this.txtKetQua3.Location = new System.Drawing.Point(99, 159);
            this.txtKetQua3.Name = "txtKetQua3";
            this.txtKetQua3.Size = new System.Drawing.Size(715, 30);
            this.txtKetQua3.TabIndex = 6;
            // 
            // txtKetQua4
            // 
            this.txtKetQua4.ForeColor = System.Drawing.Color.Red;
            this.txtKetQua4.Location = new System.Drawing.Point(99, 218);
            this.txtKetQua4.Name = "txtKetQua4";
            this.txtKetQua4.Size = new System.Drawing.Size(715, 30);
            this.txtKetQua4.TabIndex = 7;
            // 
            // frmTongLuyThua
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 401);
            this.Controls.Add(this.grKetQua);
            this.Controls.Add(this.btnTinh);
            this.Controls.Add(this.txtSoX);
            this.Controls.Add(this.txtSoN);
            this.Controls.Add(this.labSoX);
            this.Controls.Add(this.labSoN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "frmTongLuyThua";
            this.Text = "Tinh tong luy thua";
            this.grKetQua.ResumeLayout(false);
            this.grKetQua.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labSoN;
        private System.Windows.Forms.Label labSoX;
        private System.Windows.Forms.TextBox txtSoN;
        private System.Windows.Forms.TextBox txtSoX;
        private System.Windows.Forms.Button btnTinh;
        private System.Windows.Forms.GroupBox grKetQua;
        private System.Windows.Forms.TextBox txtKetQua1;
        private System.Windows.Forms.Label labKetQua4;
        private System.Windows.Forms.Label labKetQua3;
        private System.Windows.Forms.Label labKetQua2;
        private System.Windows.Forms.Label labKetQua1;
        private System.Windows.Forms.TextBox txtKetQua4;
        private System.Windows.Forms.TextBox txtKetQua3;
        private System.Windows.Forms.TextBox txtKetQua2;
    }
}

