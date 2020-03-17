using System;

namespace Chap7_3
{
    // ��{�N���X
    class BaseClass
    {
        public BaseClass(string s)
        {
            Console.WriteLine(s);
        }
    }

    // �h���N���X
    class DerivedClass : BaseClass
    {
        // base�L�[���[�h�ŁA�p�����[�^�[���w��
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