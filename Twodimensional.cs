using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    class Twodimensional
    {
        private int[,] array;
        public Twodimensional(int rows, int columns, bool randif2)
        {
            array = new int[rows, columns];

            if (randif2)
            {
                Fillarray();
            }
            else
            {
                Fillarrayrandomly();
            }
        }
        public void Createarray(int rows, int columns,bool randif)
        {
            array = new int[rows, columns];

            if (randif)
            {
                Fillarray();
            }
            else
            {
                Fillarrayrandomly();
            }
            
        }
        private void Fillarray()
        {
            Console.WriteLine();
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.WriteLine("Введите элемент массива:");

                    array[i, j] = int.Parse(Console.ReadLine());

                    Console.WriteLine();
                }
            }
            Console.WriteLine();
        }

        private void Fillarrayrandomly()
        {
            Random random = new Random();

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = random.Next(-250, 250);
                }
            }
            Console.WriteLine();
        }

        public void Getmiddle()
        {
            decimal sum = 0;

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    sum += array[i, j];
                }
            }

            decimal result = sum / (array.GetLength(0) * array.GetLength(1));

            Console.WriteLine("Среднее значение массива:");

            Console.WriteLine(result);

            Console.WriteLine();
        }

        public void Print()
        {
            Console.WriteLine("Исходный массив:");

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write($"{array[i, j]} \t");
                }
                Console.WriteLine();
            }
        }

        public void Print2()
        {
            Console.WriteLine("Массив с перевёрнутыми чётными строками:");

            for (int i = 0; i < array.GetLength(0); i++)
            {
                if ((i + 1) % 2 == 0)
                {
                    for (int j = array.GetLength(1); j > 0; j--)
                    {
                        Console.Write($"{array[i, j - 1]} \t");
                    }
                }
                else
                {
                    for (int k = 0; k < array.GetLength(1); k++)
                    {
                        Console.Write($"{array[i, k]} \t");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

    }

}
