using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._15_Override
{
    class Triangle: Shape
    {
        //Properties
        public double Side1 { get; set; }
        public double Side2 { get; set; }
        public double Side3 { get; set; }

        //Constructors
        public Triangle(double sideUno, double sideDos, double sideTres)
        {
            this.Side1 = sideUno;
            this.Side2 = sideDos;
            this.Side3 = sideTres;
            
        }

        //Methods
        public override double Area()
        {
            double p = ((Side1 + Side2 + Side3) / 2);
            double a = (p - Side1);
            double b = (p - Side2);
            double c = (p - Side3);
            return Math.Pow(p * a * b * c, .5);
        }




    }
}
