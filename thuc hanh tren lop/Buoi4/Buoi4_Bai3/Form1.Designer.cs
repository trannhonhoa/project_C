namespace Buoi4_Bai3
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
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnTaoMang = new System.Windows.Forms.Button();
            this.txtNhap = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSoLonNhat = new System.Windows.Forms.Button();
            this.btnTongMang = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnThoat
            // 
            this.btnThoat.ForeColor = System.Drawing.Color.Blue;
            this.btnThoat.Location = new System.Drawing.Point(290, 57);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(91, 29);
            this.btnThoat.TabIndex = 9;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // btnTaoMang
            // 
            this.btnTaoMang.ForeColor = System.Drawing.Color.Blue;
            this.btnTaoMang.Location = new System.Drawing.Point(240, 24);
            this.btnTaoMang.Name = "btnTaoMang";
            this.btnTaoMang.Size = new System.Drawing.Size(141, 27);
            this.btnTaoMang.TabIndex = 8;
            this.btnTaoMang.Text = "Tạo mảng random";
            this.btnTaoMang.UseVisualStyleBackColor = true;
            this.btnTaoMang.Click += new System.EventHandler(this.btnTaoMang_Click);
            // 
            // txtNhap
            // 
            this.txtNhap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtNhap.Location = new System.Drawing.Point(168, 24);
            this.txtNhap.Name = "txtNhap";
            this.txtNhap.Size = new System.Drawing.Size(66, 26);
            this.txtNhap.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nhập số phần tử mảng:";
            // 
            // btnSoLonNhat
            // 
            this.btnSoLonNhat.ForeColor = System.Drawing.Color.Blue;
            this.btnSoLonNhat.Location = new System.Drawing.Point(156, 57);
            this.btnSoLonNhat.Name = "btnSoLonNhat";
            this.btnSoLonNhat.Size = new System.Drawing.Size(91, 29);
            this.btnSoLonNhat.TabIndex = 10;
            this.btnSoLonNhat.Text = "Số lớn nhất";
            this.btnSoLonNhat.UseVisualStyleBackColor = true;
            this.btnSoLonNhat.Click += new System.EventHandler(this.btnSoLonNhat_Click);
            // 
            // btnTongMang
            // 
            this.btnTongMang.ForeColor = System.Drawing.Color.Blue;
            this.btnTongMang.Location = new System.Drawing.Point(16, 57);
            this.btnTongMang.Name = "btnTongMang";
            this.btnTongMang.Size = new System.Drawing.Size(91, 29);
            this.btnTongMang.TabIndex = 11;
            this.btnTongMang.Text = "Tổng mảng";
            this.btnTongMang.UseVisualStyleBackColor = true;
            this.btnTongMang.Click += new System.EventHandler(this.btnTongMang_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 109);
            this.Controls.Add(this.btnTongMang);
            this.Controls.Add(this.btnSoLonNhat);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnTaoMang);
            this.Controls.Add(this.txtNhap);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnTaoMang;
        private System.Windows.Forms.TextBox txtNhap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSoLonNhat;
        private System.Windows.Forms.Button btnTongMang;
    }
}

