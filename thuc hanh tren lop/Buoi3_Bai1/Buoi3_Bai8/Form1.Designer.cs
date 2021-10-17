namespace Buoi3_Bai8
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
            this.cmbHoten = new System.Windows.Forms.ComboBox();
            this.btnHienLoiChao = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ tên:";
            // 
            // cmbHoten
            // 
            this.cmbHoten.FormattingEnabled = true;
            this.cmbHoten.Location = new System.Drawing.Point(116, 44);
            this.cmbHoten.Name = "cmbHoten";
            this.cmbHoten.Size = new System.Drawing.Size(184, 27);
            this.cmbHoten.TabIndex = 1;
            // 
            // btnHienLoiChao
            // 
            this.btnHienLoiChao.Location = new System.Drawing.Point(116, 93);
            this.btnHienLoiChao.Name = "btnHienLoiChao";
            this.btnHienLoiChao.Size = new System.Drawing.Size(119, 36);
            this.btnHienLoiChao.TabIndex = 2;
            this.btnHienLoiChao.Text = "Hiện lời chào";
            this.btnHienLoiChao.UseVisualStyleBackColor = true;
            this.btnHienLoiChao.Click += new System.EventHandler(this.btnHienLoiChao_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 159);
            this.Controls.Add(this.btnHienLoiChao);
            this.Controls.Add(this.cmbHoten);
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

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbHoten;
        private System.Windows.Forms.Button btnHienLoiChao;
    }
}

