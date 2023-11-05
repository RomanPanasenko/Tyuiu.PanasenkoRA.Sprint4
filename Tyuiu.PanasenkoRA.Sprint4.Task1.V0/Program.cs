using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.PanasenkoRA.Sprint4.Task1.V0.Lib;

namespace Tyuiu.PanasenkoRA.Sprint4.Task1.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнил: Панасенко Р.А. | ПКТб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Обработка структурных типов                                       *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #18                                                             *");
            Console.WriteLine("* Выполнил: Панасенко Роман Анатольевич | ПКТб-23-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 16 элементов заполненный         *");
            Console.WriteLine("*  значениями с клавиатуры в диапазоне от 3 до 9 подсчитать сумму нечетных*");
            Console.WriteLine("*  элементов массива.  С клавиатуры: 7, 6, 9, 8, 9, 7, 4, 7, 8, 5, 6, 3,  *");
            Console.WriteLine("*  9, 7, 9, 7                                                             *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            
            int len;
            Console.WriteLine("Введите количество элементов массива");
            len = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[len];
            for (int i = 0; i < len; i++)
            {
                Console.WriteLine("Введите значение " + i + " элемента массива: ");
                array[i] = Convert.ToInt32(Console.ReadLine());
                if (array[i] < 3 && array[i] > 9)
                {
                    Console.WriteLine("Введено число не из указанного диапазона");
                    break;
                }
            }
            Console.WriteLine("Массив:");
            for (int i = 0; i < len; i++)
            {
                Console.WriteLine(array[i] + "\n");
            }
            Console.WriteLine();
            Console.WriteLine();



            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            int res = ds.Calculate(array);
            Console.WriteLine(res);
            Console.ReadKey();

        }
    }
}
