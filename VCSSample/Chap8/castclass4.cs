using System;
namespace Chap8_type1
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
            if (s != null)
            {
                s.BaseInfo();  // 出力値：Song
            }
            // ダウンキャストできる場合はs2が定義される
            if (m is Song s2)
            {
                s2.BaseInfo();  // 出力値：Song
            }

            Music2 m2 = m as Music2;
            if (m2 != null)
            {
                m2.BaseInfo();
            }

            if (m is Music2 m3)
            {
                m3.BaseInfo();
            }
        }
    }
}
