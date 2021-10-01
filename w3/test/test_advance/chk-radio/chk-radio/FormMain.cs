using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chk_radio
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            radRed.Checked = true;
            textNhapten.Focus();
        }

        private void textNhapten_TextChanged(object sender, EventArgs e)
        {
            lbllaptrinh.Text = textNhapten.Text;
        }

        private void radRed_CheckedChanged(object sender, EventArgs e)
        {
            if (radRed.Checked == true)
            {
                lbllaptrinh.ForeColor = Color.Red;
            }
        }

        private void chkBold_CheckedChanged(object sender, EventArgs e)
        {

            lbllaptrinh.Font = new Font(lbllaptrinh.Font.Name, lbllaptrinh.Font.Size,
                    lbllaptrinh.Font.Style^FontStyle.Bold
                );
        }

        

        
    }
}
