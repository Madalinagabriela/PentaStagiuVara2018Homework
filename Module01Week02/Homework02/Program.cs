using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input your string: ");
            string inputString = Console.ReadLine();

            Console.WriteLine("Choose one option below:");

            showmenu:
            ShowMenu();

            var option = int.TryParse(Console.ReadLine(), out int optionSelected);

            if (Enumerable.Range(1, 7).Contains(optionSelected))
            {
                switch (optionSelected)
                {
                    case 1:
                        Console.WriteLine($"The string converted in uppercase is: '{inputString.ToUpper()}'");
                        break;

                    case 2:
                        Console.WriteLine($"The string converted in lowercase is: '{inputString.ToLower()}'");
                        break;

                    case 3:
                        Console.WriteLine("Enter the character you want to replace and the character you want to use for replacing separated by comma:");
                        string characters = Console.ReadLine();
                        string[] splitString = characters.Split(',');
                        Console.WriteLine(inputString.Replace(splitString[0], splitString[1]));
                        break;

                    case 4:
                        Console.WriteLine($"The length of the string is: {inputString.Length}");
                        break;

                    case 5:
                        Console.WriteLine("Enter the string you want to insert:");
                        string insertString = Console.ReadLine();
                        Console.WriteLine($"The new string is: {inputString.Insert(0, insertString)}.");
                        break;

                    case 6:
                        Console.WriteLine("Enter the value: ");
                        string value = Console.ReadLine();
                        Console.WriteLine($"The first occurence of {value} is at position {inputString.IndexOf(value)}.");
                        break;

                    case 7:
                        char[] array = inputString.ToCharArray();
                        Array.Reverse(array);
                        Console.Write("The inverted string is: ");
                        Console.WriteLine(array);
                        break;
                }
            }
            else
            {
                Console.WriteLine("Please enter a number between 1 and 7!");
                goto showmenu;
            }

            Console.ReadLine();
        }

        private static void ShowMenu()
        {
            Console.WriteLine("1.Convert the string to uppercase.");
            Console.WriteLine("2.Convert the string to lowercase.");
            Console.WriteLine("3.Replace a character.");
            Console.WriteLine("4.Length of the string.");
            Console.WriteLine("5.Insert a substring into string.");
            Console.WriteLine("6.Return the first index position of a specified value.");
            Console.WriteLine("7.Reverse the string.");

        }

    }
}

