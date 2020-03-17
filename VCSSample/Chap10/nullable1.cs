using System;
namespace Chap10_null1
{
    class MainClass
    {
        static void Main()
        {
            // nullが代入できる
            int? x = null;

            if (!x.HasValue) // 値がないなら
            {
                Console.WriteLine("null");  // 出力値：null
            }

            x = 10;
            if (x.HasValue) // 値があれば
            {
                Console.WriteLine(x.Value); // 出力値：10
            }

            Console.WriteLine(x == 10);     // 出力値：True
            Console.WriteLine(x + 10);      // 出力値：20
        }
    }
}