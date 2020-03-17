using System;
namespace Chap11_3
{
    // SampleDelという名前のデリゲートを定義
    delegate void SampleDel(int x);

    class TestClass
    {
        public void TestMethod1(int n)
        {
            Console.WriteLine(n);
        }

        // 静的メソッド
        public static void testMethod2(int n)
        {
            Console.WriteLine(n * 2);
        }
    }

    class MainClass
    {
        // デリゲート型変数をパラメータとしたメソッド
        public static void MethodCallback(int p, SampleDel delVar)
        {
            // デリゲートを介したメソッドの呼び出し
            delVar(p);
        }

        public static void Main()
        {
            TestClass t = new TestClass();

            // パラメータとしてメソッドを渡す
            MethodCallback(10, t.TestMethod1);          // 出力値：10
            MethodCallback(10, TestClass.testMethod2);  // 出力値：20
        }
    }
}