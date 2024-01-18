using System;

namespace ConsoleApp14
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }

    class Onedimensional
    {
        public void NumberOne(string[] args)
        {
            Console.WriteLine("Введите длину массива:");
            int Length = int.Parse(Console.ReadLine());

            int[] array = new int[Length];

            bool rand = false;

            Console.WriteLine("Хотите заполнить массив сами?");

            if (Console.ReadLine() == "Да")
            {
                rand = true;
            }
            if(true)
            {
                for(int i = 0; i < Length;i++)
                {
                    array[i] = int.Parse(Console.ReadLine());
                }
            }
        }
    }

    class Twodimensional
    {

    }

    class Stepped
    {

    }
}
