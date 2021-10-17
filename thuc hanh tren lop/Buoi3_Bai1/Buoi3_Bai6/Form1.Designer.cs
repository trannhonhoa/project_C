namespace Buoi3_Bai6
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNhapChuoi = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.txtHienThi = new System.Windows.Forms.TextBox();
            this.btnMauChu = new System.Windows.Forms.Button();
            this.btnMauNen = new System.Windows.Forms.Button();
            this.btnFont = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.lstTen = new System.Windows.Forms.ListBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNhapChuoi);
            this.groupBox1.Location = new System.Drawing.Point(12, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(233, 70);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập chuỗi";
            // 
            // txtNhapChuoi
            // 
            this.txtNhapChuoi.AcceptsTab = true;
            this.txtNhapChuoi.Location = new System.Drawing.Point(16, 25);
            this.txtNhapChuoi.Name = "txtNhapChuoi";
            this.txtNhapChuoi.Size = new System.Drawing.Size(196, 26);
            this.txtNhapChuoi.TabIndex = 0;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(16, 104);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(90, 33);
            this.btnThem.TabIndex = 1;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(155, 104);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(90, 33);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // txtHienThi
            // 
            this.txtHienThi.Location = new System.Drawing.Point(262, 28);
            this.txtHienThi.Multiline = true;
            this.txtHienThi.Name = "txtHienThi";
            this.txtHienThi.Size = new System.Drawing.Size(430, 109);
            this.txtHienThi.TabIndex = 3;
            // 
            // btnMauChu
            // 
            this.btnMauChu.Location = new System.Drawing.Point(266, 164);
            this.btnMauChu.Name = "btnMauChu";
            this.btnMauChu.Size = new System.Drawing.Size(136, 37);
            this.btnMauChu.TabIndex = 4;
            this.btnMauChu.Text = "Chọn màu chữ";
            this.btnMauChu.UseVisualStyleBackColor = true;
            this.btnMauChu.Click += new System.EventHandler(this.btnMauChu_Click);
            // 
            // btnMauNen
            // 
            this.btnMauNen.Location = new System.Drawing.Point(408, 164);
            this.btnMauNen.Name = "btnMauNen";
            this.btnMauNen.Size = new System.Drawing.Size(136, 37);
            this.btnMauNen.TabIndex = 5;
            this.btnMauNen.Text = "Chọn màu nền";
            this.btnMauNen.UseVisualStyleBackColor = true;
            this.btnMauNen.Click += new System.EventHandler(this.btnMauNen_Click);
            // 
            // btnFont
            // 
            this.btnFont.Location = new System.Drawing.Point(550, 164);
            this.btnFont.Name = "btnFont";
            this.btnFont.Size = new System.Drawing.Size(136, 37);
            this.btnFont.TabIndex = 6;
            this.btnFont.Text = "Chọn Font";
            this.btnFont.UseVisualStyleBackColor = true;
            this.btnFont.Click += new System.EventHandler(this.btnFont_Click);
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(408, 216);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(136, 37);
            this.btnDong.TabIndex = 7;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            // 
            // lstTen
            // 
            this.lstTen.FormattingEnabled = true;
            this.lstTen.ItemHeight = 19;
            this.lstTen.Location = new System.Drawing.Point(18, 150);
            this.lstTen.Name = "lstTen";
            this.lstTen.Size = new System.Drawing.Size(227, 118);
            this.lstTen.TabIndex = 8;
            this.lstTen.SelectedIndexChanged += new System.EventHandler(this.lstTen_SelectedIndexChanged);
            // 
            // colorDialog1
            // 
            this.colorDialog1.AnyColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 276);
            this.Controls.Add(this.lstTen);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnFont);
            this.Controls.Add(this.btnMauNen);
            this.Controls.Add(this.btnMauChu);
            this.Controls.Add(this.txtHienThi);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtNhapChuoi;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.TextBox txtHienThi;
        private System.Windows.Forms.Button btnMauChu;
        private System.Windows.Forms.Button btnMauNen;
        private System.Windows.Forms.Button btnFont;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.ListBox lstTen;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
    }
}

