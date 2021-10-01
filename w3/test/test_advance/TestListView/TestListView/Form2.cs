using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestListView
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        List<DanhMuc> khohang = new List<DanhMuc>();
        private void Form2_Load(object sender, EventArgs e)
        {
            DanhMuc bia = new DanhMuc();
            bia.Ma = "dm1";
            bia.Ten = "Nhom bia";
            khohang.Add(bia);

            SanPham biaken = new SanPham();
            biaken.Ma = "sp1";
            biaken.Ten = "Heniken";
            biaken.Gia = 50;
            bia.ThemSanPham(biaken);

            SanPham bia33 = new SanPham();
            bia33.Ma = "sp2";
            bia33.Ten = "Bia heniken";
            bia33.Gia = 100;
            bia.ThemSanPham(bia33);

            // ruou

            DanhMuc ruou = new DanhMuc();
            ruou.Ma = "dm2";
            ruou.Ten = "Nhom ruou";
            khohang.Add(ruou);

            SanPham voka = new SanPham();
            voka.Ma = "sp1";
            voka.Ten = "Voka";
            voka.Gia = 50;
            ruou.ThemSanPham(voka);

            foreach (DanhMuc dm in khohang)
            {
                ListViewGroup lvg = new ListViewGroup(dm.Ten);
                listView1.Groups.Add(lvg);
                foreach (SanPham sp in dm.SanPhams)
                {
                    ListViewItem lvi = new ListViewItem(sp.Ma);
                    lvi.SubItems.Add(sp.Ten);
                    lvi.SubItems.Add(sp.Gia + "");
                    lvi.Group = lvg;
                    listView1.Items.Add(lvi);
                }
            }
        }
    }
}
