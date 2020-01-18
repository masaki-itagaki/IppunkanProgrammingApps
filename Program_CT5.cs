using System;
using System.IO;
using System.Text;
using OneMinCoding.Speech;

namespace ChatTrainer
{
    class Program_CT5
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
            Console.WriteLine();

            //===========================
            //Step 2: トレーニング開始
            //===========================

            //Chat.txtを読む。すべての行が文字列配列のlinesに。
            string[] lines = File.ReadAllLines("Chat.txt", Encoding.Unicode);

            //英文をキープする入れ物
            string English = string.Empty;

            //linesを一行ずつ読む
            foreach (string line in lines)
            {
                //1: 会話を聴くだけを選択したら、
                if (mode == "1")
                {
                    //各行を音声と画面表で出す。
                    VoiceWin.ReadChatLine(line, true, true, out English);
                    Console.WriteLine();//空行を入れる
                }
                //0:発音を繰り返しトレーニングするモードを選択したら、
                else if (mode == "0")
                {
                    //whileブロックの中を永遠と繰り返すループ
                    while (true)
                    {
                        //何か言って、と指示する
                        Console.WriteLine("Say something ...");
                        Console.Beep(); //ビープを鳴らす
                        //英語で音声を認識して、その結果の文字列を表示する。
                        Console.WriteLine(VoiceWin.Recognize("en-US"));
                    }
                }
            }

            //コンソール画面をホールドする
            Console.ReadLine();
        }
    }
}
