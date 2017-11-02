using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._15_Override
{
    class Square : Shape
    {
        //Constant
        public const int NUM_SIDES = 4;

        //Constructor
        public Square(int length)
        {
            this.SideLength = length;
        }

        //properties
        public int SideLength { get; set; }

        //Methods
        public override double Area()
        {
            return Math.Pow(SideLength, 2);
        }
    }
}
