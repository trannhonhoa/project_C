using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace newDay
{
    public partial class frmSinhVien : Form
    {
        public frmSinhVien()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SinhVien sv = new SinhVien();
            sv.Ma = int.Parse(txtma.Text);
            sv.Ten = txtten.Text;
            listBox1.Items.Add(sv);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                SinhVien sv = listBox1.SelectedItem as SinhVien;
                txtma.Text = sv.Ma.ToString();
                txtten.Text = sv.Ten.ToString();
            }
        }
    }
}
