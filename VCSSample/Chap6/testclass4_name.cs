using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap6_name
{
    class TestClass
    {
        // 2つのパラメーターを受け取ってint型の値を返すメソッド
        public int CalcAdd(int a, int b)
        {
            return a + b; // パラメーターのaとbを加算して返す
        }
    }

    class MainClass
    {
        static void Main()
        {
            TestClass test = new TestClass();

            int p = 4;

            // どちらも同じ呼び出しになる
            int a = test.CalcAdd( a: 3, b: p );   // メソッドの呼び出し
            int b = test.CalcAdd( b: p, a: 3 );   // メソッドの呼び出し

            Console.WriteLine(a);               // 出力値：7
            Console.WriteLine(b);               // 出力値：7
        }
    }
}