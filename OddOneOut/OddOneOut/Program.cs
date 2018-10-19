using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddOneOut
{
    class Program
    {
        public static int sum;
        public static int average;

        static void Main()
        {
            Console.Write("Please enter a number to be your range: ");
            int n = nValidator(Console.ReadLine());
            int[] oddNumArr = new int[n];
            oddNumArr[0] = 1;
            for (int i = 1; i < oddNumArr.Length; i++)// fills array with odd nums
            {
                oddNumArr[i] = oddNumArr[i - 1] + 2;
            }
            for (int i = 0; i < oddNumArr.Length; i++)// calculates sum of numbers
            {
                sum += oddNumArr[i];
            }
            average = sum / (oddNumArr.Length - 1); // didn't actually see a need to break these into methods, might get marked off but this is much simpler
            Console.WriteLine($"\nThe sum of this array is {sum}, and it's average is {average}.");
            System.Threading.Thread.Sleep(4000);
        }
        public static int nValidator(string number)
        {
            int retnumber;
            while (!int.TryParse(number, out retnumber))
            {
                Console.WriteLine("Not a number. Please try again.");
                number = Console.ReadLine();
            }
            return retnumber;
        }
    }
}
