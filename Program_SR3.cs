using System;
using OneMinCoding.Speech;

namespace IppunkanProgrammingApps
{
    class Program_SR3
    {
        /// <summary>
        /// Pronunciation training app - "This is good", "It it good"
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //Repeat asking for a voice input
            while (true)
            {
                Console.Write("Say, 'This ... is good': ");
                VoiceWin.Speak("Say, this. is good", "en-US");
                Console.Beep(); //Make a beep sound
                string reco = VoiceWin.Recognize("en-US");
                //Display the recognized text
                Console.WriteLine(reco);

                Console.Write("Say, 'This is good': ");
                VoiceWin.Speak("Say, this is good", "en-US");
                Console.Beep(); //Make a beep sound
                reco = VoiceWin.Recognize("en-US");
                //Display the recognized text
                Console.WriteLine(reco);

            }
        }
    }
}
