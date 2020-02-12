using System;
using System.Text;
using IppunCore.Speech; //Nugetを参照した上で、このパッケージを指定する

namespace ChatTrainer2
{
    class Program
    {
        static void Main(string[] args)
        {
            //サブスクリプションキーをここに入れておく
            const string subKey = "[あなたのSubscriptionキーをここにコピペ]";
            //リージョン名をここに入れておく
            const string region = "japaneast"; //東日本なのでjapaneastを指定


            //1. 「英語にしたいことを言ってください」と表示する（音声でも）
            
            //画面指示を表示
            Console.WriteLine("英語にしたいことを話してください…");
            //音声でも指示を聞かせる。ボイス名はHarukkaを選択。
            Voice.SpeakJapanese("英語にしたいことを話してください", "Haruka", subKey, region);
            //ビープを鳴らして音声のキューを出す
            Console.Beep();

            //2. ユーザーが話した日本語を音声認識する。

            //音声認識された日本語を入れておく変数を用意。空（Empty)の文字列を入れておく。
            string recoJ = string.Empty;
            //日本語を音声認識して、さらにそれを英語に翻訳。
            //recoJには認識された日本のg、recoEにはそれを翻訳した英語が入る。
            string recoE = Voice.Recognize(subKey, region, "ja-JP", "en", out recoJ);
            //話した日本語を表示
            Console.WriteLine("日本語：" + recoJ);
            Console.WriteLine();

            //3. 認識した日本語を英語に翻訳し、それを音声で聞かせる
            //  この時は音声のみで、ユーザーには聞いてもらうだけ

            //4. ユーザーがシャドーで同じ英語を話す。それを音声認識させる。

            //5. 音声認識した英語を、翻訳した英語と比較させる

            //6. 正解（翻訳英語）とユーザーの英語がどれだけ違っているかで点数をつける

        }
    }
}
