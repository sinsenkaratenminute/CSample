using System;
namespace Chap11_over1
{
    class TestClass
    {
        int num;
        string str;

        public TestClass(int num, string str)
        {
            this.num = num;
            this.str = str;
        }

        public void Output()
        {
            Console.WriteLine(this.num);
            Console.WriteLine(this.str);
        }

        // +演算子のユーザー定義
        public static TestClass operator +(TestClass a, TestClass b)
        {
            return new TestClass(a.num + b.num, a.str + b.str);
        }
    }

    class MainClass
    {
        public static void Main()
        {
            TestClass a = new TestClass(1, "演算子");
            TestClass b = new TestClass(2, "オーバーロード");

            TestClass c = a + b;
            c.Output();
        }
    }
}