using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Buoi1_Bai8
{
    public class TamGiac
    {
        private int Canh1 { get; set; }
        private int Canh2 { get; set; }
        private int Canh3 { get; set; }
        private int loai { get; set; }
        public TamGiac()
        {
            Canh1 = 2;
            Canh2 = 3;
            Canh3 = 5;
        }
        public TamGiac(int a, int b, int c)
        {
            Canh1 = a;
            Canh2 = b;
            Canh3 = c;
        }
        public int Chuvi
        {
            get
            {
                return Canh1 + Canh2 + Canh3;
            }
        }

        public float DienTich
        {
            get
            {
                float p = (Canh1 + Canh2 + Canh3)/2;
                float dt = (float)Math.Sqrt(p * (p - Canh1) * (p - Canh2) * (p - Canh3));
                return dt;
            }
        }
        public void NhapTamGiac()
        {
            Console.Write("Nhap canh 1: ");
            Canh1 = int.Parse(Console.ReadLine());

            Console.Write("Nhap canh 2: ");
            Canh2 = int.Parse(Console.ReadLine());

            Console.Write("Nhap canh 3: ");
            Canh3 = int.Parse(Console.ReadLine());
            TimTamGiac();
        }
        public int TimTamGiac()
        {
            
                int a = Canh1;
                int b = Canh2;
                int c = Canh3;
                loai = 5; //thuong
                if (a == b & b == c) //can
                {   
                    
                     loai = 1;
                    if (a * a + b * b == c * c || a * a + c * c == b * b || b * b + c * c == a * a)
                    {
                        loai++;
                    }
                }
                else if (a == b || a == c || b == c) //deu
                {
                    loai = 3;
                }
                else if (a * a + b * b == c * c || a * a + c * c == b * b || b * b + c * c == a * a)
                {
                    loai--;
                }
                return loai;
            }
            
        public string LoaiTamGiac
        {
            get
            {
                string temp = "";
                if (loai == 1)
                    temp = "Tam giac deu";
                else if (loai == 2)
                    temp = "Tam giac vuong can";
                else if (loai == 3)
                    temp = "Tam giac can";
                else if (loai == 4)
                    temp = "Tam giac vuong";
                else if(loai == 5)
                {
                    temp = "Tam giac thuong";   
                }
                return temp;
            }
        }
        public void HienThiTamGiac()
        {
            Console.WriteLine("{0, -15}{1, -15}{2, -15}{3, -15}{4, -15}{5, -15}", Canh1, Canh2, Canh3, Chuvi, DienTich,LoaiTamGiac);
        }
        
    }
}
