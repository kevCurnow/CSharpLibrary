using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._04_conditionalVerbal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How much money is in your bank account? :");
            string cash = Console.ReadLine();
            string message;

            if (Convert.ToInt32(cash) > 10000)
                message = "Yay!";
            else if (Convert.ToInt32(cash) < 10000)
                message = "Ouch!";
            else
                message = "Exactly 10000";

            Console.WriteLine(message);
            Console.ReadLine();
        }
    }
}
