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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogup_Click(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtName, "");
            errorProvider1.SetError(txtAge, "");
            if (txtName.Text == "")
            {
                errorProvider1.SetError(txtName, "Empty");
                return;
            }
            int tuoi = 0;
            if (int.TryParse(txtAge.Text, out tuoi) == false)
            {
                errorProvider1.SetError(txtAge, "Wrong");
                return;
            }
            else
            {
                if (tuoi < 18)
                {
                    errorProvider1.SetError(txtAge, "> = 18");
                    return;
                }
            }
            if (dateTimePicker1.Value.DayOfWeek == DayOfWeek.Sunday)
            {
                errorProvider1.SetError(dateTimePicker1, "No sunday");
                return;
            }
            MessageBox.Show("InforWrong");

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        

        
    }
}
