using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KarpovAA.Sprint1.Task6.V18.Lib;

namespace Tyuiu.KarpovAA.Sprint1.Task6.V18
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Карпов А. А. | ИИПб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Работа со строками класс String                                   *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #18                                                             *");
            Console.WriteLine("* Выполнил: Карпов Андрей Андреевич | ИИПб-23-1                           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу: пользователь вводит текст. Проверить, что строка    *");
            Console.WriteLine("* является символьным представлением натурального числа '122', '34' и т.д.*");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int res;

            if 
                 (Int32.TryParse(Console.ReadLine(), out res))
                 Console.WriteLine("* Введенная строка является символьным представлением натурального числа. *");
            else 
                 Console.WriteLine("* Введенная строка не является символьным представлением натурального числа. *");
                 Console.ReadKey();
        }
    }
}

