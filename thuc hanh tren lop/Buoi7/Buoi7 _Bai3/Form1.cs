using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi7__Bai3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int index = -1;
        private void btnSau_Click(object sender, EventArgs e)
        {
            if (index < 2)
            {
                index++;
            }
            pictureBox.Image = imageList1.Images[index];
        }

        private void btnTruoc_Click(object sender, EventArgs e)
        {
            if (index > 0)
            {
                index--;
            }
            pictureBox.Image = imageList1.Images[index];
        }

        private void button2_Click(object sender, EventArgs e)

        {
            
            
        }
    }
}
