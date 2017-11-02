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
        public double TArea { get; set; }

        //Constructor
        public Triangle(double triBas, double triHei)
        {
            this.TBase = triBas;
            this.THeight = triHei;
        }
        
        //Override the Area method
        public override double Area()
        {
            this.TArea = this.TBase * this.THeight * .5;
            return this.TArea;
        }
    }
}
