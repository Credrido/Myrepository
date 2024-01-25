using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задачи на одномерный массив");

            Console.WriteLine();

            Console.WriteLine("Введите длину массива:");

            int length = int.Parse(Console.ReadLine());

            bool randif = false;

            Console.WriteLine();

            Console.WriteLine("Хотите заполнить массив сами? Введите Да или Нет");

            if (Console.ReadLine() == "Да")
            {
                randif = true;
            }

            Onedimensional Array = new Onedimensional(length,randif);

            Array.Print();

            Console.WriteLine();

            Console.WriteLine();

            Array.Getmiddle();

            Array.Deletebigger100();




            Console.WriteLine("Задачи на двумерный массив");

            Console.WriteLine();

            Console.WriteLine("Введите кол-во строк:");

            int rows = int.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("Введите кол-во столбцов:");

            int columns = int.Parse(Console.ReadLine());

            Console.WriteLine();

            bool randif2 = false;

            Console.WriteLine();

            Console.WriteLine("Хотите заполнить массив сами? Введите Да или Нет");

            if (Console.ReadLine() == "Да")
            {
                randif2 = true;
            }

            Twodimensional Array2 = new Twodimensional(rows,columns,randif2);

            Array2.Print();

            Console.WriteLine();

            Console.WriteLine();

            Array2.Getmiddle();

            Array2.Print2();



            Console.WriteLine("Задачи на неровный массив");

            Console.WriteLine();

            Console.WriteLine("Введите кол-во массивов:");

            int Len = int.Parse(Console.ReadLine());

            Console.WriteLine();

            bool randif3 = false;

            Console.WriteLine();

            Console.WriteLine("Хотите заполнить массив сами? Введите Да или Нет");

            if (Console.ReadLine() == "Да")
            {
                randif3 = true;
            }

            Uneven Array3 = new Uneven(Len, randif3);

            Array3.Print();

            Console.WriteLine();

            Console.WriteLine();

            Array3.Getmiddle();        }
    }
}