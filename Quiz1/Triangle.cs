using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz1
{
    class Triangle : Shape
    {
        //Properties
        public double TBase { get; set; }
        public double THeight { get; set; }

        //Constructor
        public Triangle(double triBas, double triHei)
        {
            this.TBase = triBas;
            this.THeight = triHei;
        }
        
        //Override the Area method
        public override double Area()
        {
            return (.5*TBase*THeight);
        }
    }
}
