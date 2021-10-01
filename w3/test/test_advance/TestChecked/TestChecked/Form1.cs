using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestChecked
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            checkedListBox1.Items.Add("An Giang");
            checkedListBox1.Items.Add("Bac Lieu");
            checkedListBox1.Items.Add("Can Tho");
            checkedListBox1.Items.Add("Ca Mau");
            checkedListBox1.Items.AddRange(new string[] { "Ho Noi", "HCM" });

        }

        private void btnMoveRight_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                if (checkedListBox1.GetItemChecked(i))
                {
                    checkedListBox2.Items.Add(checkedListBox1.Items[i]);
                    checkedListBox1.Items.RemoveAt(i);
                }
            }
        }

        private void btnMoveRightAll_Click(object sender, EventArgs e)
        {
            checkedListBox2.Items.AddRange(checkedListBox1.Items);
            checkedListBox1.Items.Clear();
        }

        private void btnMoveLeft_Click(object sender, EventArgs e)
        {
            CheckedListBox.CheckedItemCollection dsChecked = checkedListBox2.CheckedItems;
            foreach(var x in dsChecked){
                checkedListBox1.Items.Add(x);
            }
            while (dsChecked.Count > 0)
            {
                checkedListBox2.Items.Remove(dsChecked[0]);
            }
        }

        private void btnMoveLeftAll_Click(object sender, EventArgs e)
        {
            checkedListBox1.Items.AddRange(checkedListBox2.Items);
            checkedListBox2.Items.Clear();
        }
    }
}
