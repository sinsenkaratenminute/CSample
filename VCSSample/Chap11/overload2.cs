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

        // true���Z�q�̒�`
        public static bool operator true(TestClass a)
        {
            return (a.num != 0) && (a.str != null);
        }

        // false���Z�q�̒�`
        public static bool operator false(TestClass a)
        {
            return (a.num == 0) && (a.str == null);
        }
    }

    class MainClass
    {
        // true�Afalse�̔���
        public static void BoolTest(TestClass t)
        {
            // true���Z�q�Ŕ��f
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
            TestClass a = new TestClass(1, "���Z�q");
            TestClass b = new TestClass(0, null);

            BoolTest(a);    // �o�͒l�Ftrue
            BoolTest(b);    // �o�͒l�Ffalse
        }
    }
}