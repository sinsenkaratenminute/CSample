using System;
namespace Chap8_12
{
    interface IBaseInterface1
    {
        void PrintOut(string s);
    }

    interface IBaseInterface2
    {
        void PrintOut(string t);   // INterface1�Ɠ������\�b�h
    }

    // �C���^�[�t�F�C�X�̎���
    class SampleClass : IBaseInterface1, IBaseInterface2
    {
        public void PrintOut(string s)
        {
            Console.WriteLine("Interface0 : " + s);
        }

        // �����I�ȃC���^�[�t�F�C�X�̐錾
        void IBaseInterface1.PrintOut(string s)
        {
            Console.WriteLine("Interface1 : " + s);
        }

        // �����I�ȃC���^�[�t�F�C�X�̐錾
        void IBaseInterface2.PrintOut(string s)
        {
            Console.WriteLine("Interface2 : " + s);
        }
    }

    class MainClass
    {
        static void Main()
        {
            SampleClass mc = new SampleClass();

            mc.PrintOut("0");                   // �o�͒l�F"Interface0 : 0"

            IBaseInterface1 ifc1 = (IBaseInterface1)mc;   // �C���^�[�t�F�C�X�ɕϊ�
            ifc1.PrintOut("1");                 // �o�͒l�F"Interface1 : 1"

            IBaseInterface2 ifc2 = (IBaseInterface2)mc;   // �C���^�[�t�F�C�X�ɕϊ�
            ifc2.PrintOut("2");                 // �o�͒l�F"Interface2 : 2"
        }
    }
}