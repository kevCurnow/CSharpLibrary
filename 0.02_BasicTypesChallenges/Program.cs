using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._02_BasicTypesChallenges
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroUno;
            int numeroDos = 2;
            Console.WriteLine(numeroDos);

            string aName;
            string midName = "Scott";
            Console.WriteLine(midName);

            bool trueFalse;
            bool falseTrue = false;
            Console.WriteLine(falseTrue);

            float floatOn;
            float keepFloating = -2.994f;
            Console.WriteLine(keepFloating);

            double prep4Trouble;
            double makeDouble = 2.468;
            Console.WriteLine(makeDouble);

            decimal deweyDec;
            decimal deweyNum = 0.7734m;
            Console.WriteLine(deweyNum);


            string Combo = midName + " " + makeDouble;
            Console.WriteLine(Combo);

            string birthYear = "1994";
            int yearInt = Convert.ToInt32(birthYear);
            Console.WriteLine("I was born in " + yearInt + ".");
            Console.ReadLine();
        }
    }
}
