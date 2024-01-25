using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    class Onedimensional
    {
        private int[] array;
        public Onedimensional(int length, bool randif)
        {
            array = new int[length];

            if (randif)
            {
                Fillarray();
            }
            else
            {
                Fillarrayrandomly();
            }
        }

        public void Createarray(int length, bool randif)
        {
            array = new int[length];

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
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Введите элемент массива:");

                array[i] = int.Parse(Console.ReadLine());

                Console.WriteLine();
            }
            Console.WriteLine();

        }

        private void Fillarrayrandomly()
        {
            Random random = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(-200, 200);
            }
            Console.WriteLine();
        }

        public void Getmiddle()
        {
            decimal sum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }

            decimal result = sum / array.Length;

            Console.WriteLine("Среднее значение массива:");

            Console.WriteLine(result);

            Console.WriteLine();
        }

        public void Deletebigger100()
        {
            Console.WriteLine("Массив без чисел больше 100 по модулю:");
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 100 && array[i] > -100)
                {
                    Console.Write($"{array[i]}, ");
                }
            }

            Console.WriteLine();
        }

        public void Print()
        {
            Console.WriteLine("Исходный массив:");

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]}, ");
            }
        }
    }
}
