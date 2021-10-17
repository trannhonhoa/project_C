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
    public partial class Form2 : Form
    {
        int[] b;
        public Form2(int [] arr) 
        {
            InitializeComponent();
            b = new int[arr.Length];
            Array.Copy(arr, b, arr.Length);
        }
        
        
        private int TinhTong()
        {
            int sum = 0;
            foreach (int x in b)
            {
                sum += x;
            }
            return sum;
        }
        private void Form2_Load(object sender, EventArgs e)
        {
           
            lblKetQua.Text += TinhTong().ToString();
        }
        
       
    }
}
