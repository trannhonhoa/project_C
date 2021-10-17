using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tatmoden
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtInput_TextChanged(object sender, EventArgs e)
        {
            if (picOn.Visible == false)
            {
                btnOnOff.Text = txtInput.Text + "Turn on the light";
            }
            else
            {
                btnOnOff.Text = txtInput.Text + "Turn off the light";
            }
        }

        private void btnOnOff_Click(object sender, EventArgs e)
        {
            if (picOn.Visible == false)
            {
                picOn.Visible = true;
                picOff.Visible = false;
            }
            else
            {
                picOn.Visible = true;
                picOff.Visible = false;
            }
        }

        
    }
}
