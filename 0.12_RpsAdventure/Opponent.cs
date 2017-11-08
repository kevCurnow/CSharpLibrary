using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._12_RpsAdventure
{ 
    class Opponent:Fighters
    {
        public Opponent()
        {
            this.IsAlive = true;
            this.Lives = 3;
            
        }

        //Methods
        public int Attack()
        {
            Random rnd = new Random();
            int oWeapon = rnd.Next(0, 3);
            return oWeapon;
        }

        //Data Arrays
        public string[] opponents = new string[] { "Bob the Peasant", "Ronaldo", "The Code Burglar", "JP the Code Master" };
        public string[] intro = new string[] { "Please kind stranger, will you help a lowly peasant?", "Let's face facts, I'm better than you. This is pointless.", "I'm gonna steal your code!", "You've made it this far young one.  Do you have what it takes?" };
        public string[] loss = new string[] { "Bob the Peasant runs off to panhandle someone else.", "Ronaldo falls to the ground clutching his leg. Ref! That was clearly a penalty!", "Did I say steal??? Uh... I meant study!  Stealing is bad.", "Congratulations. You have defeated me. The Code Master bows" };
        public string[] win = new string[] { "Bob the Peasant kicks you while you're down and steals your resources. Never underestimate the poor!", "*Ronaldo scores a bajillion goals on you and then laughs at you.* Hahaha. See? I told you I was better than you!", "It's mine! It's all mine! *The Code Burglar steals all your hard work and successfully passes it off as his.", "It appears you are not ready tadpole." };
        public string[] scissorsWin = new string[] { "Bob the Peasant just flails his arms wildly and somehow hits you.", "Ronaldo's bicycle kick shreds through your paper-thin shield.", "You hear the faint sounds of fingers typing on a keyboard: The Code Burglar has just stolen your code via cut and paste!", "*The Code Master deals a small but devastating attack.* Looks like you forgot a semi-colon." };
        public string[] rockWin = new string[] { "Bob the Peasant plows through you thanks to a release of pent up anger", "Ronaldo counters your attack, stealing the ball and scoring easily", "The Code Burglar ignores your advice and prepares to submit your work without making a single change", "You are hit with a blast of code, the majority of which you have no idea what it does, but just know that it hurts to think about." };
        public string[] paperWin = new string[] { "You feel sorry for Bob the Peasant and let your guard down, allowing him to strike.", "Ronaldo drops to the ground and rolls in agony. The official penalizes you even though you clearly never touched your opponent.", "The Code Burglar's actions are somehow deemed just under Fair Use, even though he has no idea what that means.", "The Master's calm demeanor slips through your defenses like a missing curly brace." };
        public string[] scissorsLoss = new string[] { "You easily counter Bob the Peasant's feebish attacks and throw him off his feet.", "You stand your ground, somehow managing to block each and everyone of Ronaldo's fancy shots.", "You catch the Code Burglar in the act and remind him that it's okay to use your work as a reference, but not to plagerize it as his own.", "You see the Code Master's attack coming before he does and counter it." };
        public string[] rockLoss = new string[] { "You easily side-step Bob the Peasant's mad rush by remaining calm", "You counter Ronaldo with your own fancy footwork, leaving him dumbfounded as you sprint down the pitch.", "You convince The Code Burglar that what he is about to do is wrong and help him change his ways (temporarily).", "Using the power of Google you are able to comprehend the Code Master's blast and absorb it." };
        public string[] paperLoss = new string[] { "You ignore Bob the Peasant's attempt to make you pity him.", "After reviewing the tape, the referee agrees that you never touched Ronaldo and penalizes him for being a Whiney Little Flopper Baby.", "You explain to the Code Burglar that Fair Use is not an excuse for plagiarism.", "You neutralize the Code Master's soothing voice by entering your own meditative state of peacefully tranquility." };


    }
}
    