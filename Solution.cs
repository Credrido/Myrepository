using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Programe
    {
        static void Main(string[] args)
        {
            Onedimensional Array = new Onedimensional();
        }
    }
    class Onedimensional
    {
        public int Length1;
        public int[]Create()
        {
            Console.WriteLine("Введите длину массива:");

            int Length = int.Parse(Console.ReadLine());

            int[] array = new int[Length];

            return array;
        }

        public int[] Filling(int[] array)
        {
            bool randif = true;

            Console.WriteLine("Хотите заполнить массив сами? Введите Да или Нет");

            if (Console.ReadLine() == "Нет")
            {
                randif = false;
            }

            if (randif == true)
            {
                int[] array1 = Createarray(array,Length1);
                return array1;
            }
            else
            {
                int[] array1 = Createrandomarray(array,Length1);
                return array1;
            }
        }

        private int[] Createarray(int[] array1,int Length)
        {
            for (int i = 0; i < Length; i++)
            {
                Console.WriteLine("Введите элемент массива:");

                array1[i] = int.Parse(Console.ReadLine());
            }
            return array1;

        }

        private int[] Createrandomarray(int[] array1, int Length)
        {
            Random random = new Random();

            for (int i = 0; i < Length; i++)
            {
                array1[i] = random.Next(-1000, 1000);
            }
            return array1;
        }

        public decimal Getmiddle(int[] array1)
        {
            decimal sum = 0;

            for (int i = 0; i < array1.Length; i++)
            {
                sum += array1[i];

            }
            return sum / array1.Length;
        }

        public void Print(int[] array1)
        {
            for (int i = 0; i < array1.Length; i++)
            {
                Console.Write($"{array1[i]}, ");
            }
        }
    }

    class Twodimensional
    {

    }
}
