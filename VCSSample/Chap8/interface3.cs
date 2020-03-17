using System;
namespace Chap8_11
{
    // ��{�C���^�[�t�F�C�X1
    interface IBaseInterface1
    {
        void Method1(int a);
    }

    // ��{�C���^�[�t�F�C�X2
    interface IBaseInterface2
    {
        void Method2(string s);
    }

    // �h���C���^�[�t�F�C�X
    interface ISampleInterface : IBaseInterface1, IBaseInterface2
    {
        void Method3();
    }

    // �h���C���^�[�t�F�[�X�̎���
    class Sample : ISampleInterface
    {
        public void Method1(int a)
        {
            Console.WriteLine(a);
        }

        public void Method2(string s)
        {
            Console.WriteLine(s);
        }

        public void Method3()
        {
            Console.WriteLine("method3");
        }
    }

    class MainClass
    {
        static void Main()
        {
            Sample s = new Sample();
            s.Method1(123);             // �o�͒l�F123
            s.Method2("test");          // �o�͒l�Ftest
            s.Method3();                // �o�͒l�Fmethod3
        }
    }
}