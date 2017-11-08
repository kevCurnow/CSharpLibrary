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
                "6: Ghost\n" +
                "7: Gungan\n" +
                "8: ItalianBacon"
            );
            synth.Speak("What be thy classification stranger?");
            //Get value user provided
            int inputAtype = Int32.Parse(Console.ReadLine());
            // perform explicit cast from
            // int to Specialization enum type
            HorseMange.PlyrClass inputArchetype = (HorseMange.PlyrClass)inputAtype;

            Console.Clear();
            
            Console.WriteLine($"A {inputArchetype}?  Very intriguing.\n" +
            $"I haven't seen a {inputArchetype} in many many moons.");
            if (inputAtype == 7)
            {

                synth.Speak($"Yousa una {inputArchetype}? BBerry intriguing. Meesa no C N una {inputArchetype} in mooee mooee moons.");
            }
            else if (inputAtype == 8)
            {
                synth.Speak("a yay atinpiglay ? ery vay intriguing yay .  i yay aven'thay een say a yay atinpiglay in yay any may any may oons may.");
            }
            else
            {
                synth.Speak($"A {inputArchetype}? Very intriguing.  I haven't seen a {inputArchetype} in many many moons.");
            }
            Console.Clear();
            Console.WriteLine($"Welcome fair {inputName} of Clan {inputArchetype}. \n" +
                "This be the dangerously-exciting-underground world of Roshambeau.\n" +
                "Defeat the current champion and you may find what it is you seek, mein frield.");
            synth.Speak($"Welcome fair {inputName} of Clan {inputArchetype}. This be the dangerously exciting underground world of Row Sham Beau. Defeat the current champion and you may find what it is you seek mine freeled.");
            Thread.Sleep(5);
            synth.Speak("Yarr");
            HorseMange newHM = new HorseMange(inputName, inputArchetype);
            Opponent newOpp = new Opponent();
            bool isRunning = true;
            Console.Clear();
            Console.WriteLine("Which champion would you like to face?\n" +
               "0: Bob the Peasant\n" +
               "1: Ronaldo\n" +
               "2: The Code Burglar\n" +
               "3: JP The CodeMaster");
            int champion = Int32.Parse(Console.ReadLine());
            while (isRunning == true)
            {
                Console.Clear();
                Console.Beep();
                Console.WriteLine("A challenger approaches!");
                synth.Speak("A challenger approaches!");
                Console.Clear();
                Console.WriteLine($"Opponent: {newOpp.opponents[champion]}");
                Console.WriteLine($"{newOpp.intro[champion]}");
                synth.Speak($"{newOpp.intro[champion]}");
                Thread.Sleep(1000);
                //Battle Loop
                while (newHM.IsAlive && newOpp.IsAlive)
                {
                    Console.Clear();
                    Console.WriteLine($"{newHM.Name} Lifes Left: {newHM.Lives}\n" +
                                      $"{newOpp.opponents[champion]} Lifes Left: {newOpp.Lives}");
                    Thread.Sleep(500);
                    Console.WriteLine("It's time to attack! Which do you choose?");
                    Console.Write("0: Rock\n" +
                                  "1: Paper\n" +
                                  "2: Scissors\n");
                    int attackChoice = Int32.Parse(Console.ReadLine());
                    HorseMange.Weapon heroWeapon = (HorseMange.Weapon)attackChoice;

                    //handle attacks
                    switch(heroWeapon)
                    {
                        case HorseMange.Weapon.Rock:
                                if (newOpp.Attack() == 0)
                                {
                                    Console.Clear();
                                    synth.Speak("hmm");
                                    Console.WriteLine("Nothing happened.");
                                    Thread.Sleep(500);
                                }
                                else if (newOpp.Attack() == 1)
                                {
                                    Console.Clear();
                                    synth.Speak("Crinkle Cover.");
                                    Console.WriteLine($"{newOpp.paperWin[champion]}");
                                    Thread.Sleep(5000);
                                    newHM.Lives = newHM.Lives - 1;
                                }
                                else
                                {
                                    Console.Clear();
                                    synth.Speak("BOOM!");
                                    Console.WriteLine($"{newOpp.scissorsLoss[champion]}");
                                    Thread.Sleep(5000);
                                    newOpp.Lives = newOpp.Lives - 1;
                                }
                            break;
                        case HorseMange.Weapon.Paper:
                                if (newOpp.Attack() == 0)
                                {
                                    Console.Clear();
                                    synth.Speak("Crinkle Cover.");
                                    Console.WriteLine($"{newOpp.rockLoss[champion]}");
                                    Thread.Sleep(5000);
                                    newOpp.Lives = newOpp.Lives - 1;
                                }
                                else if (newOpp.Attack() == 1)
                                {
                                Console.Clear();
                                synth.Speak("hmm");
                                Console.WriteLine("Nothing happened.");
                                Thread.Sleep(500);
                                }
                                else
                                {
                                Console.Clear();
                                synth.Speak("Snip Snip.");
                                Console.WriteLine($"{newOpp.scissorsWin[champion]}");
                                Thread.Sleep(5000);
                                newHM.Lives = newHM.Lives - 1;
                                }
                            break;
                        case HorseMange.Weapon.Scissors:
                            if (newOpp.Attack() == 0)
                            {
                                Console.Clear();
                                synth.Speak("BOOM!");
                                Console.WriteLine($"{newOpp.rockWin[champion]}");
                                Thread.Sleep(5000);
                                newHM.Lives = newHM.Lives - 1;
                            }
                            else if (newOpp.Attack() == 1)
                            {
                                Console.Clear();
                                synth.Speak("Snip Snip.");
                                Console.WriteLine($"{newOpp.paperLoss[champion]}");
                                Thread.Sleep(5000);
                                newOpp.Lives = newOpp.Lives - 1;
                            }
                            else
                            {
                                Console.Clear();
                                synth.Speak("hmm");
                                Console.WriteLine("Nothing happened.");
                                Thread.Sleep(500);
                            }
                            break;
                    }
                    if (newHM.Lives == 0)
                    {
                        newHM.IsAlive = false;
                        Console.WriteLine($"{newOpp.win[champion]}");
                        Thread.Sleep(5000);
                        Console.WriteLine($"Game over {newHM.Name}. We hope you or another {newHM.Archetype} returns soon.");
                        Thread.Sleep(5000);
                        isRunning = false;
                    }
                    if (newOpp.Lives == 0)
                    {
                        newOpp.IsAlive = false;
                        Console.WriteLine($"{newOpp.loss[champion]}");
                        Thread.Sleep(5000);
                        Console.Clear();
                        Console.WriteLine($"Congratulations {newHM.Name} of Clan {newHM.Archetype} you are the new champion of Roshambo.");
                        Thread.Sleep(5000);
                        Console.WriteLine("Would you like to view the secret ending?");
                        Thread.Sleep(3000);
                        Console.WriteLine("0: Of Course!\n" +
                                      "1: Nah. I'm Fine");
                        int endChoice = Int32.Parse(Console.ReadLine());
                        if (endChoice == 0)
                        {
                            Console.Clear();
                            Console.WriteLine("What is your true name? (HINT: 2 words, 5 letters each, you may have heard it in this game, use proper capitalization)");
                            string trueName = Console.ReadLine();
                            if (trueName == "Horse Mange")
                            {
                                Console.Clear();
                                Console.WriteLine("SecretMessage");
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("I apologize. That was not the right answer.");
                            }
                        }
                        isRunning = false;
                    }
                }
            }
            Console.ReadLine();
       }
    }
}
