using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._15_Override
{
    class Program
    {
        static void Main(string[] args)
        {
            Square newSquare = new Square(4);
            Circle newCircle = new Circle(3);
            Triangle newTriangle = new Triangle(18, 24, 30);
            Console.WriteLine($"Area = {newSquare.Area()}.");
            Console.WriteLine($"Area = {newCircle.Area()}.");
            Console.WriteLine($"Area = {newTriangle.Area()}.");
            Console.ReadLine(); 
            
        }
    }
}
