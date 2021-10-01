using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TG
{
    public class TamGiac
    {
        private int Canh1, Canh2, Canh3;
        private float Chuvi;
        private float DienTich;
        private int LoaiTamGiac;
        public void Nhap()
        {
            Console.WriteLine(" Nhap canh thu nhat : ");
            Canh1 = int.Parse(Console.ReadLine());
            Console.WriteLine(" Nhap canh thu hai : ");
            Canh2 = int.Parse(Console.ReadLine());
            Console.WriteLine(" Nhap canh thu ba : ");
            Canh3 = int.Parse(Console.ReadLine());
            TinhChuVi(Canh1,Canh2,Canh3);
            TinhDienTich(Canh1, Canh2, Canh3);
        }
        public void Xuat()
        {
            Console.WriteLine(" Chieu dai 3 canh lan luot la  : "+Canh1+" "+Canh2+" "+Canh3);
            Console.WriteLine(" chu vi " + Chuvi);
            Console.WriteLine(" Dien Tich la : " + DienTich);
        }

        public TamGiac()
        {
            Canh1 = 2;
            Canh2 = 3;
            Canh3 = -5;
            
        }

        public TamGiac(int canh1, int canh2, int canh3)
        {
            Canh1 = canh1;
            Canh2 = canh2;
            Canh3 = canh3;
        }
        public float TinhChuVi(int a, int b, int c)
        {
            Chuvi = a + b + c;
            return Chuvi;
        }
        public float TinhDienTich(int a, int b, int c)
        {
            float p = Chuvi/ 2;
            DienTich = (float)Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            return DienTich;
        }
        public int TimTamGiac()
        {
            int a = Canh1;
            int b = Canh2;
            int c = Canh3;
            int Loai = 5;
            if (a == b & b == c)
            {
                Loai = 1;
                return Loai;
            }
            if (a == b || a == c || b == c)
            {
                Loai = 3;

                if (a * a + b * b == c * c || a * a + c * c == b * b || b * b + c * c == a * a)
                {
                    Loai--;
                }
                return Loai;
            }
            if (a * a + b * b == c * c || a * c + c * c == b * b || b * b + c * c == a * a)
            {
                Loai = 4;
                return Loai;
            }
            LoaiTamGiac = Loai;
            return LoaiTamGiac;
        }
        public void TimLoaiTG(int n)
        {

            switch (n)
            {
                case 1:
                    Console.WriteLine(" Tam giac deu.");
                    break;
                case 2:
                    Console.WriteLine("Tam giac vuong can.");
                    break;
                case 3:
                    Console.WriteLine("Tam giac vuong .");
                    break;
                case 4:
                    Console.WriteLine("Tam giac can.");
                    break;
                default:
                    Console.WriteLine("Tam giac thuong.");
                    break;
            }
        }
    }
    
    
}

