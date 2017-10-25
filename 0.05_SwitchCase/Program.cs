using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._05_SwitchCase
{
    class Program
    {
        static void Main(string[] args)
        {
            string friend = "Ken";

            switch (friend)
            {
                case "Jay":
                    Console.WriteLine("Hey Jay.");
                    break;
                case "Paul":
                    Console.WriteLine("Sup Paul.");
                    break;
                case "Ken":
                    Console.WriteLine("Go Dawgs!");
                    break;
                default:
                    Console.WriteLine("I don't know you.");
                    break;
            }
        }
    }
}
