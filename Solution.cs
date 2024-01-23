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

            Console.WriteLine("Введите длину массива:");

            int Length = int.Parse(Console.ReadLine());

            Console.WriteLine();

            int[] array = new int[Length];

            bool randif = true;

            Console.WriteLine("Хотите заполнить массив сами? Введите Да или Нет");

            if (Console.ReadLine() == "Нет")
            {
                randif = false;
            }

            if (randif == true)
            {
                Array.Createarray(array,Length);
            }
            else
            {
                Array.Createrandomarray(array, Length);
            }

            Array.Print(array);

            Console.WriteLine();

            Console.WriteLine();

            Array.Getmiddle(array);

            Array.Deletebigger100(array,Length);
        }
    }
}
