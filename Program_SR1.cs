using System;
using OneMinCoding.Speech;

namespace IppunkanProgrammingApps
{
    class Program_SR1
    {
        static void Main(string[] args)
        {
            VoiceWin.Speak("Say something after the beep.", "en-US");
            Console.Beep();
            string reco = VoiceWin.Recognize("en-US"); 
            Console.WriteLine(reco);

            Console.ReadLine();
        }
    }
}
