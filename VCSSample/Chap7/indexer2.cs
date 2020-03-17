using System;
using System.Collections.Generic;
namespace Chap7_13
{
    class MainClass
    {
        static void Main()
        {
            Dictionary<string, string> dict = new Dictionary<string, string>();

            dict["Mon"] = "月";  // 要素の追加
            dict["Tue"] = "火";  // 〃

            Console.WriteLine(dict["Mon"]); // 出力値：月
        }
    }
}
