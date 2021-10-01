using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi1_Bai9
{
    class Phuongtrinhbac2
    {
        private int Soa { get; set; }
        private int Sob { get; set; }
        private int Soc { get; set; }
        private int Del { get; set; }
        public Phuongtrinhbac2() { }
        public Phuongtrinhbac2(int a, int b, int c)
        {
            Soa = a;
            Sob = b;
            Soc = c;
        }
        public void Nhap()
        {
            Console.WriteLine(" Nhap so a : ");
            Soa = int.Parse(Console.ReadLine());
            Console.WriteLine(" Nhap so b : ");
            Sob = int.Parse(Console.ReadLine());
            Console.WriteLine(" Nhap so c : ");
            Soc = int.Parse(Console.ReadLine());
            Delta();
        }
        public int Delta()
        {
            return Del = Sob * Sob - 4 * Soa * Soc;
            
        }
        public void TinhNghiem()
        {
            if (Del >= 0)
            {
                float x1 = (float)(-Sob + Math.Sqrt(Del) / (2 * Soa));
                float x2 = ((float)(-Sob - Math.Sqrt(Del) / (2 * Soa)));
                Console.WriteLine(" Nghiem cua phuong trinh la " + x1 + " " + x2);
            }
            else
            {
                Console.WriteLine(" Phuong trinh vo nghiem ");
            }
        } 
    }
}
