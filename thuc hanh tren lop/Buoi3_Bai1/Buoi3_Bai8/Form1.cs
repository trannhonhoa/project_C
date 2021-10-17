using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi3_Bai8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbHoten.Items.AddRange(new string[] {"Trần Nhơn Hòa", "Nguyễn Thanh Hùng", "Huỳnh Cây Dương" });
        }

        private void btnHienLoiChao_Click(object sender, EventArgs e)
        {
            if (cmbHoten.SelectedIndex != -1)
            {
                MessageBox.Show("Chào " + cmbHoten.SelectedItem.ToString() + " chúc một ngày mới thất bại", "Thông báo");
            }
        }


        
    }
}
