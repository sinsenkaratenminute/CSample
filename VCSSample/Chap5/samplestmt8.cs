using System;
namespace Chap5_8
{

    class MainClass
    {
        static void Main()
        {
            int i = 10;

            do
            {
                Console.WriteLine( ++i );    // 出力結果は11となる。
            }
            while ( i < 5 );
        }
    }
}
