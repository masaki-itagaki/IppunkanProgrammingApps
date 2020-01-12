using OneMinCoding.Speech;
using System;
using System.Text;

namespace ChatTrainer
{
    class Program
    {
        static void Main(string[] args)
        {
            //===========================
            //Step 1: アプリ始動時のユーザー指示
            //===========================
            //モード選択の指示
            string modeInstruction = "トレーニングモードを選択してください: ";
            Console.WriteLine(modeInstruction); //画面表示
            VoiceWin.Speak(modeInstruction, "ja-JP");//音声指示
            
            //モードの紹介
            Console.WriteLine("=======================");
            Console.WriteLine("1: 会話を聴くだけ");
            Console.WriteLine("AかB: AかBの話者を練習");
            Console.WriteLine("2: ランダムトレーニング");
            Console.WriteLine("3: 会話ポイントゲーム");
            Console.WriteLine("0: 発音繰り返しトレーニング");
            Console.WriteLine("=======================/n");
            Console.Write("番号を入力：");

            //選択番号をmodeに入れる。大文字化する。
            string mode = Console.ReadLine().ToUpper();
        }
    }
}
