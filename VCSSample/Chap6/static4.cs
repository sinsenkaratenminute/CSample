using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap6_static4
{
    static class ClassStatic
    {
        // 静的メンバー
        public static int a;

        // 静的コンストラクター
        static ClassStatic()
        {
            a = 5;
        }

        // 静的メソッド
        public static void Display()
        {
            Console.WriteLine(a); // 静的メソッドの呼び出し
        }
    }

    class MainClass
    {
        static void Main()
        {
            ClassStatic.Display(); // 出力値：5
        }
    }
}