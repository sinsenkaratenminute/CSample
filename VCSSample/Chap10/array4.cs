using System;
namespace Chap10_5
{
    class MainClass
    {
        static void Main()
        {
            // 2次元配列
            string[,] a = { { "一", "二" }, { "三", "四" }, { "五", "六" } };

            // 2次元配列を表現して出力する
            for (int i = 0; i < a.Length / a.Rank; i++)
            {
                // 次元の数だけ横に表示
                for (int j = 0; j < a.Rank; j++)
                {
                    Console.Write(a[i, j] + " ");
                }
                Console.WriteLine(""); // 改行
            }
        }
    }
}
