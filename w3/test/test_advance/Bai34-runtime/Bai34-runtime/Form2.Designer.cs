﻿namespace Bai34_runtime
{
    partial class Form2
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnButton = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDong = new System.Windows.Forms.TextBox();
            this.txtCot = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnVe = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnVe);
            this.panel1.Controls.Add(this.txtCot);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtDong);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(466, 73);
            this.panel1.TabIndex = 0;
            // 
            // pnButton
            // 
            this.pnButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnButton.Location = new System.Drawing.Point(0, 73);
            this.pnButton.Name = "pnButton";
            this.pnButton.Size = new System.Drawing.Size(466, 280);
            this.pnButton.TabIndex = 1;
            this.pnButton.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "dong";
            // 
            // txtDong
            // 
            this.txtDong.Location = new System.Drawing.Point(54, 17);
            this.txtDong.Name = "txtDong";
            this.txtDong.Size = new System.Drawing.Size(100, 20);
            this.txtDong.TabIndex = 1;
            // 
            // txtCot
            // 
            this.txtCot.Location = new System.Drawing.Point(207, 17);
            this.txtCot.Name = "txtCot";
            this.txtCot.Size = new System.Drawing.Size(100, 20);
            this.txtCot.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(166, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "cot";
            // 
            // btnVe
            // 
            this.btnVe.Location = new System.Drawing.Point(327, 13);
            this.btnVe.Name = "btnVe";
            this.btnVe.Size = new System.Drawing.Size(57, 26);
            this.btnVe.TabIndex = 4;
            this.btnVe.Text = "Ve";
            this.btnVe.UseVisualStyleBackColor = true;
            this.btnVe.Click += new System.EventHandler(this.btnVe_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 353);
            this.Controls.Add(this.pnButton);
            this.Controls.Add(this.panel1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnButton;
        private System.Windows.Forms.Button btnVe;
        private System.Windows.Forms.TextBox txtCot;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDong;
        private System.Windows.Forms.Label label1;
    }
}