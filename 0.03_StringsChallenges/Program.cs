using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._03_StringsChallenges
{
    class Program
    {
        static void Main(string[] args)
        {
            int value = 2994;
            string output = string.Format("{0}{1:D}{2}",
                                        "{", value, "}");
            Console.WriteLine(output);

            //Percentage
            double percent = 0.23;
            Console.WriteLine("{0:#0.##%}", percent);
            Console.WriteLine("{0:P}", percent);

            //Phone number
            long phoneNumber = 1234567890;
            string number1 = phoneNumber.ToString("(###) ### - ####");
            Console.WriteLine(number1);
            Console.WriteLine("{0:(###) ### - ####}", phoneNumber);

            double cash = 69.69;
            Console.WriteLine("{0:C}", cash);

            string potEmployer = "Dev Place";
            string date = DateTime.Today.ToShortDateString();
            Console.WriteLine($"Dear {potEmployer}, ");
            Console.WriteLine($"Today is {date}. I'm really enjoying getting back into coding and");
            Console.WriteLine("I believe my additional business degree makes me a viable candidate.");

            string lCase = "kevin";
            string uCase = "KEVIN";
            bool result = lCase.Equals(uCase, StringComparison.Ordinal); //Case sensitive
            Console.WriteLine("Ordinal comparison: {0} and {1} are {2}", lCase, uCase, result ? "equal." : "not equal.");
            result = lCase.Equals(uCase, StringComparison.OrdinalIgnoreCase);
            Console.WriteLine("Ordinal ignore case: {0} and {1} are {2}", lCase, uCase, result ? "equal." : "not equal.");
            Console.ReadLine();
        }
    }
}
