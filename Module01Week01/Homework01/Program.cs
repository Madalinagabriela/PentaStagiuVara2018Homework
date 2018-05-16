using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework01
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randomNumber = new Random();
            int guess = randomNumber.Next(1, 100);

            Console.WriteLine("Introduceti un numar intre 1 si 100:");
            tryAgain: int input = int.Parse(Console.ReadLine());

            while (input != guess)
            {
                if (input < guess)
                {
                    Console.WriteLine("Numarul introdus este prea mic. Mai incearca!");
                    goto tryAgain;
                }
                else
                {
                    Console.WriteLine("Numarul introdus este prea mare. Mai incearca!");
                    goto tryAgain;
                }
            }

            Console.WriteLine("Ati ghicit numarul!");
            Console.ReadKey();
        }
    }
}
