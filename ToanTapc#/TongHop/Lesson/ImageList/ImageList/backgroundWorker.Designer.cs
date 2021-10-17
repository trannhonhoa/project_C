namespace ImageList
{
    partial class backgroundWorker
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.txtN = new System.Windows.Forms.TextBox();
            this.btnVe = new System.Windows.Forms.Button();
            this.btnSapXep = new System.Windows.Forms.Button();
            this.pnButton = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // txtN
            // 
            this.txtN.Location = new System.Drawing.Point(68, 21);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(115, 20);
            this.txtN.TabIndex = 1;
            // 
            // btnVe
            // 
            this.btnVe.Location = new System.Drawing.Point(189, 19);
            this.btnVe.Name = "btnVe";
            this.btnVe.Size = new System.Drawing.Size(75, 23);
            this.btnVe.TabIndex = 2;
            this.btnVe.Text = "Ve";
            this.btnVe.UseVisualStyleBackColor = true;
            this.btnVe.Click += new System.EventHandler(this.btnVe_Click);
            // 
            // btnSapXep
            // 
            this.btnSapXep.Location = new System.Drawing.Point(270, 19);
            this.btnSapXep.Name = "btnSapXep";
            this.btnSapXep.Size = new System.Drawing.Size(75, 23);
            this.btnSapXep.TabIndex = 3;
            this.btnSapXep.Text = "Sap xep";
            this.btnSapXep.UseVisualStyleBackColor = true;
            // 
            // pnButton
            // 
            this.pnButton.Location = new System.Drawing.Point(18, 73);
            this.pnButton.Name = "pnButton";
            this.pnButton.Size = new System.Drawing.Size(387, 242);
            this.pnButton.TabIndex = 4;
            // 
            // backgroundWorker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 339);
            this.Controls.Add(this.pnButton);
            this.Controls.Add(this.btnSapXep);
            this.Controls.Add(this.btnVe);
            this.Controls.Add(this.txtN);
            this.Controls.Add(this.label1);
            this.Name = "backgroundWorker";
            this.Text = "backgroundWorker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtN;
        private System.Windows.Forms.Button btnVe;
        private System.Windows.Forms.Button btnSapXep;
        private System.Windows.Forms.Panel pnButton;
    }
}