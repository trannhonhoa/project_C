using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace MessageBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            System.Windows.Forms.MessageBox.Show("test");
        }

        private void btnHoLot_Click(object sender, EventArgs e)
        {
            lblhoten.Text = textHoLot.Text;

        }

        private void btnTen_Click(object sender, EventArgs e)
        {
            lblhoten.Text = textTen.Text;
        }

        private void btnHovaTen_Click(object sender, EventArgs e)
        {
            lblhoten.Text = textHoLot.Text + " " + textTen.Text;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult ret = System.Windows.Forms.MessageBox.Show("Exit??", "Oke?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Error);
            if (ret == DialogResult.Yes)
            {
                Close();
            }
        }

        
    }
}
