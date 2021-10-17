using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi5_Bai7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int [] arr = new int [100];
        int sopt = 0;
        private void TaoMang(string ds)
        {
            string[] tach = ds.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < tach.Length; i++)
            {
                arr[sopt++] = int.Parse(tach[i]);
            }

        }
        private string HienThi()
        {
            string s = "";
            for (int i = 0; i < sopt; i++)
            {
                s += arr[i] + " ";
            }
            return s;
        }
        bool flag = true;
        private void btnXuatMang_Click(object sender, EventArgs e)
        {
            
            string ds = txtNhap.Text;
            if (ds == "")
            {
                MessageBox.Show("Hãy nhập giá trị mảng", "Thông báo"); return;
            }
            TaoMang(ds);
            if (flag == true)
            {
                flag = false;
                txtKetQua.Text = HienThi().ToString();
            }
            if (txtKetQua.Text != "")
            {
                groupTong.Enabled = true;
                groupMinMax.Enabled = true;
                groupSapXep.Enabled = true;
                groupThayThe.Enabled = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            groupTong.Enabled = false;
            groupMinMax.Enabled = false;
            groupSapXep.Enabled = false;
            groupThayThe.Enabled = false;
            txtKetQua.ReadOnly = true;
        }
        private int TongMang()
        {
            int sum = 0;
            for (int i = 0; i < sopt; i++)
            {
                sum += arr[i];
            }
            return sum;
        }
        private int TongChan()
        {
            int sum = 0;
            for (int i = 0; i < sopt; i++)
            {
                if (arr[i] % 2 == 0) sum += arr[i];
            }
            return sum;
        }
        private int TongLe()
        {
            int sum = 0;
            for (int i = 0; i < sopt; i++)
            {
                if (arr[i] % 2 != 0) sum += arr[i];
            }
            return sum;
        }
        private void btnTong_Click(object sender, EventArgs e)
        {
            txtTong.Text = TongMang().ToString();
            txtTongChan.Text = TongChan().ToString();
            txtTongLe.Text = TongLe().ToString();
        }
        private int TimMin()
        {
            int min = arr[0];
            for (int i = 0; i < sopt; i++)
            {
                if (min > arr[i]) min = arr[i];
            }
            return min;
        }
        private int TimMax()
        {
            int max = arr[0];
            for (int i = 0; i < sopt; i++)
            {
                if (max < arr[i]) max = arr[i];
            }
            return max;
        }
        private void btnTim_Click(object sender, EventArgs e)
        {
            txtMax.Text = TimMax().ToString();
            txtMin.Text = TimMin().ToString();
        }

        private void btnSapXep_Click(object sender, EventArgs e)
        {
            if (radXepGiam.Checked)
            {
                Array.Sort(arr, 0, sopt);
                Array.Reverse(arr, 0 ,sopt);
                

            }
            if(radXepTang.Checked){
                Array.Sort(arr, 0, sopt);
                
            }
            txtKetQua.Text = HienThi().ToString();
        }

        private void btnLamLai_Click(object sender, EventArgs e)
        {
            flag = true;
            txtNhap.ResetText();
            txtKetQua.ResetText();
        }

        private void btnThayThe_Click(object sender, EventArgs e)
        {
            int vt = int.Parse(txtViTri.Text);
            string s = txtKetQua.Text.Replace(arr[vt].ToString(), txtSo.Text);
            txtKetQua.Text = s;
        }
       
        

        
    }
}
