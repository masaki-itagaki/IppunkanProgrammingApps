using OneMinCoding.Speech;
using System;
using System.IO;
using System.Text;

namespace ChatTrainer
{
    class Program_CT7
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
                switch (mode)
                {
                    //1: 会話を聴くだけを選択したら、
                    case "1":
                        //各行を音声と画面表で出す。
                        VoiceWin.ReadChatLine(line, true, true, out English);
                        Console.WriteLine();//空行を入れる
                        break;

                    //A: Aの話者を練習
                    case "A":
                        //もし行がAの会話だったら、英語を伏せて練習させる
                        if (line.StartsWith("A"))
                        {
                            //WithEnglishをfalseにすると英語は非表示に
                            VoiceWin.ReadChatLine(line, false, true, out English);
                            Console.Write("YOUR TURN -> "); //「あなたの番」と表示
                            Console.Beep();//ビープを鳴らして発話を促す
                            //ユーザーの話した英語を認識させる
                            Console.WriteLine(VoiceWin.Recognize("en-US"));
                            //Englishの中に正解の英語が入っているのでそれを表示
                            Console.WriteLine("MY TURN ->" + English);
                            Console.WriteLine();//空行を入れる
                        }
                        //その他はBから始まる行（のはず）なので、普通に音声と画面表示を出す
                        else
                        {
                            VoiceWin.ReadChatLine(line, true, true, out English);
                            Console.WriteLine();//空行を入れる
                        }
                        break;

                    //0: 発音繰り返しトレーニング
                    case "0":
                        while (true)
                        {
                            Console.WriteLine("Say something ...");
                            Console.Beep();
                            //音声認識したテキストをrecoに入れる
                            string reco = VoiceWin.Recognize("en-US");
                            Console.WriteLine(reco); //認識テキストを表示
                            //もしユーザーが"stop"と言ったらループを終了
                            if (reco.ToLower() == "stop")
                                break; //これでループを抜ける
                            Console.WriteLine();//空行を入れる
                        }
                        break;
                }
            }

            //コンソール画面をホールドする
            Console.ReadLine();
        }
    }
}
