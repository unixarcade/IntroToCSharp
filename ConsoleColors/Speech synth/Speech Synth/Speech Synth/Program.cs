using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Speech_Synth;
using System.Speech.Synthesis;




namespace Speech_Synth
{
    class Program
    {
        static void Main(string[] args) 
        {



            using (SpeechSynthesizer synth = new SpeechSynthesizer())
            {
                synth.Speak("Hello World");
            }

            Console.ReadKey();
        }
    }
}
