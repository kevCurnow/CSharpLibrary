using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._03_FeelingChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number 1 to 5 based on how you are feeling: ");
            string num = Console.ReadLine();
            string message;
            if (num == "1")
                message = "You sound upset, knock knock!";
            else if (num == "2")
                message = "What's wrong? Having a rough day?";
            else if (num == "3")
                message = "Just meh? Seems like it's one of those days.";
            else if (num == "4")
                message = "Sounds like you're doing well!";
            else if (num == "5")
                message = "Seeing you smile makes my day!";
            else
                //do
                {
                    message = "Invalid choice, please enter a number between 1 and 5.";
                }
                //while (Convert.ToInt32(num) < 1 || Convert.ToInt32(num) > 5);
            Console.WriteLine(message);
            Console.ReadLine();

            //switch case


        }
    }
}
