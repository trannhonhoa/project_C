namespace Buoi4
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
            this.btnNhap = new System.Windows.Forms.Button();
            this.txtNhap = new System.Windows.Forms.TextBox();
            this.btnInMang = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnGiam = new System.Windows.Forms.Button();
            this.txtKetQua = new System.Windows.Forms.Label();
            this.btnTang = new System.Windows.Forms.Button();
            this.btnTongMang = new System.Windows.Forms.Button();
            this.btnSoLonNhat = new System.Windows.Forms.Button();
            this.btnSoHoanHao = new System.Windows.Forms.Button();
            this.btnSoNguyenTo = new System.Windows.Forms.Button();
            this.btnDemSoLe = new System.Windows.Forms.Button();
            this.btnDemSoChan = new System.Windows.Forms.Button();
            this.btnSoNhoNhat = new System.Windows.Forms.Button();
            this.btnTrungBinhMang = new System.Windows.Forms.Button();
            this.btnUCLN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNhap
            // 
            this.btnNhap.Location = new System.Drawing.Point(36, 26);
            this.btnNhap.Name = "btnNhap";
            this.btnNhap.Size = new System.Drawing.Size(116, 33);
            this.btnNhap.TabIndex = 0;
            this.btnNhap.Text = "Nhập 1 phần tử";
            this.btnNhap.UseVisualStyleBackColor = true;
            this.btnNhap.Click += new System.EventHandler(this.btnNhap_Click);
            // 
            // txtNhap
            // 
            this.txtNhap.Location = new System.Drawing.Point(158, 30);
            this.txtNhap.Name = "txtNhap";
            this.txtNhap.Size = new System.Drawing.Size(101, 26);
            this.txtNhap.TabIndex = 1;
            // 
            // btnInMang
            // 
            this.btnInMang.Location = new System.Drawing.Point(265, 26);
            this.btnInMang.Name = "btnInMang";
            this.btnInMang.Size = new System.Drawing.Size(106, 33);
            this.btnInMang.TabIndex = 2;
            this.btnInMang.Text = "In Mảng";
            this.btnInMang.UseVisualStyleBackColor = true;
            this.btnInMang.Click += new System.EventHandler(this.btnInMang_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(484, 26);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(106, 33);
            this.btnThoat.TabIndex = 3;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(372, 26);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(106, 33);
            this.btnXoa.TabIndex = 4;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnGiam
            // 
            this.btnGiam.Location = new System.Drawing.Point(484, 65);
            this.btnGiam.Name = "btnGiam";
            this.btnGiam.Size = new System.Drawing.Size(106, 33);
            this.btnGiam.TabIndex = 5;
            this.btnGiam.Text = "Sắp xếp giảm";
            this.btnGiam.UseVisualStyleBackColor = true;
            this.btnGiam.Click += new System.EventHandler(this.btnGiam_Click);
            // 
            // txtKetQua
            // 
            this.txtKetQua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.txtKetQua.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtKetQua.Location = new System.Drawing.Point(36, 62);
            this.txtKetQua.Name = "txtKetQua";
            this.txtKetQua.Size = new System.Drawing.Size(442, 75);
            this.txtKetQua.TabIndex = 6;
            // 
            // btnTang
            // 
            this.btnTang.Location = new System.Drawing.Point(484, 104);
            this.btnTang.Name = "btnTang";
            this.btnTang.Size = new System.Drawing.Size(106, 33);
            this.btnTang.TabIndex = 7;
            this.btnTang.Text = "Sắp xếp tăng";
            this.btnTang.UseVisualStyleBackColor = true;
            this.btnTang.Click += new System.EventHandler(this.btnTang_Click);
            // 
            // btnTongMang
            // 
            this.btnTongMang.Location = new System.Drawing.Point(484, 143);
            this.btnTongMang.Name = "btnTongMang";
            this.btnTongMang.Size = new System.Drawing.Size(106, 33);
            this.btnTongMang.TabIndex = 8;
            this.btnTongMang.Text = "Tổng mảng";
            this.btnTongMang.UseVisualStyleBackColor = true;
            this.btnTongMang.Click += new System.EventHandler(this.btnTongMang_Click);
            // 
            // btnSoLonNhat
            // 
            this.btnSoLonNhat.Location = new System.Drawing.Point(484, 182);
            this.btnSoLonNhat.Name = "btnSoLonNhat";
            this.btnSoLonNhat.Size = new System.Drawing.Size(106, 33);
            this.btnSoLonNhat.TabIndex = 9;
            this.btnSoLonNhat.Text = "Số lớn nhất";
            this.btnSoLonNhat.UseVisualStyleBackColor = true;
            this.btnSoLonNhat.Click += new System.EventHandler(this.btnSoLonNhat_Click);
            // 
            // btnSoHoanHao
            // 
            this.btnSoHoanHao.Location = new System.Drawing.Point(372, 143);
            this.btnSoHoanHao.Name = "btnSoHoanHao";
            this.btnSoHoanHao.Size = new System.Drawing.Size(106, 33);
            this.btnSoHoanHao.TabIndex = 10;
            this.btnSoHoanHao.Text = "Số hoàn hảo";
            this.btnSoHoanHao.UseVisualStyleBackColor = true;
            this.btnSoHoanHao.Click += new System.EventHandler(this.btnSoHoanHao_Click);
            // 
            // btnSoNguyenTo
            // 
            this.btnSoNguyenTo.Location = new System.Drawing.Point(260, 143);
            this.btnSoNguyenTo.Name = "btnSoNguyenTo";
            this.btnSoNguyenTo.Size = new System.Drawing.Size(106, 33);
            this.btnSoNguyenTo.TabIndex = 11;
            this.btnSoNguyenTo.Text = "Số nguyên tố";
            this.btnSoNguyenTo.UseVisualStyleBackColor = true;
            this.btnSoNguyenTo.Click += new System.EventHandler(this.btnSoNguyenTo_Click);
            // 
            // btnDemSoLe
            // 
            this.btnDemSoLe.Location = new System.Drawing.Point(148, 143);
            this.btnDemSoLe.Name = "btnDemSoLe";
            this.btnDemSoLe.Size = new System.Drawing.Size(106, 33);
            this.btnDemSoLe.TabIndex = 12;
            this.btnDemSoLe.Text = "Đếm số lẻ";
            this.btnDemSoLe.UseVisualStyleBackColor = true;
            this.btnDemSoLe.Click += new System.EventHandler(this.btnDemSoLe_Click);
            // 
            // btnDemSoChan
            // 
            this.btnDemSoChan.Location = new System.Drawing.Point(36, 143);
            this.btnDemSoChan.Name = "btnDemSoChan";
            this.btnDemSoChan.Size = new System.Drawing.Size(106, 33);
            this.btnDemSoChan.TabIndex = 13;
            this.btnDemSoChan.Text = "Đếm số chẵn";
            this.btnDemSoChan.UseVisualStyleBackColor = true;
            this.btnDemSoChan.Click += new System.EventHandler(this.btnDemSoChan_Click);
            // 
            // btnSoNhoNhat
            // 
            this.btnSoNhoNhat.Location = new System.Drawing.Point(372, 182);
            this.btnSoNhoNhat.Name = "btnSoNhoNhat";
            this.btnSoNhoNhat.Size = new System.Drawing.Size(106, 33);
            this.btnSoNhoNhat.TabIndex = 15;
            this.btnSoNhoNhat.Text = "Số nhỏ nhất";
            this.btnSoNhoNhat.UseVisualStyleBackColor = true;
            this.btnSoNhoNhat.Click += new System.EventHandler(this.btnSoNhoNhat_Click);
            // 
            // btnTrungBinhMang
            // 
            this.btnTrungBinhMang.Location = new System.Drawing.Point(245, 182);
            this.btnTrungBinhMang.Name = "btnTrungBinhMang";
            this.btnTrungBinhMang.Size = new System.Drawing.Size(121, 33);
            this.btnTrungBinhMang.TabIndex = 16;
            this.btnTrungBinhMang.Text = "Trung bình mảng";
            this.btnTrungBinhMang.UseVisualStyleBackColor = true;
            this.btnTrungBinhMang.Click += new System.EventHandler(this.btnTrungBinhMang_Click);
            // 
            // btnUCLN
            // 
            this.btnUCLN.Location = new System.Drawing.Point(36, 182);
            this.btnUCLN.Name = "btnUCLN";
            this.btnUCLN.Size = new System.Drawing.Size(203, 33);
            this.btnUCLN.TabIndex = 17;
            this.btnUCLN.Text = "UCLN 2 phần tử đầu tiên";
            this.btnUCLN.UseVisualStyleBackColor = true;
            this.btnUCLN.Click += new System.EventHandler(this.btnUCLN_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnNhap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 233);
            this.Controls.Add(this.btnUCLN);
            this.Controls.Add(this.btnTrungBinhMang);
            this.Controls.Add(this.btnSoNhoNhat);
            this.Controls.Add(this.btnDemSoChan);
            this.Controls.Add(this.btnDemSoLe);
            this.Controls.Add(this.btnSoNguyenTo);
            this.Controls.Add(this.btnSoHoanHao);
            this.Controls.Add(this.btnSoLonNhat);
            this.Controls.Add(this.btnTongMang);
            this.Controls.Add(this.btnTang);
            this.Controls.Add(this.txtKetQua);
            this.Controls.Add(this.btnGiam);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnInMang);
            this.Controls.Add(this.txtNhap);
            this.Controls.Add(this.btnNhap);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNhap;
        private System.Windows.Forms.TextBox txtNhap;
        private System.Windows.Forms.Button btnInMang;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnGiam;
        private System.Windows.Forms.Label txtKetQua;
        private System.Windows.Forms.Button btnTang;
        private System.Windows.Forms.Button btnTongMang;
        private System.Windows.Forms.Button btnSoLonNhat;
        private System.Windows.Forms.Button btnSoHoanHao;
        private System.Windows.Forms.Button btnSoNguyenTo;
        private System.Windows.Forms.Button btnDemSoLe;
        private System.Windows.Forms.Button btnDemSoChan;
        private System.Windows.Forms.Button btnSoNhoNhat;
        private System.Windows.Forms.Button btnTrungBinhMang;
        private System.Windows.Forms.Button btnUCLN;
    }
}

