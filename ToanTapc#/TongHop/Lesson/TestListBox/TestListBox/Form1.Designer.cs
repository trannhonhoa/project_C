namespace TestListBox
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
            this.textInput = new System.Windows.Forms.TextBox();
            this.btnCapnhat = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnLe = new System.Windows.Forms.Button();
            this.btnChan = new System.Windows.Forms.Button();
            this.btnBinhPhuong = new System.Windows.Forms.Button();
            this.btnTang2 = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnXoaDauCuoi = new System.Windows.Forms.Button();
            this.btnTong = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhap so";
            // 
            // textInput
            // 
            this.textInput.Location = new System.Drawing.Point(105, 22);
            this.textInput.Name = "textInput";
            this.textInput.Size = new System.Drawing.Size(198, 20);
            this.textInput.TabIndex = 1;
            // 
            // btnCapnhat
            // 
            this.btnCapnhat.Location = new System.Drawing.Point(340, 20);
            this.btnCapnhat.Name = "btnCapnhat";
            this.btnCapnhat.Size = new System.Drawing.Size(75, 23);
            this.btnCapnhat.TabIndex = 2;
            this.btnCapnhat.Text = "Cap nhat";
            this.btnCapnhat.UseVisualStyleBackColor = true;
            this.btnCapnhat.Click += new System.EventHandler(this.btnCapnhat_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Location = new System.Drawing.Point(12, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(160, 188);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(3, 16);
            this.listBox1.Name = "listBox1";
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBox1.Size = new System.Drawing.Size(154, 169);
            this.listBox1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnLe);
            this.groupBox2.Controls.Add(this.btnChan);
            this.groupBox2.Controls.Add(this.btnBinhPhuong);
            this.groupBox2.Controls.Add(this.btnTang2);
            this.groupBox2.Controls.Add(this.btnXoa);
            this.groupBox2.Controls.Add(this.btnXoaDauCuoi);
            this.groupBox2.Controls.Add(this.btnTong);
            this.groupBox2.Location = new System.Drawing.Point(220, 71);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(183, 246);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // btnLe
            // 
            this.btnLe.Location = new System.Drawing.Point(6, 199);
            this.btnLe.Name = "btnLe";
            this.btnLe.Size = new System.Drawing.Size(171, 23);
            this.btnLe.TabIndex = 6;
            this.btnLe.Text = "Chan so le";
            this.btnLe.UseVisualStyleBackColor = true;
            // 
            // btnChan
            // 
            this.btnChan.Location = new System.Drawing.Point(6, 170);
            this.btnChan.Name = "btnChan";
            this.btnChan.Size = new System.Drawing.Size(171, 23);
            this.btnChan.TabIndex = 5;
            this.btnChan.Text = "Chon so chan";
            this.btnChan.UseVisualStyleBackColor = true;
            // 
            // btnBinhPhuong
            // 
            this.btnBinhPhuong.Location = new System.Drawing.Point(6, 141);
            this.btnBinhPhuong.Name = "btnBinhPhuong";
            this.btnBinhPhuong.Size = new System.Drawing.Size(171, 23);
            this.btnBinhPhuong.TabIndex = 4;
            this.btnBinhPhuong.Text = "Thay bang binh phuong";
            this.btnBinhPhuong.UseVisualStyleBackColor = true;
            // 
            // btnTang2
            // 
            this.btnTang2.Location = new System.Drawing.Point(6, 112);
            this.btnTang2.Name = "btnTang2";
            this.btnTang2.Size = new System.Drawing.Size(171, 23);
            this.btnTang2.TabIndex = 3;
            this.btnTang2.Text = "Tang moi phan tu len 3";
            this.btnTang2.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(6, 83);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(171, 23);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xoa phan tu dang chon";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnXoaDauCuoi
            // 
            this.btnXoaDauCuoi.Location = new System.Drawing.Point(6, 54);
            this.btnXoaDauCuoi.Name = "btnXoaDauCuoi";
            this.btnXoaDauCuoi.Size = new System.Drawing.Size(171, 23);
            this.btnXoaDauCuoi.TabIndex = 1;
            this.btnXoaDauCuoi.Text = "Xoa dau va cuoi";
            this.btnXoaDauCuoi.UseVisualStyleBackColor = true;
            this.btnXoaDauCuoi.Click += new System.EventHandler(this.btnXoaDauCuoi_Click);
            // 
            // btnTong
            // 
            this.btnTong.Location = new System.Drawing.Point(6, 19);
            this.btnTong.Name = "btnTong";
            this.btnTong.Size = new System.Drawing.Size(171, 23);
            this.btnTong.TabIndex = 0;
            this.btnTong.Text = "Tong";
            this.btnTong.UseVisualStyleBackColor = true;
            this.btnTong.Click += new System.EventHandler(this.btnTong_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(174, 350);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 413);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCapnhat);
            this.Controls.Add(this.textInput);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textInput;
        private System.Windows.Forms.Button btnCapnhat;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnLe;
        private System.Windows.Forms.Button btnChan;
        private System.Windows.Forms.Button btnBinhPhuong;
        private System.Windows.Forms.Button btnTang2;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnXoaDauCuoi;
        private System.Windows.Forms.Button btnTong;
        private System.Windows.Forms.Button btnExit;
    }
}

