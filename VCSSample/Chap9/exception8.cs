using System;
namespace Chap9_8
{
    class MainClass
    {
        static void Main()
        {
            try
            {
                // try�u���b�N�̃l�X�g
                try
                {
                    int[] a = new int[3];

                    a[0] = 1;
                    a[5] = 2;       // ��O�i�͈͊O�ɃA�N�Z�X�j
                }
                catch ( Exception )
                {
                    Console.WriteLine("�ŏ��̕ߑ�");
                    throw;
                }
            }
            catch ( Exception e )    // ���ׂĂ̗�O�̕ߑ�
            {
                Console.WriteLine("�O���̕ߑ�");
                Console.WriteLine(e.Message);
            }
        }
    }
}