using System;
namespace Chap11_over2
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

        // true演算子の定義
        public static bool operator true(TestClass a)
        {
            return (a.num != 0) && (a.str != null);
        }

        // false演算子の定義
        public static bool operator false(TestClass a)
        {
            return (a.num == 0) && (a.str == null);
        }
    }

    class MainClass
    {
        // true、falseの判定
        public static void BoolTest(TestClass t)
        {
            // true演算子で判断
            if (t)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
        }

        public static void Main()
        {
            TestClass a = new TestClass(1, "演算子");
            TestClass b = new TestClass(0, null);

            BoolTest(a);    // 出力値：true
            BoolTest(b);    // 出力値：false
        }
    }
}