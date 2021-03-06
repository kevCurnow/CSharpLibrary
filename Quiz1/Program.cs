﻿using System;
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

            //PART 2 LINQ
            //Collection
            IEnumerable<Triangle> triangles = new List<Triangle>()
            {
                newTriangle,
                newTriangle1,
                newTriangle2,
                newTriangle3,
                newTriangle4,
            };
            //Set up query
            IEnumerable<Triangle> tQuery = from t in triangles
                                           where t.TArea > 20
                                           orderby t.TArea ascending
                                           select t;
            //Display Results
            foreach (Triangle triangle in tQuery)
            {
                Console.WriteLine(triangle.TArea);
                
            }
            Console.ReadLine();
            
        }
    }
}
