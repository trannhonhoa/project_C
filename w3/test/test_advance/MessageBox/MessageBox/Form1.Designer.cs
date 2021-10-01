namespace MessageBox
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
            this.lblhoten = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textHoLot = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textTen = new System.Windows.Forms.TextBox();
            this.btnHoLot = new System.Windows.Forms.Button();
            this.btnTen = new System.Windows.Forms.Button();
            this.btnHovaTen = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblhoten
            // 
            this.lblhoten.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblhoten.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblhoten.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhoten.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblhoten.Location = new System.Drawing.Point(0, 0);
            this.lblhoten.Name = "lblhoten";
            this.lblhoten.Size = new System.Drawing.Size(409, 29);
            this.lblhoten.TabIndex = 0;
            this.lblhoten.Text = "label1";
            this.lblhoten.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "HoLot";
            // 
            // textHoLot
            // 
            this.textHoLot.Location = new System.Drawing.Point(85, 71);
            this.textHoLot.Name = "textHoLot";
            this.textHoLot.Size = new System.Drawing.Size(286, 20);
            this.textHoLot.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ten";
            // 
            // textTen
            // 
            this.textTen.Location = new System.Drawing.Point(85, 115);
            this.textTen.Name = "textTen";
            this.textTen.Size = new System.Drawing.Size(286, 20);
            this.textTen.TabIndex = 4;
            // 
            // btnHoLot
            // 
            this.btnHoLot.Location = new System.Drawing.Point(51, 151);
            this.btnHoLot.Name = "btnHoLot";
            this.btnHoLot.Size = new System.Drawing.Size(75, 23);
            this.btnHoLot.TabIndex = 5;
            this.btnHoLot.Text = "&HoLot";
            this.btnHoLot.UseVisualStyleBackColor = true;
            this.btnHoLot.Click += new System.EventHandler(this.btnHoLot_Click);
            // 
            // btnTen
            // 
            this.btnTen.Location = new System.Drawing.Point(184, 151);
            this.btnTen.Name = "btnTen";
            this.btnTen.Size = new System.Drawing.Size(75, 23);
            this.btnTen.TabIndex = 6;
            this.btnTen.Text = "&Ten";
            this.btnTen.UseVisualStyleBackColor = true;
            this.btnTen.Click += new System.EventHandler(this.btnTen_Click);
            // 
            // btnHovaTen
            // 
            this.btnHovaTen.Location = new System.Drawing.Point(305, 151);
            this.btnHovaTen.Name = "btnHovaTen";
            this.btnHovaTen.Size = new System.Drawing.Size(75, 23);
            this.btnHovaTen.TabIndex = 7;
            this.btnHovaTen.Text = "Ho &va Ten";
            this.btnHovaTen.UseVisualStyleBackColor = true;
            this.btnHovaTen.Click += new System.EventHandler(this.btnHovaTen_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(96, 231);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(242, 23);
            this.btnThoat.TabIndex = 0;
            this.btnThoat.Text = "Thoat Chuong Trinh";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 296);
            this.Controls.Add(this.btnHovaTen);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnTen);
            this.Controls.Add(this.btnHoLot);
            this.Controls.Add(this.textTen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textHoLot);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblhoten);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblhoten;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textHoLot;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textTen;
        private System.Windows.Forms.Button btnHoLot;
        private System.Windows.Forms.Button btnTen;
        private System.Windows.Forms.Button btnHovaTen;
        private System.Windows.Forms.Button btnThoat;
    }
}

