using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz1
{
    class Program
    {
        static void Main(string[] args)
        {
            //PART 1 OVERRIDE
            Triangle newTriangle = new Triangle(4, 6);
            Triangle newTriangle1 = new Triangle(8, 10);
            Triangle newTriangle2 = new Triangle(16, 20);
            Triangle newTriangle3 = new Triangle(5, 7);
            Triangle newTriangle4 = new Triangle(9, 10);
            Console.WriteLine($"Area of Triangle 1 = {newTriangle.Area()}");
            Console.WriteLine($"Area of Triangle 2 = {newTriangle1.Area()}");
            Console.WriteLine($"Area of Triangle 3 = {newTriangle2.Area()}");
            Console.WriteLine($"Area of Triangle 4 = {newTriangle3.Area()}");
            Console.WriteLine($"Area of Triangle 5 = {newTriangle4.Area()}");
            Console.ReadLine();
            //Just realized you could easily put base and height in an array
        }
    }
}
