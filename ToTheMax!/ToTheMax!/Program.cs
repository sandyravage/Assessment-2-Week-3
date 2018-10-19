using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToTheMax_
{
    class Program
    {
        static void Main()
        {
           
            Console.Write("Please enter a number to be the size of your array: ");
            int n = nValidator(Console.ReadLine());
            int[] maxarr = new int[n];
            for (int i = 0; i < maxarr.Length; i++)
            {
                Console.Write("\nPlease enter an integer: ");
                maxarr[i] = nValidator(Console.ReadLine());
            }
            int maxNum = maxarr[0];
            for (int i = 0; i < maxarr.Length; i++)
            {
                if(maxNum < maxarr[i])
                {
                    maxNum = maxarr[i];
                }
            }
            Console.WriteLine($"\n{maxNum} is the largest number in your array.");
            System.Threading.Thread.Sleep(4000);
        }
        public static int nValidator(string number)
        {
            int retnumber;
            while(!int.TryParse(number, out retnumber))
            {
                Console.WriteLine("Not a number. Please try again.");
                number = Console.ReadLine();
            }
            return retnumber;
        }
    }
}
