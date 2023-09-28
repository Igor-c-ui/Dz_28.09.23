using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tumakov_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime date = new DateTime();
            string n, n1;
            double day;
            int year;

            //Упр.2_1 Вводится номер дня, выводится день и месяц в году
            Console.WriteLine("Упр.2_1");
            Console.Write("Введите число от 1 до 365: ");
            n = Console.ReadLine();
            double.TryParse(n, out day);
            date = date.AddDays(day - 1);
            Console.WriteLine("{0:M}", date);
            date = date.AddDays(-day + 1);

            //Упр.2_2 К 2_1 дополняется проверка
            Console.WriteLine("Упр.2_2");
            Console.Write("Введите число от 1 до 365: ");
            n = Console.ReadLine();
            double.TryParse(n, out day);
            date = date.AddDays(day - 1);
            if (day > 365) 
            {
                Console.WriteLine("Число больше 365!");
            }
            else if (day < 1) 
            {
                Console.WriteLine("Число меньше 1!");
            }
            else Console.WriteLine("{0:M}", date);
            date = date.AddDays(-day + 1);

            //Д.з.1 К 2_2 дополняется проверка на "високосность" года
            Console.WriteLine("Д.з.1");
            Console.Write("Введите год: ");
            n1 = Console.ReadLine();
            int.TryParse(n1, out year);
            Console.Write("Введите число от 1 до 365: ");
            n = Console.ReadLine();
            double.TryParse(n, out day);
            date = date.AddDays(day-1);
            date = date.AddYears(year);
            if (year % 100 == 0)
            {
                if (year % 400 == 0)
                {
                    Console.WriteLine($"{year} год - високосный");
                }
                else Console.WriteLine($"{year} год - невисокосный");
            }
            else if (year % 4 == 0)
            {
                Console.WriteLine($"{year} год - високосный");
            }
            else Console.WriteLine($"{year} год - невисокосный");
            if (day > 365)
            {
                Console.WriteLine("Число больше 365!");
            }
            else if (day < 1)
            {
                Console.WriteLine("Число меньше 1!");
            }
            else Console.WriteLine(date);
        }
    }
}
