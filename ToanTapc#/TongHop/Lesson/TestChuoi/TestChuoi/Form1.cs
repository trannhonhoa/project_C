using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestChuoi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSoKiTuTrongChuoi_Click(object sender, EventArgs e)
        {
            txtDuLieuKetQua.Text = txtDuLieuGoc.Text.Length+"";
   
        }

        private void btnChuInHoa_Click(object sender, EventArgs e)
        {
            txtDuLieuKetQua.Text = txtDuLieuGoc.Text.ToUpper();
        }

        private void btnChuInThuong_Click(object sender, EventArgs e)
        {
            txtDuLieuKetQua.Text = txtDuLieuGoc.Text.ToLower();
        }

        private void btnDemTuInHoa_Click(object sender, EventArgs e)
        {
            int dem = 0;
            char[] arr = txtDuLieuGoc.Text.ToCharArray();
            for (int i = 0; i < arr.Length; i++)
            {
                if (char.IsUpper(arr[i]))
                    dem++;
            }
            txtDuLieuKetQua.Text = dem + "";
        }

        private void btnDemKiTuInThuong_Click(object sender, EventArgs e)
        {
            string s = txtDuLieuGoc.Text;
            int dem = 0;
            foreach (char c in s)
            {
                if (char.IsLower(c))
                    dem++;
            }
            txtDuLieuKetQua.Text = dem + ""; 
        }

        private void btnDemKiTuLaSo_Click(object sender, EventArgs e)
        {
            string s = txtDuLieuGoc.Text;
            int dem = 0;
            foreach (char c in s)
            {
                if (char.IsDigit(c))
                    dem++;
            }
            txtDuLieuKetQua.Text = dem + ""; 
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string s = txtDuLieuGoc.Text;
            List<char> s1 = s.Reverse().ToList();
            txtDuLieuKetQua.Text = " ";
            foreach(char c in s1){
                txtDuLieuKetQua.Text += c;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string s = txtDuLieuGoc.Text.Trim();
            string[] arr = s.Split(new char[]{' '}, StringSplitOptions.RemoveEmptyEntries);
            txtDuLieuKetQua.Text = "";
            foreach(string c in arr){
                txtDuLieuKetQua.Text+=c+ " ";
            }
            txtDuLieuKetQua.Text = txtDuLieuKetQua.Text.Trim();

        }

        private void btnViTriXhDt_Click(object sender, EventArgs e)
        {
            int vt = txtDuLieuGoc.Text.IndexOf(txtViTriXhDt.Text);
            txtDuLieuKetQua.Text = vt + "";
        }

        private void btnViTriXhC_Click(object sender, EventArgs e)
        {
            int vt = txtDuLieuGoc.Text.LastIndexOf(txtViTriXhDt.Text);
            txtDuLieuKetQua.Text = vt + "";
        }

        private void btnDemSoLanXuatHien_Click(object sender, EventArgs e)
        {
            int dem = 0;
            string s = txtDuLieuGoc.Text;
            int vt = s.IndexOf(txtDemSoLanXuatHien.Text);
            while (vt != -1)
            {
                dem++;
                s = s.Substring(vt + txtDemSoLanXuatHien.Text.Length);
                vt = s.IndexOf(txtDemSoLanXuatHien.Text);
            }
            txtDuLieuKetQua.Text = dem + "";
        }

        private void btnTachTu_Click(object sender, EventArgs e){
        
            char [] arrKT = txtTachTu.Text.ToCharArray();
            string[] arrword = txtDuLieuGoc.Text.Split(arrKT);
            txtDuLieuKetQua.Text = " ";
            foreach (string s in arrword)
            {
                txtDuLieuKetQua.Text += s + "\r\n";
            }
        }

        private void btnThayDoiChuoiCon_Click(object sender, EventArgs e)
        {
            txtDuLieuKetQua.Text = txtDuLieuGoc.Text.Replace(TextThayDoiChuoiCon.Text,textTuNew.Text);
        }

        private void btnXoaChuoiCon_Click(object sender, EventArgs e)
        {
            string s =  txtDuLieuGoc.Text;
            int vt = s.IndexOf(txtXoaChuoiCon.Text);
           
            while (vt != -1)
            {
                s = s.Remove(vt, txtXoaChuoiCon.Text.Length);

                vt = s.IndexOf(txtXoaChuoiCon.Text);

            }   
            txtDuLieuKetQua.Text = s;
        }

        private void bnChenChuoi_Click(object sender, EventArgs e)
        {
            string s = txtDuLieuGoc.Text;
            s.Insert(int.Parse(txtViTriChenChuoi.Text), txtChenChuoi.Text);
            txtDuLieuKetQua.Text = s;
        }

        

        

        

        
    }
}
