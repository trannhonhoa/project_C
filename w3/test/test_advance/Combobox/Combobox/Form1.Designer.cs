namespace Combobox
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listSanPham = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboboxPay = new System.Windows.Forms.ComboBox();
            this.btnDathang = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listChitet = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Form Dat Hang";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(68, 52);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(232, 20);
            this.txtName.TabIndex = 2;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(68, 78);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(232, 20);
            this.txtPhone.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Phone";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listSanPham);
            this.groupBox1.Location = new System.Drawing.Point(29, 147);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(165, 146);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh Sach San Pham";
            // 
            // listSanPham
            // 
            this.listSanPham.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listSanPham.FormattingEnabled = true;
            this.listSanPham.Items.AddRange(new object[] {
            "Samsung",
            "Iphone",
            "Nokia"});
            this.listSanPham.Location = new System.Drawing.Point(3, 16);
            this.listSanPham.Name = "listSanPham";
            this.listSanPham.Size = new System.Drawing.Size(159, 127);
            this.listSanPham.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 308);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Pay";
            // 
            // comboboxPay
            // 
            this.comboboxPay.FormattingEnabled = true;
            this.comboboxPay.Items.AddRange(new object[] {
            "ATM",
            "Cash"});
            this.comboboxPay.Location = new System.Drawing.Point(58, 305);
            this.comboboxPay.Name = "comboboxPay";
            this.comboboxPay.Size = new System.Drawing.Size(121, 21);
            this.comboboxPay.TabIndex = 7;
            this.comboboxPay.SelectedIndexChanged += new System.EventHandler(this.comboboxPay_SelectedIndexChanged);
            // 
            // btnDathang
            // 
            this.btnDathang.Location = new System.Drawing.Point(185, 299);
            this.btnDathang.Name = "btnDathang";
            this.btnDathang.Size = new System.Drawing.Size(82, 34);
            this.btnDathang.TabIndex = 8;
            this.btnDathang.Text = "Add to cart";
            this.btnDathang.UseVisualStyleBackColor = true;
            this.btnDathang.Click += new System.EventHandler(this.btnDathang_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listChitet);
            this.groupBox2.Location = new System.Drawing.Point(342, 96);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 230);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thong tin chi tiet";
            // 
            // listChitet
            // 
            this.listChitet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listChitet.Location = new System.Drawing.Point(3, 16);
            this.listChitet.Multiline = true;
            this.listChitet.Name = "listChitet";
            this.listChitet.Size = new System.Drawing.Size(194, 211);
            this.listChitet.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(58, 343);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 10;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnDathang;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 394);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnDathang);
            this.Controls.Add(this.comboboxPay);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboboxPay;
        private System.Windows.Forms.Button btnDathang;
        private System.Windows.Forms.ListBox listSanPham;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox listChitet;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

