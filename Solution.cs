using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }

    class Onedimensional
    {
        public void Massive1(string[] args)
        {
            Console.WriteLine("Хотите заполнить массив сами?");

            int Length = int.Parse(Console.ReadLine());

            int[] array = new int[Length];

            bool rand = false;

            int sum = 0;

            if (Console.ReadLine() == "Да")
            {
                rand = true;
            }
            if (rand == true)
            {
                for (int i = 0; i < Length; i++)
                {
                    Console.WriteLine("Введите элемент массива: ");
                    array[i] = int.Parse(Console.ReadLine());

                    sum += array[i];
                }
            }

            Console.WriteLine("Ваш массив: ");

            Console.WriteLine(array);

            int averagevalue = sum / Length;

            Console.WriteLine("Среднее значение массива: " + averagevalue);

            Console.WriteLine("Исправленный массив: ");

            for (int i = 0; i < Length; i++)
            {
                if (array[i] < 100 && array[i] > -100)
                {
                    Console.WriteLine(array[i]);
                }
            }
        }
    }
}
