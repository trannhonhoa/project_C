namespace Buoi5_Bai4
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radHinhChuNhat = new System.Windows.Forms.RadioButton();
            this.radHinhVuong = new System.Windows.Forms.RadioButton();
            this.radHinhTamGiac = new System.Windows.Forms.RadioButton();
            this.radHinhTron = new System.Windows.Forms.RadioButton();
            this.btnThucHien = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtDienTich = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtChuVi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNhap = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(61, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(309, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "TÌM CHU VI  VÀ DIỆN TÍCH";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(113, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(206, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hình Tròn - Hình Vuông ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(76, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(266, 22);
            this.label3.TabIndex = 1;
            this.label3.Text = "Hình Chữ Nhật - Hình Tam Giác";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radHinhChuNhat);
            this.groupBox1.Controls.Add(this.radHinhVuong);
            this.groupBox1.Controls.Add(this.radHinhTamGiac);
            this.groupBox1.Controls.Add(this.radHinhTron);
            this.groupBox1.Location = new System.Drawing.Point(26, 153);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(378, 92);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn";
            // 
            // radHinhChuNhat
            // 
            this.radHinhChuNhat.AutoSize = true;
            this.radHinhChuNhat.Location = new System.Drawing.Point(252, 54);
            this.radHinhChuNhat.Name = "radHinhChuNhat";
            this.radHinhChuNhat.Size = new System.Drawing.Size(111, 23);
            this.radHinhChuNhat.TabIndex = 3;
            this.radHinhChuNhat.TabStop = true;
            this.radHinhChuNhat.Text = "Hình chữ nhật";
            this.radHinhChuNhat.UseVisualStyleBackColor = true;
            // 
            // radHinhVuong
            // 
            this.radHinhVuong.AutoSize = true;
            this.radHinhVuong.Location = new System.Drawing.Point(6, 54);
            this.radHinhVuong.Name = "radHinhVuong";
            this.radHinhVuong.Size = new System.Drawing.Size(95, 23);
            this.radHinhVuong.TabIndex = 2;
            this.radHinhVuong.TabStop = true;
            this.radHinhVuong.Text = "Hinh vuông";
            this.radHinhVuong.UseVisualStyleBackColor = true;
            // 
            // radHinhTamGiac
            // 
            this.radHinhTamGiac.AutoSize = true;
            this.radHinhTamGiac.Location = new System.Drawing.Point(252, 25);
            this.radHinhTamGiac.Name = "radHinhTamGiac";
            this.radHinhTamGiac.Size = new System.Drawing.Size(109, 23);
            this.radHinhTamGiac.TabIndex = 1;
            this.radHinhTamGiac.TabStop = true;
            this.radHinhTamGiac.Text = "Hình tam giác";
            this.radHinhTamGiac.UseVisualStyleBackColor = true;
            // 
            // radHinhTron
            // 
            this.radHinhTron.AutoSize = true;
            this.radHinhTron.Location = new System.Drawing.Point(6, 25);
            this.radHinhTron.Name = "radHinhTron";
            this.radHinhTron.Size = new System.Drawing.Size(83, 23);
            this.radHinhTron.TabIndex = 0;
            this.radHinhTron.TabStop = true;
            this.radHinhTron.Text = "Hình tròn";
            this.radHinhTron.UseVisualStyleBackColor = true;
            // 
            // btnThucHien
            // 
            this.btnThucHien.Location = new System.Drawing.Point(29, 251);
            this.btnThucHien.Name = "btnThucHien";
            this.btnThucHien.Size = new System.Drawing.Size(89, 33);
            this.btnThucHien.TabIndex = 3;
            this.btnThucHien.Text = "Thực hiện";
            this.btnThucHien.UseVisualStyleBackColor = true;
            this.btnThucHien.Click += new System.EventHandler(this.btnThucHien_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(318, 251);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(89, 33);
            this.btnThoat.TabIndex = 3;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(171, 251);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(89, 33);
            this.button3.TabIndex = 3;
            this.button3.Text = "Reset";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtDienTich);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtChuVi);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtNhap);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(26, 290);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(378, 149);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chọn";
            // 
            // txtDienTich
            // 
            this.txtDienTich.Location = new System.Drawing.Point(120, 117);
            this.txtDienTich.Name = "txtDienTich";
            this.txtDienTich.Size = new System.Drawing.Size(114, 26);
            this.txtDienTich.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 19);
            this.label6.TabIndex = 4;
            this.label6.Text = "Diện tích";
            // 
            // txtChuVi
            // 
            this.txtChuVi.Location = new System.Drawing.Point(120, 82);
            this.txtChuVi.Name = "txtChuVi";
            this.txtChuVi.Size = new System.Drawing.Size(114, 26);
            this.txtChuVi.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 19);
            this.label5.TabIndex = 2;
            this.label5.Text = "Chu vi";
            // 
            // txtNhap
            // 
            this.txtNhap.Location = new System.Drawing.Point(120, 39);
            this.txtNhap.Name = "txtNhap";
            this.txtNhap.Size = new System.Drawing.Size(114, 26);
            this.txtNhap.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "Nhập cạnh A";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 439);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnThucHien);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radHinhChuNhat;
        private System.Windows.Forms.RadioButton radHinhVuong;
        private System.Windows.Forms.RadioButton radHinhTamGiac;
        private System.Windows.Forms.RadioButton radHinhTron;
        private System.Windows.Forms.Button btnThucHien;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtDienTich;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtChuVi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNhap;
        private System.Windows.Forms.Label label4;
    }
}

