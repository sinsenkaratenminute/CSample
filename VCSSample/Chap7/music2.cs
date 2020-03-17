using System;

namespace Chap7_2
{
    // 基本クラス
    class Music
    {
        public Music()                  // 2. 基本クラスのコンストラクター実行
        {
            Console.WriteLine("基本クラスのコンストラクター");
        }
    }

    // 派生クラス
    class Song : Music
    {
        public string Key = "C#";       // 1. フィールドの初期化

        public Song()                   // 3. 派生クラスのコンストラクター実行
        {
            Console.WriteLine("派生クラスのコンストラクター");
        }
    }

    class MainClass
    {
        static void Main()
        {
            Song s = new Song();
        }
    }
}