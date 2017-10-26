using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._08_ClassChallenges
{
    class Netflix
    {
        public string Name { get; set; }
        public string Genre { get; set; }
        public double Rating { get; set; }

        public string CheckRating()
        {
            if (this.Rating > 4)
            {
                return "This is a must watch!";
            }
            else if (this.Rating >=3 )
            {
                return "You might like this.";
            }
            else
            {
                return "Don't waste your time.";
            }

        }
    }
}
