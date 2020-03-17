using System;

namespace Chap7_1
{
    // 基本クラス
    class Music
    {
        public int Type = 0;
        public string Name = "Music";

        public void BaseInfo()
        {
            Console.WriteLine("Music");
        }
    }

    // 派生クラス
    class Song : Music
    {
        public string Key = "C#";

        public void DrvInfo()
        {
            Console.WriteLine("Song");
        }
    }

    class MainClass
    {
        static void Main()
        {
            Song s = new Song();         // 派生クラスのインスタンス

            Console.WriteLine(s.Key);    // 出力値："C#"
            s.DrvInfo();                 // 出力値："Song"

            // 基本クラスのメンバーにアクセスできる
            Console.WriteLine(s.Type); // 出力値：0
            s.BaseInfo();                // 出力値："Music"

            Music m = new Music();       // 基本クラスのインスタンス

            Console.WriteLine(m.Type); // 出力値：0
            m.BaseInfo();                // 出力値："Music"
        }
    }
}