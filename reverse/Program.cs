using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 100;
            int num2 = 101;
            string input = "1234";
            string output = new string(input.ToCharArray().Reverse().ToArray());
            Console.WriteLine(output);
            Console.ReadLine();
        }
    }
}
