using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi3_Bai3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            TaiNoiDungLenListBox();

        }

        private void TaiNoiDungLenListBox()
        {
            lstWeb.Items.AddRange(new string[] { "Tuổi trẻ", "Thanh niên", "VNExpress", "Dân trí", "Công an"});
            lstWeb.SelectedIndex = 0;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (lstWeb.SelectedIndex != -1)
            {
                txtKetQua.Text = "Bạn đã chọn website \r\n";
                txtKetQua.Text += lstWeb.SelectedItem.ToString();
            }
            
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtKetQua.Clear();
        }

        private void txtKetQua_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        
    }
}
