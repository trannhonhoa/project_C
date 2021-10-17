namespace truyvansql_bai61
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
            this.btnDemsosanpham = new System.Windows.Forms.Button();
            this.lblSoSanPham = new System.Windows.Forms.Label();
            this.txtChiTiet = new System.Windows.Forms.TextBox();
            this.btnChiTiet = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnHienThiSanPham = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Ma = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Ten = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DonGia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btnDemsosanpham
            // 
            this.btnDemsosanpham.Location = new System.Drawing.Point(2, 12);
            this.btnDemsosanpham.Name = "btnDemsosanpham";
            this.btnDemsosanpham.Size = new System.Drawing.Size(75, 23);
            this.btnDemsosanpham.TabIndex = 0;
            this.btnDemsosanpham.Text = "Dem so san pham";
            this.btnDemsosanpham.UseVisualStyleBackColor = true;
            this.btnDemsosanpham.Click += new System.EventHandler(this.btnDemsosanpham_Click);
            // 
            // lblSoSanPham
            // 
            this.lblSoSanPham.AutoSize = true;
            this.lblSoSanPham.Location = new System.Drawing.Point(94, 17);
            this.lblSoSanPham.Name = "lblSoSanPham";
            this.lblSoSanPham.Size = new System.Drawing.Size(35, 13);
            this.lblSoSanPham.TabIndex = 1;
            this.lblSoSanPham.Text = "label1";
            // 
            // txtChiTiet
            // 
            this.txtChiTiet.Location = new System.Drawing.Point(2, 70);
            this.txtChiTiet.Name = "txtChiTiet";
            this.txtChiTiet.Size = new System.Drawing.Size(100, 20);
            this.txtChiTiet.TabIndex = 2;
            // 
            // btnChiTiet
            // 
            this.btnChiTiet.Location = new System.Drawing.Point(2, 41);
            this.btnChiTiet.Name = "btnChiTiet";
            this.btnChiTiet.Size = new System.Drawing.Size(75, 23);
            this.btnChiTiet.TabIndex = 3;
            this.btnChiTiet.Text = "Chi  tiet";
            this.btnChiTiet.UseVisualStyleBackColor = true;
            this.btnChiTiet.Click += new System.EventHandler(this.btnChiTiet_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(83, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Chi tiet cach 2";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnHienThiSanPham
            // 
            this.btnHienThiSanPham.Location = new System.Drawing.Point(348, 17);
            this.btnHienThiSanPham.Name = "btnHienThiSanPham";
            this.btnHienThiSanPham.Size = new System.Drawing.Size(181, 30);
            this.btnHienThiSanPham.TabIndex = 5;
            this.btnHienThiSanPham.Text = "Hien thi san pham";
            this.btnHienThiSanPham.UseVisualStyleBackColor = true;
            this.btnHienThiSanPham.Click += new System.EventHandler(this.btnHienThiSanPham_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Ma,
            this.Ten,
            this.DonGia});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(241, 70);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(431, 178);
            this.listView1.TabIndex = 6;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // Ma
            // 
            this.Ma.Text = "Ma";
            this.Ma.Width = 100;
            // 
            // Ten
            // 
            this.Ten.Text = "Ten";
            this.Ten.Width = 150;
            // 
            // DonGia
            // 
            this.DonGia.Text = "Don gia";
            this.DonGia.Width = 150;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 410);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnHienThiSanPham);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnChiTiet);
            this.Controls.Add(this.txtChiTiet);
            this.Controls.Add(this.lblSoSanPham);
            this.Controls.Add(this.btnDemsosanpham);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDemsosanpham;
        private System.Windows.Forms.Label lblSoSanPham;
        private System.Windows.Forms.TextBox txtChiTiet;
        private System.Windows.Forms.Button btnChiTiet;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnHienThiSanPham;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Ma;
        private System.Windows.Forms.ColumnHeader Ten;
        private System.Windows.Forms.ColumnHeader DonGia;
    }
}

