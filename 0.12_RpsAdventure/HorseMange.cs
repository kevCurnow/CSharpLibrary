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
            this.Lives = 3;
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
            SpookyGhost,
            JarJarBinks,
            LatinPig,
        }
        public enum Weapon
        {
            Rock,
            Paper,
            Scissors
        }
        
        

    }
}
