using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    class Uneven
    {
        private int[][] array;

        public Uneven(int length,bool randif3)
        {
            array = new int[length][];

            if(randif3)
            {
                Fillarray();
            }
            else
            {
                Fillarrayrandomly();
            }
        }

        public void Createarray(int length,bool randif3)
        {
            array = new int[length][];

            if (randif3)
            {
                Fillarray();
            }
            else
            {
                Fillarrayrandomly();
            }
        }
        public void Fillarray()
        {
            Console.WriteLine();

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"Введите длину массива {i}:");

                int Length = int.Parse(Console.ReadLine());

                Console.WriteLine();

                array[i] = new int[Length];

                for (int l = 0; l < array[i].Length; l++)
                {
                    Console.WriteLine($"Введите элемент массива {i}:");

                    int j = int.Parse(Console.ReadLine());

                    array[i][l] = j;

                    Console.WriteLine();
                }
                Console.WriteLine();
            }
        }

        public void Fillarrayrandomly()
        {
            Random random3 = new Random();

            Console.WriteLine();

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"Введите длину массива {i}:");

                int Length = int.Parse(Console.ReadLine());

                array[i] = new int[Length];

                for (int l = 0; l < array[i].Length; l++)
                {
                    int j = random3.Next(-250, 250);

                    array[i][l] = j;
                }
                Console.WriteLine();
            }
        }
        public void Getmiddle()
        {
            Console.WriteLine();

            decimal sum = 0;

            int counter = 0;

            for (int i = 0; i < array.Length; i++)
            {
                int Len = array[i].Length;

                int summ = array[i].Sum();

                Console.WriteLine($"Среднее значение массива {i}:");

                Console.WriteLine(summ / Len);

                Console.WriteLine();

                counter += array[i].Length;
                for (int j = 0; j < array[i].Length; j++)
                {
                    sum += array[i][j];
                }
            }

            decimal result = sum / counter;

            Console.WriteLine("Среднее значение всего массива:");

            Console.WriteLine(result);

            Console.WriteLine();
        }

        public void Print()
        {
            Console.WriteLine("Исходный массив:");

            for (int i = 0; i < array.Length; i++)
            {
                for (int l = 0; l < array[i].Length; l++)
                {
                    Console.Write($"{array[i][l]} \t");
                }
                Console.WriteLine();
            }
        }
    }
}
