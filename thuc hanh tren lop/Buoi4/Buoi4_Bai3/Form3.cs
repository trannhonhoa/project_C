using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi4_Bai3
{
    public partial class Form3 : Form
    {
        int[] c;
        public Form3(int [] arr )
        {
            InitializeComponent();
            c = new int[arr.Length];
            Array.Copy(arr, c, arr.Length);
        }
        private int TimMax()
        {
            int max = c[0];
            foreach (int x in c)
            {
                if (max < x)
                {
                    max = x;
                }
            }
            return max;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            lblKetQua.Text += TimMax().ToString();
        }
    }
}
