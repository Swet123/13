using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp69
{
    class Program
    {
        static void Main(string[] args)
        {
       int k = 0;
            int x;
            Console.WriteLine("Введите X");
            while (!int.TryParse(Console.ReadLine(), out x))
            {
                Console.WriteLine("Введено не число");
            }
            int y;
            Console.WriteLine("Введите y");
            while (!int.TryParse(Console.ReadLine(), out y))
            {
                Console.WriteLine("Введено не число");
            }
            int[,] mas = new int[x, y];
            Random random = new Random();
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    mas[i, j] = random.Next(1, 10);
                }
            }
            Console.WriteLine("Вывод массива случайными числами");
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    Console.Write(mas[i, j] + "\t");
                }
                Console.WriteLine();
            }
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    if (mas[i, j] % 2 == 0)
                        k++;

                }
            }
            Console.WriteLine("Количество элементов кратных двум:   {0}", k);
            Console.ReadKey();
        }
    }
}


