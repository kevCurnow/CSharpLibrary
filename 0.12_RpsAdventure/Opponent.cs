using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._12_RpsAdventure
{
    class Opponent:Fighters
    {
        int[] wins = new int[] { 0, 1, 2, 3 };
        string[] opponents = new string[] { "Bob the Peasant", "Ronaldo", "The Code Burglar", "JP the Code Master" };
        string[] intro = new string[] { "Please kind stranger, will you help a lowly peasant?", "Let's face facts, I'm better than you. This is pointless.", "I'm gonna steal your code!", "You've made it this far young one.  Do you have what it takes?" };
        string[] loss = new string[] { "*Bob the Peasant runs off to panhandle someone else.*", "*Ronaldo falls to the ground clutching his leg.* Ref! That was clearly a penalty!", "Did I say steal??? Uh... I meant study!  Stealing is bad.", "Congratulations. You have defeated me. *The Code Master bows*"};
        string[] win = new string[] { "*Bob the Peasant kicks you while you're down and steals your resources.* Never underestimate the poor!", "*Ronaldo scores a bajillion goals on you and then laughs at you.* Hahaha. See? I told you I was better than you!", "It appears you are not ready tadpole." }


       
    }
}
