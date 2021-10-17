using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    namespace Buoi1_Bai6
    {
        public class ThoiGian
        {
            private int Year {get; set;}
            private int Month {get; set;}
            private int Day {get; set;}
            private int Hour {get; set;}
            private int Minute {get; set;}
            private int Second { get; set; }

            public ThoiGian()
            {
                Year = 2014;
                Month = 09;
                Day = 20;
                Hour = 10;
                Minute = 30;
                Second = 40;
            }
            public ThoiGian(int _Year, int _Month, int _Day, int _Hour, int _Minute, int _Second)
            {
                Year = _Year;
                Month = _Month;
                Day = _Day;
                Hour = _Hour;
                Minute = _Minute;
                Second = _Second;
            }
            public ThoiGian(int _Day, int _Month, int _Year)
            {
                Day = _Day;
                Month = _Month;
                Year = _Year;
            }
            public ThoiGian(ThoiGian tg)
            {
                Year = tg.Year;
                Month = tg.Month;
                Day = tg.Day;
                Hour = tg.Hour;
                Minute = tg.Minute;
                Second = tg.Second;
            }
            public ThoiGian(DateTime tg)
            {
                Year = tg.Year;
                Month = tg.Month;
                Day = tg.Day;
                Hour = tg.Hour;
                Minute = tg.Minute;
                Second = tg.Second;
            }
            public void Hien()
            {
                Console.WriteLine("\tDay: {0}/{1}/{2}", Day, Month, Year);
                Console.WriteLine("\tHour: {0}:{1}:{2}", Hour, Minute, Second);
            }
        }
    }
