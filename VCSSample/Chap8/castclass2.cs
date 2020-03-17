using System;
namespace Chap8_2
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
            Song s = (Song)m;

            Console.WriteLine(m is Song);   // 出力値：True
            Console.WriteLine(m is Music2); // 出力値：False
        }
    }
}