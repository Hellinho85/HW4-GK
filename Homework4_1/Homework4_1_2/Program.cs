using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4_1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Task 1 - Da se napishe funkcija za presmetka na Faktoriel 
            // od daden cel pozitiven broj N:
            // So Metod Funkcija.
            Console.WriteLine("Please enter a number: ");
            double number = Convert.ToDouble(Console.ReadLine());
            double fact = FactWho(number);
            Console.WriteLine($"The factorial of the whole number {number.ToString()} is {fact.ToString()}");

        }


        public static double FactWho(double num)
        {

            if (num == 0)
                return 1;


            return num * FactWho(num - 1);



        }
    }
    
}
