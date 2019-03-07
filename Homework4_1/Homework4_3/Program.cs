using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Task 3 - Da se napishe programa koja za daden vnesen tekst od tastatura 
            // kje presmeta slednovo: 

            //1.Broj na zborovi:

            Console.Write("Please enter some string: ");
            var str = Console.ReadLine();

            string[] words = str.Split(' ');
            foreach (string word in words)
            {
                Console.WriteLine($"String: {word}");
            }


            // 2.Broj na spaces ' ':

            int spaces = 0;
            string str1;
            for (int i = 0; i < str.Length; i++)
            {
                str1 = str.Substring(i, 1);
                if (str1 == " ")
                    spaces++;
            }

            // 3.Efektivna dolzina na tekstot
            //(da se zemat vo predvid vodecki i trailing spaces):

            string start = str.TrimStart();
            string end = str.TrimEnd();


            Console.WriteLine(words.Length);
            Console.WriteLine(spaces);
            Console.WriteLine(start.Length + end.Length);
        }
    }
}
