using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap6_9
{
    class TestClass
    {
        // aを3倍して表示する
        public void TestFunc(int a)
        {
            // パラメーターの変数aを3倍
            a *= 3;

            Console.WriteLine(a);
        }
    }

    class MainClass
    {
        static void Main()
        {
            TestClass test = new TestClass();
            int a = 5;

            test.TestFunc(a);     // 出力値：15
            Console.WriteLine(a); // 出力値：5
        }
    }
}