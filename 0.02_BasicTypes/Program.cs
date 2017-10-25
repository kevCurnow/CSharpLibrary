using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._02_BasicTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            byte myByte = 255; // range: 0 to 255 size: 1 byte (one of 2 types, bool) use: seldom
            int number1 = 15;
            float myFloat = 3.14f; // need f
            double myDouble = 2.54; // no explicit type change needed
            decimal myDecimal = 3.14159m; // need some sort of m

            char myLetter = 'A'; // remember to use single quotes for char
            string myName = "Kevin"; // remember double quotes for string

            bool myTruth = true;
            

            // Declaration
            // <type> <variableName> <optional initializer>;
            int age;
            string country;

            // Initialization
            age = 41;
            Console.WriteLine(age);
            age = 42;
            Console.WriteLine(age);
            Console.ReadLine();


        }
    }
}
