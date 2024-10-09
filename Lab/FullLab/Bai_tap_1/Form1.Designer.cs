namespace Tong1denN
{
    partial class Form1
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
            this.lb_nhapN = new System.Windows.Forms.Label();
            this.txtN = new System.Windows.Forms.TextBox();
            this.lb_ketQua = new System.Windows.Forms.Label();
            this.txtTinh = new System.Windows.Forms.TextBox();
            this.btn_tinh = new System.Windows.Forms.Button();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_nhapN
            // 
            this.lb_nhapN.AutoSize = true;
            this.lb_nhapN.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_nhapN.Location = new System.Drawing.Point(12, 24);
            this.lb_nhapN.Name = "lb_nhapN";
            this.lb_nhapN.Size = new System.Drawing.Size(101, 29);
            this.lb_nhapN.TabIndex = 0;
            this.lb_nhapN.Text = "Nhập N:";
            this.lb_nhapN.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtN
            // 
            this.txtN.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtN.Location = new System.Drawing.Point(119, 21);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(349, 34);
            this.txtN.TabIndex = 1;
            // 
            // lb_ketQua
            // 
            this.lb_ketQua.AutoSize = true;
            this.lb_ketQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ketQua.Location = new System.Drawing.Point(12, 78);
            this.lb_ketQua.Name = "lb_ketQua";
            this.lb_ketQua.Size = new System.Drawing.Size(101, 29);
            this.lb_ketQua.TabIndex = 2;
            this.lb_ketQua.Text = "Kết quả:";
            this.lb_ketQua.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtTinh
            // 
            this.txtTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTinh.Location = new System.Drawing.Point(119, 78);
            this.txtTinh.Name = "txtTinh";
            this.txtTinh.Size = new System.Drawing.Size(349, 34);
            this.txtTinh.TabIndex = 3;
            // 
            // btn_tinh
            // 
            this.btn_tinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_tinh.Location = new System.Drawing.Point(136, 140);
            this.btn_tinh.Name = "btn_tinh";
            this.btn_tinh.Size = new System.Drawing.Size(93, 46);
            this.btn_tinh.TabIndex = 4;
            this.btn_tinh.Text = "Tính";
            this.btn_tinh.UseVisualStyleBackColor = true;
            this.btn_tinh.Click += new System.EventHandler(this.btn_tinh_Click);
            // 
            // btn_thoat
            // 
            this.btn_thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thoat.Location = new System.Drawing.Point(253, 140);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(93, 46);
            this.btn_thoat.TabIndex = 5;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = true;
            this.btn_thoat.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 221);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.btn_tinh);
            this.Controls.Add(this.txtTinh);
            this.Controls.Add(this.lb_ketQua);
            this.Controls.Add(this.txtN);
            this.Controls.Add(this.lb_nhapN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "BT1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_nhapN;
        private System.Windows.Forms.TextBox txtN;
        private System.Windows.Forms.Label lb_ketQua;
        private System.Windows.Forms.TextBox txtTinh;
        private System.Windows.Forms.Button btn_tinh;
        private System.Windows.Forms.Button btn_thoat;
    }
}

