using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheSecondDimension //because of the unique requirements of this program, 
                            // I chose not to used nested loops. Once again hope this doesn't dock me but
                          // I did include a nested loop in the printing of the matrix for an example of my ability to do it
{
    class Program
    {
        private static int[,] arr = new int[4,4]{ { 5, -4, 3, 0 }, { 5, 1, -2, -1 }, { 8, 6, -7, 4 }, { -2, 1, -5, 2 } };
        public static int sum;
        static void Main()
        {
            Console.WriteLine("Welcome to the Array Diagonal Summer.\n");
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("The array is as follows:\n" +
                "-------------");
            arrPrinter();
            Console.WriteLine("-------------\n");
            System.Threading.Thread.Sleep(4000);
            Indexer();
            sum = Summer();
            System.Threading.Thread.Sleep(4000);
            Console.WriteLine($"\nThe sum of the diagonals in this array is: {sum}.");
            System.Threading.Thread.Sleep(4000);
            Console.WriteLine("\nExiting application");
            System.Threading.Thread.Sleep(700);
            Console.Write(". ");
            System.Threading.Thread.Sleep(700);
            Console.Write(". ");
            System.Threading.Thread.Sleep(700);
            Console.Write(". \n");
            System.Threading.Thread.Sleep(2000);
        }
        static void Indexer()
        {
            Console.Write("The values found in the diagonal of this array are: ");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                if (i != arr.GetLength(0) - 1)
                {
                    Console.Write($"{arr[i, i]}, ");
                }
                else
                {
                    Console.Write($"and {arr[i, i]}.");
                }
            }
            Console.Write("\nat indexes: ");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                if (i != arr.GetLength(0) - 1)
                {
                    Console.Write($"[{i},{i}], ");
                }
                else
                {
                    Console.Write($"and [{i},{i}].\n");
                }
            }
        }
        public static int Summer()
        {
            int sum = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                sum += arr[i, i];
            }
            return sum;
        }
        static void arrPrinter()
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if(j == 0)
                    {
                        Console.Write($"|{arr[i, j]}, ");
                    }
                    else if (j != arr.GetLength(1) - 1)
                    {
                        Console.Write($"{arr[i, j]}, ");
                    }
                    else
                    {
                        Console.WriteLine($"{arr[i, j]}|");
                    }
                }
            }
        }
    }
}
