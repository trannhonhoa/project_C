using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi6_Bai2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtThem.Text == "")
            {
                MessageBox.Show("Hãy nhập họ tên", "Thông báo"); return;
            }
            if (radA.Checked)
            {
                lstA.Items.Add(txtThem.Text);
            }
            else if (radB.Checked)
            {
                lstB.Items.Add(txtThem.Text);
            }
        }

        private void btnRight_Click(object sender, EventArgs e)
        {


            if (lstA.SelectedIndex != -1)
            {
                lstB.Items.Add(lstA.SelectedItems);
                lstA.Items.Remove(lstA.SelectedItems);
            }
            
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            if (lstB.SelectedIndex != -1)
            {
                lstA.Items.Add(lstB.SelectedItem);
                lstB.Items.Remove(lstB.SelectedItem);
            }
        }

        private void btnRightAll_Click(object sender, EventArgs e)
        {
            lstB.Items.AddRange(lstA.Items);
            lstA.Items.Clear();
        }

        private void btnLeftAll_Click(object sender, EventArgs e)
        {
            lstA.Items.AddRange(lstB.Items);
            lstB.Items.Clear();
        }

        

        
        

        
    }
}
