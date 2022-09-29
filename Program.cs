// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba30_09
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задача 1. Перевести число в дату");
            Console.WriteLine("Введите год:");
            int god = Convert.ToInt32(Console.ReadLine());
            bool visocos;
            if (god % 4 == 0 && god % 100 != 0 && god % 400 != 0)
            {
                Console.WriteLine("Введите число от 1 до 366:");
                visocos = true;
            }
            else
            {

                Console.WriteLine("Введите число от 1 до 365:");
                visocos = false;
            }

            int x = Convert.ToInt32(Console.ReadLine());
            if (visocos == false)
            {
                if (x < 1 || x > 365)
                { Console.WriteLine("Ошибка!"); }
                else
                {
                    if (1 <= x && x <= 31)
                    { Console.WriteLine($"{x} января"); };
                    if (32 <= x && x <= 59)
                    { Console.WriteLine($"{x - 31} февраля"); };
                    if (60 <= x && x <= 90)
                    { Console.WriteLine($"{x - 59} марта"); };
                    if (91 <= x && x <= 120)
                    { Console.WriteLine($"{x - 90} апреля"); };
                    if (121 <= x && x <= 151)
                    { Console.WriteLine($"{x - 120} мая"); };

                    if (152 <= x && x <= 182)
                    { Console.WriteLine($"{x - 151} июня"); };

                    if (183 <= x && x <= 212)
                    { Console.WriteLine($"{x - 182} июля"); };

                    if (213 <= x && x <= 243)
                    { Console.WriteLine($"{x - 212} августа"); };

                    if (244 <= x && x <= 273)
                    { Console.WriteLine($"{x - 243} сентября"); };

                    if (274 <= x && x <= 304)
                    { Console.WriteLine($"{x - 273} октября"); };

                    if (305 <= x && x <= 334)
                    { Console.WriteLine($"{x - 304} ноября"); };

                    if (335 <= x && x <= 365)
                    { Console.WriteLine($"{x - 334} декабря"); };
                }
            }
            else
            {
                if (x < 1 || x > 366)
                { Console.WriteLine("Ошибка!"); }
                else
                {
                    if (1 <= x && x <= 31)
                    { Console.WriteLine($"{x} января"); };
                    if (32 <= x && x <= 60)
                    { Console.WriteLine($"{x - 31} февраля"); };
                    if (61 <= x && x <= 91)
                    { Console.WriteLine($"{x - 60} марта"); };
                    if (92 <= x && x <= 121)
                    { Console.WriteLine($"{x - 91} апреля"); };
                    if (122 <= x && x <= 152)
                    { Console.WriteLine($"{x - 121} мая"); };

                    if (153 <= x && x <= 183)
                    { Console.WriteLine($"{x - 152} июня"); };

                    if (184 <= x && x <= 213)
                    { Console.WriteLine($"{x - 183} июля"); };

                    if (214 <= x && x <= 244)
                    { Console.WriteLine($"{x - 213} августа"); };

                    if (245 <= x && x <= 274)
                    { Console.WriteLine($"{x - 244} сентября"); };

                    if (275 <= x && x <= 305)
                    { Console.WriteLine($"{x - 274} октября"); };

                    if (306 <= x && x <= 335)
                    { Console.WriteLine($"{x - 305} ноября"); };

                    if (336 <= x && x <= 366)
                    { Console.WriteLine($"{x - 335} декабря"); };
                }
            }







        }
    }
}

