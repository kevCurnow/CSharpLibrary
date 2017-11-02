using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._15_Override
{
    class Circle: Shape
    {
        

        //Constructor
        public Circle(int radius)
        {
            this.RadiusLength = radius;
        }

        //properties
        public int RadiusLength { get; set; }

        //Methods
        public override double Area()
        {
            return (Math.PI*(Math.Pow(RadiusLength, 2)));
        }
    }
}
