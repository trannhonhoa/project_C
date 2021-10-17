using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDoiFont_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                rtbVB.Font = fontDialog1.Font;
            }
        }

        private void btnChonMau_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                rtbVB.ForeColor = colorDialog1.Color;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Plain Text |*.txt | Tất cả |*.*";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                rtbVB.SaveFile(saveFileDialog1.FileName);
            }

        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Plain Text |*.txt | Tất cả |*.*";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                rtbVB.LoadFile(saveFileDialog1.FileName);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        

        

        
    }
}
