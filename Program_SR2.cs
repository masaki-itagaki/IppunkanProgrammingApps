using System;
using OneMinCoding.Speech;

namespace IppunkanProgrammingApps
{
    class Program_SR2
    {
        /// <summary>
        /// This app repeatedly ask for a voice input. 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //Set an instruction string
            string instuction = "Say something in English after the beep";
            Console.WriteLine(instuction); //Display the instruction
            VoiceWin.Speak(instuction, "en-US"); //Voice the instruction
            
            //Repeat asking for a voice input
            while (true)
            {
                Console.Beep(); //Make a beep sound
                //Recognized voice is put in "reco"
                string reco = VoiceWin.Recognize("en-US");
                //Display the recognized text
                Console.WriteLine(reco);
            }
        }
    }
}
