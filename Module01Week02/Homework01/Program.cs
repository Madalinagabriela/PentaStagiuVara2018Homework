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
            Console.WriteLine("Enter the year of birth");
            int yearOfBirth = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Enter the month of birth");
            int monthOfBirth = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Enter the day of birth");
            int dayOfBirth = Int32.Parse(Console.ReadLine());

            Console.WriteLine($"Your age: { GetAge(yearOfBirth)}");

            Console.WriteLine("Enter the gender");
            char gender = Convert.ToChar(Console.ReadLine());

            int? inputGender;

            if (gender == 'F')
            {
                Gender providedGender = Gender.Female;
                inputGender = (int)providedGender;
            }
            else if (gender == 'M')
            {
                Gender providedGender = Gender.Male;
                inputGender = (int)providedGender;
            }
            else
            {
                inputGender = null;
            }

            switch (inputGender)
            {
                case 0:
                    Console.WriteLine($"You have {63 - GetAge(yearOfBirth)} years left until you can retire.");
                    break;

                case 1:
                    Console.WriteLine($"You have {65 - GetAge(yearOfBirth)} years left until you can retire.");
                    break;

                default:
                    Console.WriteLine("Please input a correct value for the gender: F/ M.");
                    break;
            }

            Console.ReadKey();

        }

        public static int GetAge(int yearOfBirth)
        {
            var today = DateTime.Today;
            var age = today.Year - yearOfBirth;

            return age;
        }

        public static string GetBirthDate(int yearOfBirth, int monthOfBirth, int dayOfBirth)
        {
            DateTime birthDate = new DateTime(yearOfBirth, monthOfBirth, dayOfBirth);

            return birthDate.ToString();
        }

        public enum Gender
        {
            Female,
            Male
        }
    }
}

