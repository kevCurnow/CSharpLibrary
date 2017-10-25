using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._06_EulerChallenges
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0;
            int num2 = 1;
            int total = 0;
            {
                for (int i = 0; i <= 4000000;)
                { i = num1 + num2;
                    if (i % 2 == 0)
                    {
                        total += i;
                    }
                    num1 = num2;
                    num2 = i;
                Console.WriteLine(total);
                }
            }
            Console.ReadLine();
        }
    }
}
