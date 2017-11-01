using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._13_MethodsOverloading
{
    public class Player
    {
        //Methods
        public void Attack(int damage)
        {
            Console.WriteLine($"Attacked for {damage}!");
        }
        
        public void Attack(int damage, string attackType)
        {
            Console.WriteLine($"Attacked for {damage} with {attackType}!");
        }

        public void Attack(int damage, string attackType, int numOfTimes)
        {
            Console.WriteLine($"Attacked with {attackType} {numOfTimes} times for {damage*numOfTimes} total damage!");

        }

    }

}
