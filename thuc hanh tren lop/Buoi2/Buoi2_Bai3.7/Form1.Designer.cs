﻿namespace Buoi2_Bai3._7
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
            this.btnGiai = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtA = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtC = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtKetqua = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textC = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGiai
            // 
            this.btnGiai.Location = new System.Drawing.Point(137, 304);
            this.btnGiai.Name = "btnGiai";
            this.btnGiai.Size = new System.Drawing.Size(95, 37);
            this.btnGiai.TabIndex = 5;
            this.btnGiai.Text = "Giai";
            this.btnGiai.UseVisualStyleBackColor = true;
            this.btnGiai.Click += new System.EventHandler(this.btnGiai_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textC);
            this.groupBox1.Controls.Add(this.txtB);
            this.groupBox1.Controls.Add(this.txtA);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtC);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(83, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(202, 176);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Phuong trinh";
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(73, 84);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(109, 22);
            this.txtB.TabIndex = 4;
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(73, 34);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(109, 22);
            this.txtA.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "b:";
            // 
            // txtC
            // 
            this.txtC.AutoSize = true;
            this.txtC.Location = new System.Drawing.Point(22, 128);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(18, 16);
            this.txtC.TabIndex = 1;
            this.txtC.Text = "c:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "a:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(79, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "GIAI PHUONG TRINH BAC 2";
            // 
            // txtKetqua
            // 
            this.txtKetqua.Location = new System.Drawing.Point(70, 256);
            this.txtKetqua.Name = "txtKetqua";
            this.txtKetqua.Size = new System.Drawing.Size(297, 22);
            this.txtKetqua.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 262);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ket qua:";
            // 
            // textC
            // 
            this.textC.Location = new System.Drawing.Point(73, 128);
            this.textC.Name = "textC";
            this.textC.Size = new System.Drawing.Size(109, 22);
            this.textC.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 401);
            this.Controls.Add(this.txtKetqua);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnGiai);
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

        private System.Windows.Forms.Button btnGiai;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label txtC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKetqua;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textC;
    }
}

