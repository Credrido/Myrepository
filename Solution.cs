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


class Onedimensional
    {
        public int[] Createarray(int[] array, int Length)
        {
            for (int i = 0; i < Length; i++)
            {
                Console.WriteLine("Введите элемент массива:");

                array[i] = int.Parse(Console.ReadLine());

                Console.WriteLine();
            }
            Console.WriteLine();

            return array;

        }

        public int[] Createrandomarray(int[] array, int Length)
        {
            Random random = new Random();

            for (int i = 0; i < Length; i++)
            {
                array[i] = random.Next(-200, 200);
            }
            Console.WriteLine();

            return array;
        }

        public decimal Getmiddle(int[] array)
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

            return result;
        }

        public int[] Deletebigger100(int [] array,int Length)
        {
            Console.WriteLine("Массив без чисел больше 100 по модулю");
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 100 && array[i] > -100)
                {
                    Console.Write($"{array[i]}, ");
                }
            }

            Console.WriteLine();

            return array;
        }

        public int[] Print(int[] array)
        {
            Console.WriteLine("Исходный массив");

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]}, ");
            }
            return array;
        }
    }

class Twodimensional
    {
        public int [,] Createarray(int[,] array2,int rows, int columns)
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.WriteLine("Введите элемент массива:");

                    array2[i, j] = int.Parse(Console.ReadLine());

                    Console.WriteLine();
                }
            }
            Console.WriteLine();

            return array2;
        }

        public int[,] Createrandomarray(int[,] array2,int rows,int columns)
        {
            Random random2 = new Random();

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    array2[i, j] = random2.Next(-250, 250);
                }
            }
            Console.WriteLine();

            return array2;
        }

        public decimal Getmiddle(int[,] array2)
        {
            decimal sum = 0;

            for (int i = 0; i < array2.GetLength(0); i++)
            {
                for (int j = 0; j < array2.GetLength(1); j++)
                {
                    sum += array2[i,j];
                }
            }

            decimal result = sum /(array2.GetLength(0) * array2.GetLength(1));

            Console.WriteLine("Среднее значение массива:");

            Console.WriteLine(result);

            Console.WriteLine();

            return result;
        }

        public int[,] Print(int[,] array2)
        {
            Console.WriteLine("Исходный массив:");

            for (int i = 0; i < array2.GetLength(0); i++)
            {
                for (int j = 0; j < array2.GetLength(1); j++)
                {
                    Console.Write($"{array2[i, j]} \t");
                }
                Console.WriteLine();
            }
            return array2;
        }

        public int[,] Print2(int[,] array2)
        {
            Console.WriteLine("Массив с перевёрнутыми чётными строками:");

            for (int i = 0; i < array2.GetLength(0); i++)
            {
                if ((i + 1) % 2 == 0)
                {
                    for (int j = array2.GetLength(1); j > 0; j--)
                    {
                        Console.Write($"{array2[i, j - 1]} \t");
                    }
                }
                else
                {
                    for (int k = 0; k < array2.GetLength(1); k++)
                    {
                        Console.Write($"{array2[i, k]} \t");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            return array2;
        }
    }

class Uneven
    {
        public int[][] Createarray(int[][] array3)
        {
            Console.WriteLine();

            for (int i = 0; i < array3.Length; i++)
            {
                Console.WriteLine($"Введите длину массива {i}:");

                int Length = int.Parse(Console.ReadLine());

                Console.WriteLine();

                array3[i] = new int[Length];

                for (int l = 0; l < array3[i].Length; l++)
                {
                    Console.WriteLine($"Введите элемент массива {i}:");

                    int j = int.Parse(Console.ReadLine());

                    array3[i][l] = j;

                    Console.WriteLine();
                }
                Console.WriteLine();
            }
            return array3;
        }

        public int[][] Createrandomarray(int[][] array3)
        {
            Random random3 = new Random();

            Console.WriteLine();

            for (int i = 0; i < array3.Length; i++)
            {
                Console.WriteLine($"Введите длину массива {i}:");

                int Length = int.Parse(Console.ReadLine());

                array3[i] = new int[Length];

                for (int l = 0; l < array3[i].Length; l++)
                {
                    int j = random3.Next(-250, 250);

                    array3[i][l] = j;

                    Console.WriteLine();
                }
                Console.WriteLine();
            }
            return array3;
        }
        public decimal Getmiddle(int[][] array3)
        {
            decimal sum = 0;

            for (int i = 0; i < array3.Length; i++)
            {
                for (int j = 0; j < array3[i].Length; j++)
                {
                    sum += array3[i][j];
                }
            }
            decimal result = sum;

            Console.WriteLine("Среднее значение массива:");

            Console.WriteLine(result);

            Console.WriteLine();

            return result;
        }
    }
