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
            Console.WriteLine("Задачи на одномерный массив");

            Console.WriteLine();

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
                Array.Createarray(array, Length);
            }
            else
            {
                Array.Createrandomarray(array, Length);
            }

            Array.Print(array);

            Console.WriteLine();

            Console.WriteLine();

            Array.Getmiddle(array);

            Array.Deletebigger100(array, Length);

            Console.WriteLine();

            Console.WriteLine();

            Console.WriteLine();



            Console.WriteLine("Задачи на двумерный массив");

            Console.WriteLine();

            Twodimensional Array2 = new Twodimensional();

            Console.WriteLine("Введите кол-во строк:");

            int rows = int.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("Введите кол-во столбцов:");

            int columns = int.Parse(Console.ReadLine());

            Console.WriteLine();

            int[,] array2 = new int[rows,columns];

            bool randif2 = true;

            Console.WriteLine("Хотите заполнить массив сами? Введите Да или Нет");

            if (Console.ReadLine() == "Нет")
            {
                randif2 = false;
            }

            if (randif2 == true)
            {
                Array2.Createarray(array2,rows,columns);
            }
            else
            {
                Array2.Createrandomarray(array2, rows,columns);
            }

            Array2.Print(array2);

            Console.WriteLine();

            Console.WriteLine();

            Array2.Getmiddle(array2);

            Array2.Print2(array2);

            Console.WriteLine();
            Console.WriteLine();



            Console.WriteLine("Задачи на неровный массив");

            Console.WriteLine();

            Uneven Array3 = new Uneven();

            Console.WriteLine("Введите кол-во массивов:");

            int Len = int.Parse(Console.ReadLine());

            Console.WriteLine();

            int[][] array3 = new int[Len][];

            bool randif3 = true;

            Console.WriteLine("Хотите заполнить массив сами? Введите Да или Нет");

            if (Console.ReadLine() == "Нет")
            {
                randif3 = false;
            }

            if (randif3 == true)
            {
                Array3.Createarray(array3);
            }
            else
            {
                Array3.Createrandomarray(array3);
            }

            Array3.Print(array3);

            Array3.Getmiddle(array3);
        }
    }
}

class Onedimensional
    {
        public int[] Createarray(int[] array, int Length)
        {
            Console.WriteLine();
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

        public int[] Deletebigger100(int[] array, int Length)
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

            return array;
        }

        public int[] Print(int[] array)
        {
            Console.WriteLine("Исходный массив:");

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]}, ");
            }
            return array;
        }
    }

class Twodimensional
    {
        public int[,] Createarray(int[,] array2, int rows, int columns)
        {
            Console.WriteLine();
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

        public int[,] Createrandomarray(int[,] array2, int rows, int columns)
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
                    sum += array2[i, j];
                }
            }

            decimal result = sum / (array2.GetLength(0) * array2.GetLength(1));

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
                }
                Console.WriteLine();
            }
            return array3;
        }
        public decimal Getmiddle(int[][] array3)
        {
            Console.WriteLine();

            decimal sum = 0;

            int counter = 0;

            for (int i = 0; i < array3.Length; i++)
            {
                int Len = array3[i].Length;

                int summ = array3[i].Sum();

                Console.WriteLine($"Среднее значение массива {i}:");

                Console.WriteLine(summ / Len);

                Console.WriteLine();

                counter += array3[i].Length;
                for (int j = 0; j < array3[i].Length; j++)
                {
                    sum += array3[i][j];
                }
            }

            decimal result = sum/counter;

            Console.WriteLine("Среднее значение всего массива:");

            Console.WriteLine(result);

            Console.WriteLine();

            return result;
        }

        public int[][] Print(int[][] array3)
        {
            Console.WriteLine("Исходный массив:");

            for (int i = 0; i < array3.Length; i++)
            {
                for (int l = 0; l < array3[i].Length; l++)
                {
                    Console.Write($"{array3[i][l]} \t");
                }
                Console.WriteLine();
            }
            return array3;
        }
    }
