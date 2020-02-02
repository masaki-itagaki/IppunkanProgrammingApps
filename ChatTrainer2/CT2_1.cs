using System;
using System.Text;
using IppunCore.Speech;

namespace CT2_1
{
    class Program
    {
        //自分で取得したAzure音声サービスのサブスクリプションキー（APIキー）を指定。
        //二重引用符の中にキーの文字列をコピペします
        const string subKeyJ = "ここに自分のAPIキーを入れる"; 

        static void Main(string[] args)
        {
            //日本語と英語で話すテキストを文字列変数、textJとtextEに入れる
            string textJ = "何か英語で話してください";
            string textE = "Sure. This is my first computer voice.";
            
            //まずは日本語を話す。Regionには"japaneast"を指定。
            Voice.SpeakJapanese(textJ, "Haruka", subKeyJ, "japaneast");
            //次に英語を話す。
            Voice.SpeakEnglish(textE, "Ben", subKeyJ, "japaneast");

            //注：Vocei名は男女の声別にいくつか選択できます。
            //日本語のVoiceNameは、Haruka, Ayumi, Ichiroの３つ
            //英語のVoiceNameは、Ben, Guy, Jessa, Ziraの４つから選ぶ


            Console.ReadLine();
        }

    }
}
