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
            Onedimensioanl array = new Onedimensioanl(true);
        }
    }
    class Onedimensional
    {
        private int[] array;
        private bool rand;
        Console.WriteLine("Хотите заполнить массив сами? Введите Да или Нет");
        if(Console.ReadLine() == "Нет")
        {
            rand = false;
        }
        
        Filling(rand)
        {
            if(rand == true)
            {
                Console.WriteLine("Введите длину массива:");
                
                int Length = int.Parse(Console.ReadLine());
                for(i = 0;i<Length;i++)
                {
                    Console.WriteLine("Введите элемент массива:")
                    array[i] = int.Parse(Console.ReadLine());
                }
            }
        }
    }
}
