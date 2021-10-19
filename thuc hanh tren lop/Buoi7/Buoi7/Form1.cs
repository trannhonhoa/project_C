using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace Buoi7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // lay danh sach cac o dia
            string[] drives = Directory.GetLogicalDrives();
            TreeNode node = null;
            foreach (string drv in drives)
            {
                // duyet tung o dia
                node = new TreeNode(drv);
                tvDisk.Nodes.Add(node);
                node.Nodes.Add("Temp");
            }
        }

        private void tvDisk_AfterSelect(object sender, TreeViewEventArgs e)
        {
            try
            {
                // load cac hinh anh
                picView.Image = null;
                // lay danh sach cac file trong thu muc
                string[] arrFiles = Directory.GetFiles(e.Node.FullPath);
                fpPic.Controls.Clear();
                foreach (string file in arrFiles)
                {
                    // duyet qua cac file
                    if( file.ToLower().EndsWith(".jpg") ||
                        file.ToLower().EndsWith(".gif") ||
                        file.ToLower().EndsWith(".png") ||
                        file.ToLower().EndsWith(".bmp") ||
                        file.ToLower().EndsWith(".jpeg") )
                    {
                        PictureBox pic = new PictureBox();
                        pic.SizeMode = PictureBoxSizeMode.StretchImage;
                        pic.Image = Image.FromFile(file);
                        pic.Height = fpPic.Height - 10;
                        pic.Width = pic.Height * 5 / 4;
                        pic.Cursor = Cursors.Hand;
                        fpPic.Controls.Add(pic);
                        pic.Click += pic_Click;
                    }
                }
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        void pic_Click(object sender, EventArgs e)
        {
            PictureBox pic = sender as PictureBox;
            picView.Image = pic.Image;
        }

        private void tvDisk_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            TreeNode node = e.Node;
            node.Nodes.Clear();
            try
            {
                //duyet qua cac thu muc
                foreach (string dir in Directory.GetDirectories(node.FullPath))
                {
                    // them cac thu muc con vao node hien tai
                    TreeNode n = node.Nodes.Add(Path.GetFileName(dir));
                    n.Nodes.Add("Temp");
                }
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        private void tvDisk_BeforeCollapse(object sender, TreeViewCancelEventArgs e)
        {

        }
    }
}
