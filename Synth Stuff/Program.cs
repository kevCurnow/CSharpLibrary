using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Speech.Synthesis;
using System.Threading.Tasks;

namespace Synth_Stuff
{
    class Program
    {
        static void Main(string[] args)
        {
            SpeechSynthesizer synth = new SpeechSynthesizer();
            foreach (InstalledVoice voice in synth.GetInstalledVoices())
            {// Write information about the voice to the console.
                Console.WriteLine(" Name:          " + synth.Voice.Name);
                Console.WriteLine(" Culture:       " + synth.Voice.Culture);
                Console.WriteLine(" Age:           " + synth.Voice.Age);
                Console.WriteLine(" Gender:        " + synth.Voice.Gender);
                Console.WriteLine(" Description:   " + synth.Voice.Description);
                Console.WriteLine(" ID:            " + synth.Voice.Id);
            }
            Console.ReadLine();
        }
    }
}
