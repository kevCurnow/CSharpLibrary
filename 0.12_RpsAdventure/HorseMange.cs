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
            SpookyGhost,
            JarJarBinks,
            LatinPig,
        }
        public enum WeaponChoice
        {
            Rock,
            Paper,
            Scissors
        }

        int[] wins = new int[] { 0, 1, 2, 3, 4 };
        string[] opponents = new string[] { "Bob the Peasant", "Ronaldo", "Billy the Troll", "The Code Burglar", "JP the Code Master" };
        string[] intro = new string[] { "Please kind stranger, will you help a lowly peasant?", "Let's face facts, I'm better than you. This is pointless.", "First! Lol. 6969", "I'm gonna steal your code!", "You've made it this far young one.  Do you have what it takes?" };
        string[] loss = new string[] { "*Bob the Peasant runs off to panhandle someone else.*", "*Ronaldo falls to the ground clutching his leg.* Ref! That was clearly a penalty!", "*Billy leaves you alone after not being acknowledged.*", "Did I say steal??? Uh... I meant study!  Stealing is bad.", "Congratulations. You have defeated me. *The Code Master bows*" };
        string[] win = new string[] { "*Bob the Peasant kicks you while you're down and steals your resources.* Never underestimate the poor!", "*Ronaldo scores a bajillion goals on you and then laughs at you.* Hahaha. See? I told you I was better than you!", "*An ubsurd amount of memes and dumb jokes fill your screen, crashing your computer.* Lol N00B.", "It's mine! It's all mine! *The Code Burglar steals all your hard work and successfully passes it off as his.", "It appears you are not ready tadpole." };
        string[] scissorsWin = new string[] { "Bob the Peasant just flails his arms wildly and somehow hits you.", "Ronaldo's bicycle kick shreds through your paper-thin shield.", "Billy distracts you with memes gifs and dumb jokes that are initially hilarious but quickly get annoying.", "You hear the faint sounds of fingers typing on a keyboard: The Code Burglar has just stolen your code via cut and paste!", "*The Code Master deals a small but devastating attack.* Looks like you forgot a semi-colon." };
        string[] rockWin = new string[] { "Bob the Peasant plows through you thanks to a release of pent up anger", "Ronaldo counters your attack, stealing the ball and scoring easily", "Billy bullies you with harsh untrue statements in an attempt to increase his self-esteem", "The Code Burglar ignores your advice and prepares to submit your work without making a single change", "You are hit with a blast of code, the majority of which you have no idea what it does, but just know that it hurts to think about." };
        string[] paperWin = new string[] { "You feel sorry for Bob the Peasant and let your guard down, allowing him to strike.", "Ronaldo drops to the ground and rolls in agony. The official penalizes you even though you clearly never touched your opponent.", "Billy claims that all his derogatory comments are protected under Free Speech.", "The Code Burglar's actions are somehow deemed just under Fair Use, even though he has no idea what that means.", "The Master's calm demeanor slips through your defenses like a missing curly brace." };
        string[] scissorsLoss = new string[] { "You easily counter Bob the Peasant's feebish attacks and throw him off his feet.", "You stand your ground, somehow managing to block each and everyone of Ronaldo's fancy shots.", "You ignore Billy's weak comedic efforts, this is a waste of your time.", "You catch the Code Burglar in the act and remind him that it's okay to use your work as a reference, but not to plagerize it as his own.", "You see the Code Master's attack coming before he does and counter it." };
        string[] rockLoss = new string[] { "You easily side-step Bob the Peasant's mad rush by remaining calm", "You counter Ronaldo with your own fancy footwork, leaving him dumbfounded as you sprint down the pitch.", "You shake off Billy's rude and immature actions, these trolls don't deserve any attention.", "You convince The Code Burglar that what he is about to do is wrong and help him change his ways (temporarily).", "Using the power of Google you are able to comprehend the Code Master's blast and absorb it." };
        string[] paperLoss = new string[] { "You ignore Bob the Peasant's attempt to make you pity him.", "After reviewing the tape, the referee agrees that you never touched Ronaldo and penalizes him for being a Whiney Little Flopper Baby.", "You explain to Billy that while he may be protected by the First Ammendment, he is still being rude.", "You explain to the Code Burglar that Fair Use is not an excuse for plagiarism.", "You neutralize the Code Master's soothing voice by entering your own meditative state of peacefully tranquility." };

    }
}
