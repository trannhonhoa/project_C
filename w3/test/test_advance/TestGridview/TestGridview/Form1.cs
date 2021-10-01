using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestGridview
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<NhanVien> dsnv = new List<NhanVien>();
            dsnv.Add(new NhanVien(){Ma = 1, Ten="Nguyen", Phone="1234567"});
            dsnv.Add(new NhanVien(){Ma = 1, Ten="Nguyen", Phone="1234567"});
            dsnv.Add(new NhanVien(){Ma = 1, Ten="Nguyen", Phone="1234567"});
            dataGridView1.DataSource = dsnv;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }

            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            string ten = row.Cells[1].Value+"";
            MessageBox.Show(ten);
        }
    }
}
