using System;
namespace Chap9_7
{
    class MainClass
    {
        // catch�u���b�N�ŗ�O���X���[���郁�\�b�h
        static void ExceptionMethod()
        {
            try
            {
                // �z��̐錾
                int[] a = new int[3];

                a[0] = 1;
                a[5] = 2;       // ��O�i�͈͊O�ɃA�N�Z�X�j
            }
            catch ( Exception )
            {
                Console.WriteLine("�ŏ��̕ߑ�");

                // ��O���ăX���[
                throw new IndexOutOfRangeException();
            }
        }

        static void Main()
        {
            try
            {
                // ��O���X���[����郁�\�b�h�̌Ăяo��
                ExceptionMethod();
            }
            catch (Exception e)   // ���ׂĂ̗�O�̕ߑ�
            {
                Console.WriteLine("�O���̕ߑ�");
                Console.WriteLine(e.Message);
            }
        }
    }
}