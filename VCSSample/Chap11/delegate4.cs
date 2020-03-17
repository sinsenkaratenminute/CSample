using System;
namespace Chap11_4
{
    class MainClass
    {
        // �f���Q�[�g�̒�`
        delegate int SampleDel(int x);

        class TestClass
        {
            public int TestMethod1(int n)
            {
                return n * 10;
            }

            public int TestMethod2(int n)
            {
                return n * 20;
            }
        }
        public static void Main()
        {
            TestClass t = new TestClass();

            SampleDel delVar = t.TestMethod1;

            // TestMethod2��ǉ�
            delVar += t.TestMethod2;

            // TestMethod1��TestMethod2�����s�����
            Console.WriteLine(delVar(10));     // �o�͒l�F200

            // TestMethod2�̍폜
            delVar -= t.TestMethod2;

            // TestMethod1�̂ݎ��s�����
            Console.WriteLine(delVar(10));    // �o�͒l�F100
        }
    }

}