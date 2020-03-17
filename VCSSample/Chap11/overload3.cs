using System;
namespace Chap11_over3
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

        // �����I�ȕϊ�
        public static explicit operator TestClass(int num)
        {
            return new TestClass(num, "�����I");
        }

        // �ÖٓI�ȕϊ�
        public static implicit operator TestClass(string str)
        {
            return new TestClass(0, str);
        }
    }

    class MainClass
    {
        public static void Main()
        {
            // �����I�ȕϊ�
            TestClass a = (TestClass)3;
            a.Output();

            // �ÖٓI�ȕϊ�
            TestClass b = "�ÖٓI";
            b.Output();
        }
    }
}