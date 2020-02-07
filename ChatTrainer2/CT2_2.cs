using System;
using System.Collections.Generic;
using System.Text;
using IppunCore.Speech;

namespace IppunCoreTest
{
    class CT2_2
    {
        //自分で取得したAzure音声サービスのサブスクリプションキー（APIキー）を指定。
        //二重引用符の中にキーの文字列をコピペします
        const string subKey = "ここに自分のAPIキーを入れる";

        static void Main(string[] args)
        {
            //Whileブロックを何度も繰り返します
            while (true)
            {
                //画面で「何か話して」と表示
                Console.WriteLine("Speak English or Japanese ...");
                //同時に音声でも指示
                Voice.SpeakEnglish("Speak something in English or Japanese", "Ben", subKey, "eastjapan");
                //話すキューを出すためにビープ音を鳴らす
                Console.Beep();
                //音声認識（Recognize)で、その結果をrecoという文字列配列に入れる
               string reco = Voice.Recognize(subKey, "eastjapan");
                //画面に「あなたが言ったのは」と表示し、
                Console.Write("You said: ");
                //認識したテキストを表示させる
                Console.WriteLine(reco);

                Console.WriteLine();
            }

        }
    }
}
