using System;

namespace Chap7_3
{
    // 基本クラス
    class BaseClass
    {
        public BaseClass(string s)
        {
            Console.WriteLine(s);
        }
    }

    // 派生クラス
    class DerivedClass : BaseClass
    {
        // baseキーワードで、パラメーターを指定
        public DerivedClass(string s1, string s2) : base(s2)
        {
            Console.WriteLine(s1);
        }
    }

    class MainClass
    {
        static void Main()
        {
            var c = new DerivedClass("Derived", "Base");
        }
    }
}