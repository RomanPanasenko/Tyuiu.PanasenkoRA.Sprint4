using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.PanasenkoRA.Sprint4.Task2.V0.Lib;

namespace Tyuiu.PanasenkoRA.Sprint4.Task2.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнил: Панасенко Р.А. | ПКТб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Обработка структурных типов                                       *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #7                                                              *");
            Console.WriteLine("* Выполнил: Панасенко Роман Анатольевич | ПКТб-23-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 12 элементов заполненный         *");
            Console.WriteLine("* случайными в диапазоне от 4 до 9 подсчитать сумму четных элементов      *");
            Console.WriteLine("* массива.                                                                *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            int[] array = new int[12];
            for (int i = 0; i < 12; i++)
            {
                array[i] = rnd.Next(4, 10);
            }
            Console.WriteLine("Массив: ");
            for (int i = 0; i < 12; i++)
            {
                Console.WriteLine(array[i] + "\t");
            }
            


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            int res = ds.Calculate(array);
            Console.WriteLine("Сумма чётных чисел = " + res);
            Console.ReadKey();
        }
    }
}
