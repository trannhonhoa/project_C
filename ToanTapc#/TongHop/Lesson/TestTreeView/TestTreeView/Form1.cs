using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestTreeView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void menuAdd_Click(object sender, EventArgs e)
        {
            ThemNut frm = new ThemNut();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                if (treeView1.SelectedNode == null) // click ra ngoai, toa node goc
                {
                    TreeNode root = new TreeNode(frm.txtNhapnut.Text); // tao 1 node
                    treeView1.Nodes.Add(root);
                }
                else // nhap vao mot nut, khong bi null
                {
                    TreeNode node = new TreeNode(frm.txtNhapnut.Text);
                    treeView1.SelectedNode.Nodes.Add(node);
                    if (node.Level == 2)
                    {
                        node.ImageIndex = 2;
                        node.SelectedImageIndex = 3; 
                    }
                }
            }
        }

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            treeView1.SelectedNode = e.Node;
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void menuEdit_Click(object sender, EventArgs e)
        {
            if (treeView1.SelectedNode == null)
            {
                return;
            }
            ThemNut frm = new ThemNut();
            if (frm.ShowDialog() == DialogResult.OK) 
            {
                treeView1.SelectedNode.Text = frm.txtNhapnut.Text;   
            }
        }

        private void menuDelete_Click(object sender, EventArgs e)
        {
            if (treeView1.SelectedNode != null)
            {
                treeView1.Nodes.Remove(treeView1.SelectedNode);
            }
        }

        private void menuMoRong_Click(object sender, EventArgs e)
        {
            if (treeView1.SelectedNode != null)
            {
                treeView1.SelectedNode.ExpandAll();
            }
        }

        private void menuThugom_Click(object sender, EventArgs e)
        {
            if (treeView1.SelectedNode != null)
            {
                treeView1.SelectedNode.Collapse();   
            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node != null)
            {
                label1.Text = e.Node.Text;
            }
        }

    }
}
