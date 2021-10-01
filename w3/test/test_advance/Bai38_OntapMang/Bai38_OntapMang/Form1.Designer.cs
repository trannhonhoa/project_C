namespace Bai38_OntapMang
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
            this.txtManggoc = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtKetqua = new System.Windows.Forms.TextBox();
            this.btnXuatNgauNhien = new System.Windows.Forms.Button();
            this.btnTong = new System.Windows.Forms.Button();
            this.btnTimNhoNhat = new System.Windows.Forms.Button();
            this.btnTangLen2 = new System.Windows.Forms.Button();
            this.btnGiamdan = new System.Windows.Forms.Button();
            this.btnTongle = new System.Windows.Forms.Button();
            this.btnTangdan = new System.Windows.Forms.Button();
            this.btnDemle = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtManggoc);
            this.groupBox1.Location = new System.Drawing.Point(84, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(653, 86);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mang goc";
            // 
            // txtManggoc
            // 
            this.txtManggoc.Location = new System.Drawing.Point(76, 39);
            this.txtManggoc.Name = "txtManggoc";
            this.txtManggoc.Size = new System.Drawing.Size(454, 30);
            this.txtManggoc.TabIndex = 1;
            this.txtManggoc.TextChanged += new System.EventHandler(this.txtManggoc_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtKetqua);
            this.groupBox2.Location = new System.Drawing.Point(84, 93);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(653, 86);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ket qua";
            // 
            // txtKetqua
            // 
            this.txtKetqua.Location = new System.Drawing.Point(76, 39);
            this.txtKetqua.Name = "txtKetqua";
            this.txtKetqua.Size = new System.Drawing.Size(454, 30);
            this.txtKetqua.TabIndex = 1;
            // 
            // btnXuatNgauNhien
            // 
            this.btnXuatNgauNhien.Location = new System.Drawing.Point(96, 213);
            this.btnXuatNgauNhien.Name = "btnXuatNgauNhien";
            this.btnXuatNgauNhien.Size = new System.Drawing.Size(261, 32);
            this.btnXuatNgauNhien.TabIndex = 3;
            this.btnXuatNgauNhien.Text = "Xuat mang ngau nhien";
            this.btnXuatNgauNhien.UseVisualStyleBackColor = true;
            this.btnXuatNgauNhien.Click += new System.EventHandler(this.btnXuatNgauNhien_Click);
            // 
            // btnTong
            // 
            this.btnTong.Location = new System.Drawing.Point(96, 266);
            this.btnTong.Name = "btnTong";
            this.btnTong.Size = new System.Drawing.Size(261, 32);
            this.btnTong.TabIndex = 4;
            this.btnTong.Text = "Tinh tong gia tri mang";
            this.btnTong.UseVisualStyleBackColor = true;
            this.btnTong.Click += new System.EventHandler(this.btnTong_Click);
            // 
            // btnTimNhoNhat
            // 
            this.btnTimNhoNhat.Location = new System.Drawing.Point(476, 213);
            this.btnTimNhoNhat.Name = "btnTimNhoNhat";
            this.btnTimNhoNhat.Size = new System.Drawing.Size(261, 32);
            this.btnTimNhoNhat.TabIndex = 5;
            this.btnTimNhoNhat.Text = "Tim phan tu nho nhat";
            this.btnTimNhoNhat.UseVisualStyleBackColor = true;
            this.btnTimNhoNhat.Click += new System.EventHandler(this.btnTimNhoNhat_Click);
            // 
            // btnTangLen2
            // 
            this.btnTangLen2.Location = new System.Drawing.Point(476, 266);
            this.btnTangLen2.Name = "btnTangLen2";
            this.btnTangLen2.Size = new System.Drawing.Size(261, 32);
            this.btnTangLen2.TabIndex = 6;
            this.btnTangLen2.Text = "Tang len 2";
            this.btnTangLen2.UseVisualStyleBackColor = true;
            this.btnTangLen2.Click += new System.EventHandler(this.btnTangLen2_Click);
            // 
            // btnGiamdan
            // 
            this.btnGiamdan.Location = new System.Drawing.Point(476, 382);
            this.btnGiamdan.Name = "btnGiamdan";
            this.btnGiamdan.Size = new System.Drawing.Size(261, 32);
            this.btnGiamdan.TabIndex = 7;
            this.btnGiamdan.Text = "Sap xep giam dan";
            this.btnGiamdan.UseVisualStyleBackColor = true;
            this.btnGiamdan.Click += new System.EventHandler(this.btnGiamdan_Click);
            // 
            // btnTongle
            // 
            this.btnTongle.Location = new System.Drawing.Point(96, 382);
            this.btnTongle.Name = "btnTongle";
            this.btnTongle.Size = new System.Drawing.Size(261, 32);
            this.btnTongle.TabIndex = 8;
            this.btnTongle.Text = "Tong gia tri phan tu le";
            this.btnTongle.UseVisualStyleBackColor = true;
            this.btnTongle.Click += new System.EventHandler(this.btnTongle_Click);
            // 
            // btnTangdan
            // 
            this.btnTangdan.Location = new System.Drawing.Point(476, 318);
            this.btnTangdan.Name = "btnTangdan";
            this.btnTangdan.Size = new System.Drawing.Size(261, 32);
            this.btnTangdan.TabIndex = 9;
            this.btnTangdan.Text = "Sap xep tang dan";
            this.btnTangdan.UseVisualStyleBackColor = true;
            this.btnTangdan.Click += new System.EventHandler(this.btnTangdan_Click);
            // 
            // btnDemle
            // 
            this.btnDemle.Location = new System.Drawing.Point(96, 318);
            this.btnDemle.Name = "btnDemle";
            this.btnDemle.Size = new System.Drawing.Size(261, 32);
            this.btnDemle.TabIndex = 10;
            this.btnDemle.Text = "Dem so phan tu le";
            this.btnDemle.UseVisualStyleBackColor = true;
            this.btnDemle.Click += new System.EventHandler(this.btnDemle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.btnDemle);
            this.Controls.Add(this.btnTangdan);
            this.Controls.Add(this.btnTongle);
            this.Controls.Add(this.btnGiamdan);
            this.Controls.Add(this.btnTangLen2);
            this.Controls.Add(this.btnTimNhoNhat);
            this.Controls.Add(this.btnTong);
            this.Controls.Add(this.btnXuatNgauNhien);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
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
        private System.Windows.Forms.TextBox txtManggoc;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtKetqua;
        private System.Windows.Forms.Button btnXuatNgauNhien;
        private System.Windows.Forms.Button btnTong;
        private System.Windows.Forms.Button btnTimNhoNhat;
        private System.Windows.Forms.Button btnTangLen2;
        private System.Windows.Forms.Button btnGiamdan;
        private System.Windows.Forms.Button btnTongle;
        private System.Windows.Forms.Button btnTangdan;
        private System.Windows.Forms.Button btnDemle;
    }
}

