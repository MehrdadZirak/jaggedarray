using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jaggedarray
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int num;
            bool isValidNumber = false;

            do
            {
                Console.Write("How many words do you want to enter? ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out num))
                {
                    isValidNumber = true;
                }
                else
                {
                    Console.WriteLine("Invalid input! Pleas enter a valid integer number. ");
                    Console.ReadKey();
                    Console.Clear();
                }


            } while (!isValidNumber);


            char[][] jaggedAr = new char[num][];

            for (int i = 0; i < num; i++)
            {
                Console.Write("Enter the word: ");
                string word = Console.ReadLine();

                jaggedAr[i] = word.ToCharArray();
            }

            for (int i = 0; i < num; i++)
            {
                for (int j = 0; j < jaggedAr[i].Length; j++)
                {
                    Console.Write("{0}    ", jaggedAr[i][j]);
                }
                Console.WriteLine();


            }


            Console.ReadKey();

        }
    }
}
