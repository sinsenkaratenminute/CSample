using System;
namespace Chap11_3
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
        // �f���Q�[�g�^�ϐ����p�����[�^�Ƃ������\�b�h
        public static void MethodCallback(int p, SampleDel delVar)
        {
            // �f���Q�[�g��������\�b�h�̌Ăяo��
            delVar(p);
        }

        public static void Main()
        {
            TestClass t = new TestClass();

            // �p�����[�^�Ƃ��ă��\�b�h��n��
            MethodCallback(10, t.TestMethod1);          // �o�͒l�F10
            MethodCallback(10, TestClass.testMethod2);  // �o�͒l�F20
        }
    }
}