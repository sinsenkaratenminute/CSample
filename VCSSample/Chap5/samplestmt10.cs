using System;
namespace Chap5_10
{
    class MainClass
    {
        static void Main()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
            }

            // 変数iは存在しないというコンパイルエラーになる
            // Console.WriteLine(i);
        }
    }
}
