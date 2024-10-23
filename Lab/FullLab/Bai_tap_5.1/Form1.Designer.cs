namespace HienThiTen
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            BtnAdd = new Button();
            BtnClear = new Button();
            BtnClose = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            TxtFirstName = new TextBox();
            TxtLastName = new TextBox();
            CboTitle = new ComboBox();
            LstDanhSach = new ListBox();
            SuspendLayout();
            // 
            // BtnAdd
            // 
            BtnAdd.Font = new Font("Segoe UI Emoji", 12F);
            BtnAdd.Location = new Point(12, 12);
            BtnAdd.Name = "BtnAdd";
            BtnAdd.Size = new Size(132, 56);
            BtnAdd.TabIndex = 0;
            BtnAdd.Text = "Add name";
            BtnAdd.UseVisualStyleBackColor = true;
            BtnAdd.UseWaitCursor = true;
            BtnAdd.Click += BtnAdd_Click;
            // 
            // BtnClear
            // 
            BtnClear.Font = new Font("Segoe UI Emoji", 12F);
            BtnClear.Location = new Point(335, 12);
            BtnClear.Name = "BtnClear";
            BtnClear.Size = new Size(132, 56);
            BtnClear.TabIndex = 1;
            BtnClear.Text = "Clear";
            BtnClear.UseVisualStyleBackColor = true;
            BtnClear.Click += BtnClear_Click;
            // 
            // BtnClose
            // 
            BtnClose.Font = new Font("Segoe UI Emoji", 12F);
            BtnClose.Location = new Point(489, 12);
            BtnClose.Name = "BtnClose";
            BtnClose.Size = new Size(132, 56);
            BtnClose.TabIndex = 2;
            BtnClose.Text = "Close";
            BtnClose.UseVisualStyleBackColor = true;
            BtnClose.Click += BtnClose_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(12, 93);
            label1.Name = "label1";
            label1.Size = new Size(49, 28);
            label1.TabIndex = 3;
            label1.Text = "Title";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(242, 93);
            label2.Name = "label2";
            label2.Size = new Size(106, 28);
            label2.TabIndex = 4;
            label2.Text = "First Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(441, 93);
            label3.Name = "label3";
            label3.Size = new Size(103, 28);
            label3.TabIndex = 5;
            label3.Text = "Last Name";
            // 
            // TxtFirstName
            // 
            TxtFirstName.Font = new Font("Segoe UI", 12F);
            TxtFirstName.Location = new Point(242, 129);
            TxtFirstName.Name = "TxtFirstName";
            TxtFirstName.Size = new Size(156, 34);
            TxtFirstName.TabIndex = 6;
            // 
            // TxtLastName
            // 
            TxtLastName.Font = new Font("Segoe UI", 12F);
            TxtLastName.Location = new Point(441, 129);
            TxtLastName.Name = "TxtLastName";
            TxtLastName.Size = new Size(180, 34);
            TxtLastName.TabIndex = 7;
            // 
            // CboTitle
            // 
            CboTitle.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CboTitle.FormattingEnabled = true;
            CboTitle.Items.AddRange(new object[] { "Mr.", "Miss.", "Mrs.", "Dr." });
            CboTitle.Location = new Point(12, 129);
            CboTitle.Name = "CboTitle";
            CboTitle.Size = new Size(151, 36);
            CboTitle.TabIndex = 8;
            // 
            // LstDanhSach
            // 
            LstDanhSach.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LstDanhSach.FormattingEnabled = true;
            LstDanhSach.ItemHeight = 28;
            LstDanhSach.Location = new Point(12, 184);
            LstDanhSach.Name = "LstDanhSach";
            LstDanhSach.Size = new Size(609, 144);
            LstDanhSach.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(633, 341);
            Controls.Add(LstDanhSach);
            Controls.Add(CboTitle);
            Controls.Add(TxtLastName);
            Controls.Add(TxtFirstName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(BtnClose);
            Controls.Add(BtnClear);
            Controls.Add(BtnAdd);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            Text = "Hien thi ten";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnAdd;
        private Button BtnClear;
        private Button BtnClose;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox TxtFirstName;
        private TextBox TxtLastName;
        private ComboBox CboTitle;
        private ListBox LstDanhSach;
    }
}
