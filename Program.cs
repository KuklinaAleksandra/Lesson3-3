using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите слово ");


            string words = Console.ReadLine();

            string words1 = words;

            for (int i = 0; i < words.Length; i++)
            {

                Console.Write(words[i] + " ");

            }
            Console.WriteLine();

            System.Array.Reverse(words1);// слова в words в обратном порядке
 
            Console.WriteLine("reversed:");
 
            for (int i = words1.Length; i >= words1.Length; i--)
            {
 
                Console.Write(words1[i] + " ");
 
            }
            Console.WriteLine();
            Console.ReadKey();

        }
    }
}
