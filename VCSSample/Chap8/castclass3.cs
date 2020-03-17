using System;
namespace Chap8_3
{
    // 基本クラス
    class Music
    {
        public virtual void BaseInfo()
        {
            Console.WriteLine("Music");
        }
    }

    // 派生クラス
    class Song : Music
    {
        public override void BaseInfo() // メソッドをオーバーライド
        {
            Console.WriteLine("Song");
        }
    }

    // 派生クラス
    class Music2 : Music
    {
        new public void BaseInfo() // メソッドを隠蔽
        {
            Console.WriteLine("Music2");
        }
    }

    class MainClass
    {
        static void Main()
        {
            Music m = new Song();

            Song s = m as Song;
            Music2 m2 = m as Music2; // ダウンキャストできないので、nullを返す

            Console.WriteLine(s == null);   // 出力値：False
            Console.WriteLine(m2 == null);  // 出力値：True
        }
    }
}
