using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageList
{
    public partial class backgroundWorker : Form
    {
        public backgroundWorker()
        {
            InitializeComponent();
        }
        Random rd = new Random();
        int[] M;
        Button[] Mc;
        int GAP = 50;
        int HEIGHT = 100;
        int SIZE = 50;
        private void btnVe_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txtN.Text);
            M = new int[n];
            Mc = new Button[n];
            pnButton.Controls.Clear();
            for (int i = 0; i < n; i++)
            {
                Button btn = new Button();
                int value = rd.Next(100);
                btn.Text = value + "";
                btn.Width = btn.Height = SIZE;
                btn.Location = new Point(i * btn.Width + GAP, pnButton.Height / 2 - btn.Height);
                pnButton.Controls.Add(btn);
                M[i] = value;
                Mc[i] = btn;
            }

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {

        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

        }
    }
}
