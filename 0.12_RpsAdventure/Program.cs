using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Speech.Synthesis;
using System.Threading;
using System.Threading.Tasks;

namespace _0._12_RpsAdventure
{
    class Program
    {
        static void Main(string[] args)
        {
            //This will be used for later
            SpeechSynthesizer synth = new SpeechSynthesizer();

            //Prompt for player information
            Console.WriteLine("Greetings, young whipper-snapper." +
                "  By what do they call you?");
            synth.Speak("Greetings young whipper snapper.  By what do they call you?");
            string inputName = Console.ReadLine();
            Console.Clear();

            Console.WriteLine($"A pleasure to make your acquaintance, {inputName}.");
            synth.Speak("A pleasure to make your acquaintance, Horse Mange.");
            
            Console.Clear();
            Console.WriteLine("What be thy classification stranger?\n" +
                "0: Horse Mange\n" +
                "1: PBJ\n" +
                "2: Coder\n" +
                "3: Nessie\n" +
                "4: Taco\n" +
                "5: Sheb\n" +
                "6: Ghost");
            synth.Speak("What be thy classification stranger?");
            //Get value user provided
            int inputAtype = Int32.Parse(Console.ReadLine());
            // perform explicit cast from
            // int to Specialization enum type
            HorseMange.PlyrClass inputArchetype = (HorseMange.PlyrClass)inputAtype;

            Console.Clear();
            Console.WriteLine($"A {inputArchetype}?  Very intriguing.\n" +
            $"I haven't seen a {inputArchetype} in many many moons.");
            synth.Speak($"A {inputArchetype}? Very intriguing.  I haven't seen a {inputArchetype} in many many moons.");

            Console.Clear();
            Console.WriteLine($"Welcome fair {inputName} of Clan {inputArchetype}. \n" +
                "This be the dangerously-exciting-underground world of Roshambeau.\n\n" +
                "Defeat four warriors and you may find what it is you seek.");
            synth.Speak($"Welcome fair {inputName} of Clan {inputArchetype}. This be the dangerously exciting underground world of Row Sham Beau. Defeat four warriors and you may find what it is you seek mine freeled.");
            Thread.Sleep(500);
            synth.Speak("Yarr");
        }
    }
}
