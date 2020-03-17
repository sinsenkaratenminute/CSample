using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap6_10
{
    class TestClass
    {
        // aを３倍して表示する
        public void TestFunc(ref int a)
        {
            a *= 3; // パラメーターの変数aを3倍

            Console.WriteLine(a);
        }
    }

    class MainClass
    {
        static void Main()
        {
            TestClass test = new TestClass();
            int a = 5;               // 初期化が必要

            test.TestFunc(ref a);  // 出力値：15
            Console.WriteLine(a);  // 出力値：15
        }
    }
}