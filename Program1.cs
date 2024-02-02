using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayBase[] arrays = new ArrayBase[3];

            Console.WriteLine("Хотите заполнить массивы сами? Введите Да или Нет");

            if(Console.ReadLine() == "Да")
            {
                Console.WriteLine("Задачи на одномерный массив");

                arrays[0] = new Onedimensional(true);

                Console.WriteLine("Задачи на двумерный массив");

                arrays[1] = new Twodimensional(true);

                Console.WriteLine("Задачи на неровный массив");

                arrays[2] = new Uneven(true);
                foreach (ArrayBase array in arrays)
                {
                    array.Print();
                    array.Getmiddle();
                }
            }

            else
            {
                arrays[0] = new Onedimensional(false);
                arrays[1] = new Twodimensional(false);
                arrays[2] = new Uneven(false);
                foreach (ArrayBase array in arrays)
                {
                    array.Print();
                    array.Getmiddle();
                }
            }
        }
    }
}
