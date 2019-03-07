using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Task 1 Option 2 - without Method
            Console.Write("Please enter your number: ");
            double number = int.Parse(Console.ReadLine());

            double factorial = 1;
            for (int i = 1; i <= number; i++)
            {

                if (number - Math.Round(number) != 0)
                {
                    Console.WriteLine("Invalid number");
                }
                else
                {
                    factorial *= i;
                }

            }

            Console.WriteLine(factorial);
            Console.Read();
        }
    }
}
