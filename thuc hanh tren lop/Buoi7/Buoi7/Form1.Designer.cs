namespace Buoi7
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
            this.components = new System.ComponentModel.Container();
            this.tvDisk = new System.Windows.Forms.TreeView();
            this.picView = new System.Windows.Forms.PictureBox();
            this.fpPic = new System.Windows.Forms.FlowLayoutPanel();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picView)).BeginInit();
            this.SuspendLayout();
            // 
            // tvDisk
            // 
            this.tvDisk.Dock = System.Windows.Forms.DockStyle.Left;
            this.tvDisk.Location = new System.Drawing.Point(0, 0);
            this.tvDisk.Name = "tvDisk";
            this.tvDisk.Size = new System.Drawing.Size(228, 544);
            this.tvDisk.TabIndex = 0;
            this.tvDisk.BeforeCollapse += new System.Windows.Forms.TreeViewCancelEventHandler(this.tvDisk_BeforeCollapse);
            this.tvDisk.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.tvDisk_BeforeExpand);
            this.tvDisk.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvDisk_AfterSelect);
            // 
            // picView
            // 
            this.picView.Dock = System.Windows.Forms.DockStyle.Top;
            this.picView.Location = new System.Drawing.Point(228, 0);
            this.picView.Name = "picView";
            this.picView.Size = new System.Drawing.Size(492, 381);
            this.picView.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picView.TabIndex = 1;
            this.picView.TabStop = false;
            // 
            // fpPic
            // 
            this.fpPic.AutoScroll = true;
            this.fpPic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fpPic.Location = new System.Drawing.Point(228, 381);
            this.fpPic.Name = "fpPic";
            this.fpPic.Size = new System.Drawing.Size(492, 163);
            this.fpPic.TabIndex = 2;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 544);
            this.Controls.Add(this.fpPic);
            this.Controls.Add(this.picView);
            this.Controls.Add(this.tvDisk);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView tvDisk;
        private System.Windows.Forms.PictureBox picView;
        private System.Windows.Forms.FlowLayoutPanel fpPic;
        private System.Windows.Forms.ImageList imageList1;
    }
}

