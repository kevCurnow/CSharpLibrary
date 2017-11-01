using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._12_RpsAdventure
{
    class HorseMange : Fighters
    {
        //Constructors
        public HorseMange(string name, PlyrClass archetype)
        {
            this.Name = name;
            this.Archetype = archetype;
            this.Defeated = 0;
            this.IsAlive = true;
            this.Lives = 5;
            this.Level = 1;
            this.AttackPower = 10;
            this.CritChance = 0.10;


        }

        //Properties
        public PlyrClass Archetype { get; set; }


        //Enums
        public enum PlyrClass
        {
            HorseMange,
            PeanutButterandJellySandwich,
            CodingExtraordinaire,
            LochNessMonster,
            YummyTaco,
            OneEyedOneHornedFlyinPurplePeopleEater,
            SpookyGhost
        }
        public enum WeaponChoice
        {
            Rock,
            Paper,
            Scissors
        }



    }
}
