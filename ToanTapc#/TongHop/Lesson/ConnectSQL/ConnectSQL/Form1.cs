using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace ConnectSQL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection conc = null;
        string strConc = "Server=DESKTOP-P9L00KA; Database=QLBD;User Id=sa; pwd=trannhonhoa"; 
        private void btnKetNoi_Click(object sender, EventArgs e)
        {
            try
            {
                conc = new SqlConnection(strConc);
                conc.Open();
                MessageBox.Show("Ket noi thanh cong");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDongKetNoi_Click(object sender, EventArgs e)
        {
            if (conc != null && conc.State == ConnectionState.Open)
            {
                conc.Close();
                MessageBox.Show("Dong ket noi thanh cong");
            }
        }
    }
}
