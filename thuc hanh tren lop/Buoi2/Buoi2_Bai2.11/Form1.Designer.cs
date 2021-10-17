namespace Buoi2_Bai2._11
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
            this.btnDienTich = new System.Windows.Forms.Button();
            this.btnDuongCheo = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnChuVi = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtA = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDienTich
            // 
            this.btnDienTich.Location = new System.Drawing.Point(145, 198);
            this.btnDienTich.Name = "btnDienTich";
            this.btnDienTich.Size = new System.Drawing.Size(75, 33);
            this.btnDienTich.TabIndex = 28;
            this.btnDienTich.Text = "Dien tich";
            this.btnDienTich.UseVisualStyleBackColor = true;
            this.btnDienTich.Click += new System.EventHandler(this.btnDienTich_Click);
            // 
            // btnDuongCheo
            // 
            this.btnDuongCheo.Location = new System.Drawing.Point(226, 198);
            this.btnDuongCheo.Name = "btnDuongCheo";
            this.btnDuongCheo.Size = new System.Drawing.Size(106, 33);
            this.btnDuongCheo.TabIndex = 27;
            this.btnDuongCheo.Text = "Duong cheo";
            this.btnDuongCheo.UseVisualStyleBackColor = true;
            this.btnDuongCheo.Click += new System.EventHandler(this.btnDuongCheo_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(338, 198);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 33);
            this.btnThoat.TabIndex = 26;
            this.btnThoat.Text = "Thoat";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnChuVi
            // 
            this.btnChuVi.Location = new System.Drawing.Point(55, 198);
            this.btnChuVi.Name = "btnChuVi";
            this.btnChuVi.Size = new System.Drawing.Size(75, 33);
            this.btnChuVi.TabIndex = 25;
            this.btnChuVi.Text = "Chu vi";
            this.btnChuVi.UseVisualStyleBackColor = true;
            this.btnChuVi.Click += new System.EventHandler(this.btnChuVi_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtB);
            this.groupBox1.Controls.Add(this.txtA);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(122, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(221, 115);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thong tin";
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(72, 81);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(118, 22);
            this.txtB.TabIndex = 3;
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(72, 37);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(118, 22);
            this.txtA.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "b:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "a:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(164, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "HINH CHU NHAT";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 284);
            this.Controls.Add(this.btnDienTich);
            this.Controls.Add(this.btnDuongCheo);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnChuVi);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDienTich;
        private System.Windows.Forms.Button btnDuongCheo;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnChuVi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}

