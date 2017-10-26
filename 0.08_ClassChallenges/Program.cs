using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._08_ClassChallenges
{
    class Program
    {
        static void Main(string[] args)
        {
            Netflix show1 = new Netflix();
            Netflix show2 = new Netflix();
            Netflix show3 = new Netflix();

            List<Netflix> shows = new List<Netflix>
            {
                show1,
                show2,
                show3
            };


            show1.Name = "Stranger Things";
            show1.Genre = "Sci-Fi/Horror";
            show1.Rating = 5;

            show2.Name = "How I Met Your Mother";
            show2.Genre = "Comedy";
            show2.Rating = 4;

            show3.Name = "Iron Fist";
            show3.Genre = "Superhero";
            show3.Rating = 1;

            //Console.WriteLine(Show3.CheckRating());
            foreach (Netflix element in shows)
            {
                Console.WriteLine(element.Name);
                Console.WriteLine(element.Genre);
                Console.WriteLine(element.Rating);
                Console.WriteLine(element.CheckRating());
                Console.WriteLine();
            }
            
            Console.ReadLine();

        }
    }
}
