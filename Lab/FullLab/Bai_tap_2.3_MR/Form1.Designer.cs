namespace DocSo
{
    partial class frmDocSo
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
            this.txtNhapSo = new System.Windows.Forms.TextBox();
            this.grKetQua = new System.Windows.Forms.GroupBox();
            this.txtKetQua = new System.Windows.Forms.TextBox();
            this.grKetQua.SuspendLayout();
            this.SuspendLayout();
            // 
            // labNhapSo
            // 
            this.labNhapSo.AutoSize = true;
            this.labNhapSo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labNhapSo.Location = new System.Drawing.Point(39, 29);
            this.labNhapSo.Name = "labNhapSo";
            this.labNhapSo.Size = new System.Drawing.Size(258, 25);
            this.labNhapSo.TabIndex = 0;
            this.labNhapSo.Text = "Nhập vào một số nguyên:";
            // 
            // txtNhapSo
            // 
            this.txtNhapSo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNhapSo.Location = new System.Drawing.Point(333, 23);
            this.txtNhapSo.Name = "txtNhapSo";
            this.txtNhapSo.Size = new System.Drawing.Size(316, 34);
            this.txtNhapSo.TabIndex = 1;
            this.txtNhapSo.TextChanged += new System.EventHandler(this.txtNhapSo_TextChanged);
            this.txtNhapSo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNhapSo_KeyDown);
            // 
            // grKetQua
            // 
            this.grKetQua.Controls.Add(this.txtKetQua);
            this.grKetQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grKetQua.ForeColor = System.Drawing.Color.Blue;
            this.grKetQua.Location = new System.Drawing.Point(44, 84);
            this.grKetQua.Name = "grKetQua";
            this.grKetQua.Size = new System.Drawing.Size(605, 185);
            this.grKetQua.TabIndex = 2;
            this.grKetQua.TabStop = false;
            this.grKetQua.Text = "Kết quả đọc số";
            // 
            // txtKetQua
            // 
            this.txtKetQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKetQua.Location = new System.Drawing.Point(6, 33);
            this.txtKetQua.Multiline = true;
            this.txtKetQua.Name = "txtKetQua";
            this.txtKetQua.Size = new System.Drawing.Size(593, 146);
            this.txtKetQua.TabIndex = 0;
            // 
            // frmDocSo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 289);
            this.Controls.Add(this.grKetQua);
            this.Controls.Add(this.txtNhapSo);
            this.Controls.Add(this.labNhapSo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "frmDocSo";
            this.Text = "Chuong trinh doc so";
            this.grKetQua.ResumeLayout(false);
            this.grKetQua.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labNhapSo;
        private System.Windows.Forms.TextBox txtNhapSo;
        private System.Windows.Forms.GroupBox grKetQua;
        private System.Windows.Forms.TextBox txtKetQua;
    }
}

