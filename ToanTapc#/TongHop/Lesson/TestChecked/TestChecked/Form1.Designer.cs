namespace TestChecked
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
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.btnMoveRight = new System.Windows.Forms.Button();
            this.btnMoveRightAll = new System.Windows.Forms.Button();
            this.btnMoveLeft = new System.Windows.Forms.Button();
            this.btnMoveLeftAll = new System.Windows.Forms.Button();
            this.checkedListBox2 = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(28, 30);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(132, 154);
            this.checkedListBox1.TabIndex = 0;
            // 
            // btnMoveRight
            // 
            this.btnMoveRight.Location = new System.Drawing.Point(199, 30);
            this.btnMoveRight.Name = "btnMoveRight";
            this.btnMoveRight.Size = new System.Drawing.Size(75, 23);
            this.btnMoveRight.TabIndex = 1;
            this.btnMoveRight.Text = ">";
            this.btnMoveRight.UseVisualStyleBackColor = true;
            this.btnMoveRight.Click += new System.EventHandler(this.btnMoveRight_Click);
            // 
            // btnMoveRightAll
            // 
            this.btnMoveRightAll.Location = new System.Drawing.Point(199, 78);
            this.btnMoveRightAll.Name = "btnMoveRightAll";
            this.btnMoveRightAll.Size = new System.Drawing.Size(75, 23);
            this.btnMoveRightAll.TabIndex = 2;
            this.btnMoveRightAll.Text = ">>";
            this.btnMoveRightAll.UseVisualStyleBackColor = true;
            this.btnMoveRightAll.Click += new System.EventHandler(this.btnMoveRightAll_Click);
            // 
            // btnMoveLeft
            // 
            this.btnMoveLeft.Location = new System.Drawing.Point(199, 125);
            this.btnMoveLeft.Name = "btnMoveLeft";
            this.btnMoveLeft.Size = new System.Drawing.Size(75, 23);
            this.btnMoveLeft.TabIndex = 3;
            this.btnMoveLeft.Text = "<";
            this.btnMoveLeft.UseVisualStyleBackColor = true;
            this.btnMoveLeft.Click += new System.EventHandler(this.btnMoveLeft_Click);
            // 
            // btnMoveLeftAll
            // 
            this.btnMoveLeftAll.Location = new System.Drawing.Point(199, 170);
            this.btnMoveLeftAll.Name = "btnMoveLeftAll";
            this.btnMoveLeftAll.Size = new System.Drawing.Size(75, 23);
            this.btnMoveLeftAll.TabIndex = 4;
            this.btnMoveLeftAll.Text = "<<";
            this.btnMoveLeftAll.UseVisualStyleBackColor = true;
            this.btnMoveLeftAll.Click += new System.EventHandler(this.btnMoveLeftAll_Click);
            // 
            // checkedListBox2
            // 
            this.checkedListBox2.FormattingEnabled = true;
            this.checkedListBox2.Location = new System.Drawing.Point(308, 30);
            this.checkedListBox2.Name = "checkedListBox2";
            this.checkedListBox2.Size = new System.Drawing.Size(132, 154);
            this.checkedListBox2.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 318);
            this.Controls.Add(this.checkedListBox2);
            this.Controls.Add(this.btnMoveLeftAll);
            this.Controls.Add(this.btnMoveLeft);
            this.Controls.Add(this.btnMoveRightAll);
            this.Controls.Add(this.btnMoveRight);
            this.Controls.Add(this.checkedListBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button btnMoveRight;
        private System.Windows.Forms.Button btnMoveRightAll;
        private System.Windows.Forms.Button btnMoveLeft;
        private System.Windows.Forms.Button btnMoveLeftAll;
        private System.Windows.Forms.CheckedListBox checkedListBox2;
    }
}

