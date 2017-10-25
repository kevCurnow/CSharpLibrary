using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._07_Objects
{
    class Program
    {
        static void Main(string[] args)
        {
            Donut PaulDonut = new Donut();
            Donut KennDonut = new Donut();
            Donut KevinDonut = new Donut();

            KennDonut.Filling = "Strawberry Jelly";
            KennDonut.Price = 0;
            KennDonut.Type = "Jelly";
            KennDonut.IsSpecial = false;

            KevinDonut.Filling = "Chocolate PB";
            KevinDonut.Price = 29.94M;
            KevinDonut.Type = "Chócolate";
            KevinDonut.IsSpecial = true;

            PaulDonut.Filling = "Cherry Jelly";
            PaulDonut.Price = 7.99M;
            PaulDonut.Type = "Jelly";
            PaulDonut.IsSpecial = true;

            Console.WriteLine(PaulDonut);
            Console.WriteLine(PaulDonut.Filling);
            Console.WriteLine(KevinDonut.Type);
            Console.ReadLine();
        }
    }
}
