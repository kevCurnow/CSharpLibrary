using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._17_Interfaces_Collections_Pseudo
{
    class ListClass : ICollect, IEnum, IList
    {
        public void AddSomeStuff()
        {
            Console.WriteLine("Add stuff to list");
        }

        public void RemoveSomeStuff()
        {
            Console.WriteLine("Remove stuff from list");
        }

        public void CheckTheCapacity()
        {
            Console.WriteLine("Checking capacity of list");
        }

        public void CheckTheCount()
        {
            Console.WriteLine("Checking count of list");
        }

        public void InterateOverCollection()
        {
            Console.WriteLine("Iterating over list");
        }

        
    }
}
