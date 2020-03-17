using System;
namespace Chap11_2
{
    // SampleDel�Ƃ������O�̃f���Q�[�g���`
    delegate void SampleDel(int x);

    class TestClass
    {
        public void TestMethod1(int n)
        {
            Console.WriteLine(n);
        }

        // �ÓI���\�b�h
        public static void testMethod2(int n)
        {
            Console.WriteLine(n * 2);
        }
    }

    class MainClass
    {
        public static void Main()
        {
            // TestClass�̃C���X�^���X��
            TestClass t = new TestClass();

            // �C���X�^���X���\�b�h�̓o�^
            SampleDel delVar = t.TestMethod1;

            delVar(123);        // �o�͒l�F123

            // �ÓI���\�b�h�̓o�^�i�����ϐ��ɑ���ł���j
            delVar = TestClass.testMethod2;

            delVar(123);        // �o�͒l�F246
        }
    }
}