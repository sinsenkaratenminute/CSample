using System;
using System.Collections.Generic;
namespace Chap12_3
{
    class MainClass
    {
        static void Main()
        {
            // コレクション初期化子を用いた定義
            var list = new List<string>() { "Hello", "World", "Good-Bye" };

            // foreachによるデータ参照
            foreach (var s in list)
            {
                Console.WriteLine(s);
            }

        }
    }
}