namespace Buoi7_Bai5
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
            this.btnEclipse = new System.Windows.Forms.Button();
            this.btnRec = new System.Windows.Forms.Button();
            this.btnLine = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnColor = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnClean = new System.Windows.Forms.Button();
            this.btnFill = new System.Windows.Forms.Button();
            this.btnPen = new System.Windows.Forms.Button();
            this.pic = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnEclipse);
            this.groupBox1.Controls.Add(this.btnRec);
            this.groupBox1.Controls.Add(this.btnLine);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(225, 91);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Shape";
            // 
            // btnEclipse
            // 
            this.btnEclipse.Location = new System.Drawing.Point(141, 40);
            this.btnEclipse.Name = "btnEclipse";
            this.btnEclipse.Size = new System.Drawing.Size(67, 36);
            this.btnEclipse.TabIndex = 4;
            this.btnEclipse.Text = "E";
            this.btnEclipse.UseVisualStyleBackColor = true;
            // 
            // btnRec
            // 
            this.btnRec.Location = new System.Drawing.Point(76, 40);
            this.btnRec.Name = "btnRec";
            this.btnRec.Size = new System.Drawing.Size(59, 36);
            this.btnRec.TabIndex = 3;
            this.btnRec.Text = "Rec";
            this.btnRec.UseVisualStyleBackColor = true;
            // 
            // btnLine
            // 
            this.btnLine.Location = new System.Drawing.Point(6, 40);
            this.btnLine.Name = "btnLine";
            this.btnLine.Size = new System.Drawing.Size(64, 36);
            this.btnLine.TabIndex = 2;
            this.btnLine.Text = "line";
            this.btnLine.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnFill);
            this.groupBox2.Controls.Add(this.btnColor);
            this.groupBox2.Location = new System.Drawing.Point(266, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(182, 91);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Color";
            // 
            // btnColor
            // 
            this.btnColor.Location = new System.Drawing.Point(6, 40);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(75, 36);
            this.btnColor.TabIndex = 1;
            this.btnColor.Text = "ColorColor";
            this.btnColor.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnPen);
            this.groupBox3.Controls.Add(this.btnClean);
            this.groupBox3.Location = new System.Drawing.Point(454, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(182, 91);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tool";
            // 
            // btnClean
            // 
            this.btnClean.Location = new System.Drawing.Point(6, 40);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(75, 36);
            this.btnClean.TabIndex = 0;
            this.btnClean.Text = "Clean";
            this.btnClean.UseVisualStyleBackColor = true;
            // 
            // btnFill
            // 
            this.btnFill.Location = new System.Drawing.Point(87, 40);
            this.btnFill.Name = "btnFill";
            this.btnFill.Size = new System.Drawing.Size(75, 36);
            this.btnFill.TabIndex = 2;
            this.btnFill.Text = "Fill";
            this.btnFill.UseVisualStyleBackColor = true;
            // 
            // btnPen
            // 
            this.btnPen.Location = new System.Drawing.Point(87, 40);
            this.btnPen.Name = "btnPen";
            this.btnPen.Size = new System.Drawing.Size(75, 36);
            this.btnPen.TabIndex = 1;
            this.btnPen.Text = "Pen";
            this.btnPen.UseVisualStyleBackColor = true;
            this.btnPen.Click += new System.EventHandler(this.btnPen_Click);
            // 
            // pic
            // 
            this.pic.Location = new System.Drawing.Point(13, 147);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(635, 283);
            this.pic.TabIndex = 4;
            this.pic.TabStop = false;
            this.pic.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pic_MouseDown);
            this.pic.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pic_MouseMove);
            this.pic.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pic_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 442);
            this.Controls.Add(this.pic);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnEclipse;
        private System.Windows.Forms.Button btnRec;
        private System.Windows.Forms.Button btnLine;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.Button btnFill;
        private System.Windows.Forms.Button btnPen;
        private System.Windows.Forms.PictureBox pic;
    }
}

