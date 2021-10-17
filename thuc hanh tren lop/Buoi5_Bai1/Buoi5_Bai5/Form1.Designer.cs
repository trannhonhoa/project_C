namespace Buoi5_Bai5
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
            this.txtMangGoc = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtKetQua = new System.Windows.Forms.TextBox();
            this.btnXuatMang = new System.Windows.Forms.Button();
            this.btnNhoNhat = new System.Windows.Forms.Button();
            this.btnTongGiaTri = new System.Windows.Forms.Button();
            this.btnTang2 = new System.Windows.Forms.Button();
            this.btnDemLe = new System.Windows.Forms.Button();
            this.btnTangDan = new System.Windows.Forms.Button();
            this.btnTongLe = new System.Windows.Forms.Button();
            this.btnGiamDan = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMangGoc);
            this.groupBox1.Location = new System.Drawing.Point(24, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(426, 54);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mảng gốc";
            // 
            // txtMangGoc
            // 
            this.txtMangGoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMangGoc.Location = new System.Drawing.Point(3, 22);
            this.txtMangGoc.Name = "txtMangGoc";
            this.txtMangGoc.Size = new System.Drawing.Size(420, 26);
            this.txtMangGoc.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtKetQua);
            this.groupBox2.Location = new System.Drawing.Point(24, 72);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(423, 54);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kết quả";
            // 
            // txtKetQua
            // 
            this.txtKetQua.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtKetQua.Location = new System.Drawing.Point(3, 22);
            this.txtKetQua.Name = "txtKetQua";
            this.txtKetQua.Size = new System.Drawing.Size(417, 26);
            this.txtKetQua.TabIndex = 0;
            // 
            // btnXuatMang
            // 
            this.btnXuatMang.Location = new System.Drawing.Point(24, 132);
            this.btnXuatMang.Name = "btnXuatMang";
            this.btnXuatMang.Size = new System.Drawing.Size(214, 31);
            this.btnXuatMang.TabIndex = 2;
            this.btnXuatMang.Text = "Xuất mảng ngẫu nhiên";
            this.btnXuatMang.UseVisualStyleBackColor = true;
            this.btnXuatMang.Click += new System.EventHandler(this.btnXuatMang_Click);
            // 
            // btnNhoNhat
            // 
            this.btnNhoNhat.Location = new System.Drawing.Point(244, 132);
            this.btnNhoNhat.Name = "btnNhoNhat";
            this.btnNhoNhat.Size = new System.Drawing.Size(200, 31);
            this.btnNhoNhat.TabIndex = 2;
            this.btnNhoNhat.Text = "Tìm phần tử nhỏ nhất";
            this.btnNhoNhat.UseVisualStyleBackColor = true;
            this.btnNhoNhat.Click += new System.EventHandler(this.btnNhoNhat_Click);
            // 
            // btnTongGiaTri
            // 
            this.btnTongGiaTri.Location = new System.Drawing.Point(24, 169);
            this.btnTongGiaTri.Name = "btnTongGiaTri";
            this.btnTongGiaTri.Size = new System.Drawing.Size(214, 31);
            this.btnTongGiaTri.TabIndex = 2;
            this.btnTongGiaTri.Text = "Tổng giá trị mảng";
            this.btnTongGiaTri.UseVisualStyleBackColor = true;
            this.btnTongGiaTri.Click += new System.EventHandler(this.btnTongGiaTri_Click);
            // 
            // btnTang2
            // 
            this.btnTang2.Location = new System.Drawing.Point(244, 169);
            this.btnTang2.Name = "btnTang2";
            this.btnTang2.Size = new System.Drawing.Size(200, 31);
            this.btnTang2.TabIndex = 2;
            this.btnTang2.Text = "Tăng mỗi phần tử lên 2";
            this.btnTang2.UseVisualStyleBackColor = true;
            this.btnTang2.Click += new System.EventHandler(this.btnTang2_Click);
            // 
            // btnDemLe
            // 
            this.btnDemLe.Location = new System.Drawing.Point(24, 206);
            this.btnDemLe.Name = "btnDemLe";
            this.btnDemLe.Size = new System.Drawing.Size(214, 31);
            this.btnDemLe.TabIndex = 2;
            this.btnDemLe.Text = "Đếm số phần tử lẻ";
            this.btnDemLe.UseVisualStyleBackColor = true;
            this.btnDemLe.Click += new System.EventHandler(this.btnDemLe_Click);
            // 
            // btnTangDan
            // 
            this.btnTangDan.Location = new System.Drawing.Point(244, 206);
            this.btnTangDan.Name = "btnTangDan";
            this.btnTangDan.Size = new System.Drawing.Size(200, 31);
            this.btnTangDan.TabIndex = 2;
            this.btnTangDan.Text = "Sắp xếp mảng tăng";
            this.btnTangDan.UseVisualStyleBackColor = true;
            this.btnTangDan.Click += new System.EventHandler(this.btnTangDan_Click);
            // 
            // btnTongLe
            // 
            this.btnTongLe.Location = new System.Drawing.Point(24, 239);
            this.btnTongLe.Name = "btnTongLe";
            this.btnTongLe.Size = new System.Drawing.Size(214, 31);
            this.btnTongLe.TabIndex = 2;
            this.btnTongLe.Text = "Tổng phần tử lẻ";
            this.btnTongLe.UseVisualStyleBackColor = true;
            this.btnTongLe.Click += new System.EventHandler(this.btnTongLe_Click);
            // 
            // btnGiamDan
            // 
            this.btnGiamDan.Location = new System.Drawing.Point(244, 239);
            this.btnGiamDan.Name = "btnGiamDan";
            this.btnGiamDan.Size = new System.Drawing.Size(200, 31);
            this.btnGiamDan.TabIndex = 2;
            this.btnGiamDan.Text = "Sắp xếp mảng giảm";
            this.btnGiamDan.UseVisualStyleBackColor = true;
            this.btnGiamDan.Click += new System.EventHandler(this.btnGiamDan_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 282);
            this.Controls.Add(this.btnGiamDan);
            this.Controls.Add(this.btnTangDan);
            this.Controls.Add(this.btnTang2);
            this.Controls.Add(this.btnNhoNhat);
            this.Controls.Add(this.btnTongLe);
            this.Controls.Add(this.btnDemLe);
            this.Controls.Add(this.btnTongGiaTri);
            this.Controls.Add(this.btnXuatMang);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtMangGoc;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtKetQua;
        private System.Windows.Forms.Button btnXuatMang;
        private System.Windows.Forms.Button btnNhoNhat;
        private System.Windows.Forms.Button btnTongGiaTri;
        private System.Windows.Forms.Button btnTang2;
        private System.Windows.Forms.Button btnDemLe;
        private System.Windows.Forms.Button btnTangDan;
        private System.Windows.Forms.Button btnTongLe;
        private System.Windows.Forms.Button btnGiamDan;
    }
}

