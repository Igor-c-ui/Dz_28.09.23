using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ
{
    internal class Program
    {
        enum Dayofweek :byte
        {
            Понедельник = 1,
            Вторник,
            Среда,
            Четверг,
            Пятница,
            Суббота,
            Воскрресеенье
        }
        static void Main(string[] args)
        {
            //1
            Console.WriteLine("Задание 1. Программа определяет, возрастает ли последовательность");
            int[] numbers = {12, 23, 34, 45, 56, 67, 78, 89, 90, 100};
            bool flag = true;
            for (int i = 0; i < 9; i++) 
            {
                if (numbers[i] > numbers[i + 1])
                {
                    Console.WriteLine($"Последовательность неупорядоченна по возрастанию\nНомер первого элемента, нарушающего последовательность - {i+2}");
                    flag = false;
                    break;
                }
            }
            if (flag)
            {
                Console.WriteLine("Последовательность упорядоченна по возрастанию");
            }

            //2
            Console.WriteLine("Задание 2. Программа получает номер карты, выводит - её достоинство");
            try
            {
                byte card_number;
                Console.Write("Введите порядковый номер игральной карты: ");
                card_number = Convert.ToByte(Console.ReadLine());
                switch (card_number)
                {
                    case 6:
                        Console.WriteLine("Это шестёрка");
                        break;
                    case 7:
                        Console.WriteLine("Это семёрка");
                        break;
                    case 8:
                        Console.WriteLine("Это восьмёрка");
                        break;
                    case 9:
                        Console.WriteLine("Это девятка");
                        break;
                    case 10:
                        Console.WriteLine("Это десятка");
                        break;
                    case 11:
                        Console.WriteLine("Это валет");
                        break;
                    case 12:
                        Console.WriteLine("Это дама");
                        break;
                    case 13:
                        Console.WriteLine("Это король");
                        break;
                    case 14:
                        Console.WriteLine("Это туз");
                        break;
                    default:
                        Console.WriteLine("Вы ввели число меньше 6 или больше 14!");
                        break;
                }
            }
            catch (System.FormatException) 
            {
                Console.WriteLine("Неверные данные!");
            }
            finally
            {
                Console.WriteLine("Всё верно?");
            }

            //3
            Console.WriteLine("Задание 3. Вывод строки в зависимости от введенной");
            string str;

            Console.WriteLine("Jabroni - Patron Tequila\n" +
                              "School Counselor - Anything with Alcohol\n" +
                              "Programmer - Hipster Craft Beer\n" +
                              "Bike Gang Members - Moonshine\n" +
                              "Politician - Your tax dollars\n" +
                              "Rapper - Cristal");

            Console.Write("Введите слово: ");
            str = Console.ReadLine();

            switch (str.ToLower())
            {
                case "jabroni":
                    Console.WriteLine("Patron Tequila");
                    break;
                case "school counselor":
                    Console.WriteLine("Anything with Alcohol");
                    break;
                case "programmer":
                    Console.WriteLine("Hipster Craft Beer");
                    break;
                case "bike gang member":
                    Console.WriteLine("Moonshine");
                    break;
                case "politician":
                    Console.WriteLine("Your tax dollars");
                    break;
                case "rapper":
                    Console.WriteLine("Cristal");
                    break;
                default:
                    Console.WriteLine("Beer");
                    break;
            }

            //4
            Console.WriteLine("Задание 4. Вводится число, выводится день недели");
            Console.Write("Введите номер дня недели: ");
            byte value;
            value = byte.Parse(Console.ReadLine());
            Dayofweek day_Of_Week;
            
            if (Enum.IsDefined(typeof(Dayofweek), value))//Проверка на то, что введенное число есть в Dayofweek
            {   
                day_Of_Week = (Dayofweek)value;
                Console.WriteLine(day_Of_Week);
            }
            else
            {
                Console.WriteLine("Введены неверные данные!");
            }
        }
    }
}
