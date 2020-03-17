using System;
namespace Chap10_null2
{
    class MainClass
    {
        static void Main()
        {
            int? a = null;
            Console.WriteLine(a ?? 10); // 出力値：10

            a = 5;
            Console.WriteLine(a ?? 10); // 出力値：5

            // 参照型でも使える
            string s = null;
            Console.WriteLine(s ?? "Empty"); // 出力値：Empty
        }
    }
}
