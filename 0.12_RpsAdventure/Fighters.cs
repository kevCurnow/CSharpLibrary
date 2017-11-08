using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._12_RpsAdventure
{
    public abstract class Fighters
    {
        //Constants
        const int MIN_LIVES = 0;

        //Properties
        public string Name { get; set; }
        public string OpponentName { get; set; }
        public int Defeated { get; set; }
        public bool IsAlive { get; set; }
        public int Lives { get; set; }
        public string Rock { get; set; }
        public string Paper { get; set; }
        public string Scissors { get; set; }
        public string Intro { get; set; }
        //Methods
        //public int Attack()
        //{
        //    Random rnd = new Random();
        //    int spread = rnd.Next(-5, 6);
        //    int damage = this.AttackPower + spread;
        //    bool isCrit = IsCritical();
        //    return isCrit ? (damage * 2) : damage;
        //}

        //public bool IsCritical()
        //{
        //    Random rnd = new Random();
        //    bool isCrit = rnd.Next(0, 101) < (this.CritChance * 100) ? true : false;
        //    return isCrit;
        //}
    }
}
