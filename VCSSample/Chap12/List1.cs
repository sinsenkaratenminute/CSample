using System;
using System.Collections.Generic;
namespace Chap12_2
{
    class MainClass
    {
        static void Main()
        {
            // string型のListとしてインスタンス化
            List<string> slist = new List<string>();

            slist.Add("Hello");
            slist.Add("World");

            // インデックスによる参照（キャスト不要）
            string s = slist[1];    // 出力値：World

            Console.WriteLine(s);
        }
    }
}
