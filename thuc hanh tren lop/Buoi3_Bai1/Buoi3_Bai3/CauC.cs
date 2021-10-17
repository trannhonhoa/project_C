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
    public partial class CauC : Form
    {
        public CauC()
        {
            InitializeComponent();
        }

        private void CauC_Load(object sender, EventArgs e)
        {
            HienThiThongTinlenCombobox();
        }
        private void HienThiThongTinlenCombobox()
        {
            cmbWeb.Items.AddRange(new string[] {"Tuổi trẻ", "Thanh niên", "VNExpress", "Dân trí", "Công an", "24h", "Zingme", "Kênh 14", "Sài Gòn Tiếp Thị"});
            cmbWeb.SelectedIndex = 0;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            txtKetQua.Text = "Bạn chọn web \r\n";
            txtKetQua.Text += cmbWeb.SelectedItem.ToString();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtKetQua.Clear();
            cmbWeb.SelectedIndex = 0;
        }
    }
}
