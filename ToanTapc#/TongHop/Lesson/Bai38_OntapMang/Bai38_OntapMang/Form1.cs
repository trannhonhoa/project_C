using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai38_OntapMang
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtManggoc_TextChanged(object sender, EventArgs e)
        {

        }
        int []M;
        Random rd = new Random();
        private void btnXuatNgauNhien_Click(object sender, EventArgs e)
        {
            M = new int[10];
            for(int i = 0; i < M.Length; i++  ){
                M[i] = rd.Next(100);
            }
            HienThiMangLenTestBox(M, txtManggoc);

        }
        void HienThiMangLenTestBox(int [] M, TextBox txt)
        {
            txt.Text = "";
            foreach (int x in M)
            {
                txt.Text += x + " ";
            }
        }

        private void btnTong_Click(object sender, EventArgs e)
        {
            int sum = 0;
            for (int i = 0; i < M.Length; i++)
            {
                sum += M[i];
            }
            txtKetqua.Text = "Sum = " + sum;          
       }

        private void btnDemle_Click(object sender, EventArgs e)
        {
            int dem = 0;
            foreach (int x in M)
            {
                if (x % 2 != 0)
                    dem++;
            }
            txtKetqua.Text = "So phan tu le = " + dem;
        }

        private void btnTongle_Click(object sender, EventArgs e)
        {
            int sum = 0;
            foreach (int x in M)
            {
                if (x % 2 != 0)
                    sum+=x;
            }
            txtKetqua.Text = "So phan tu le = " + sum;
        }

        private void btnTimNhoNhat_Click(object sender, EventArgs e)
        {
            int min = M[0];
            for (int i = 1; i < M.Length; i++)
            {
                if (min > M[i])
                    min = M[i];
            }
            txtKetqua.Text = "Phan tu nho nhat la: " + min; 
        }

        private void btnTangLen2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < M.Length; i++)
            {
                M[i] += 2;
            }
            HienThiMangLenTestBox(M, txtKetqua); 
        }

        private void btnTangdan_Click(object sender, EventArgs e)
        {
            for(int i= 0; i<M.Length; i++)
                for (int j = i + 1; j < M.Length; j++)
                {
                    if (M[i] > M[j])
                    {
                        int temp = M[i];
                        M[i] = M[j];
                        M[j] = temp;
                    }
                }
            HienThiMangLenTestBox(M, txtManggoc);
        }

        private void btnGiamdan_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < M.Length; i++)
                for (int j = i + 1; j < M.Length; j++)
                {
                    if (M[i] < M[j])
                    {
                        int temp = M[i];
                        M[i] = M[j];
                        M[j] = temp;
                    }
                }
            HienThiMangLenTestBox(M, txtManggoc);
        }
    }
}
