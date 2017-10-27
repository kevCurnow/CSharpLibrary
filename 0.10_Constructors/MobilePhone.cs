using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._10_Constructors
{
    class MobilePhone
    {
        public MobilePhone(string friendName, string make, string model)
        {
            this.Make = make;
            this.Model = model;
            this.FriendName = friendName;
        }

        public MobilePhone(string make, string model)
        {
            this.Make = make;
            this.Model = model;
        }

        public string Make { get; set; }
        public string Model { get; set; }
        public string FriendName { get; set; }
        public string GetPhone()
        {
            return ($"{FriendName} has a/an {Make} {Model}.");
        }
    }
}
