using System;
namespace Chap9_10
{
    class MainClass
    {
        static void Main()
        {
            try
            {
                // �I�[�o�[�t���[�����o
                checked
                {
                    short a = short.MaxValue;   // short�^�̍ő�l����
                    Console.WriteLine(a);

                    a++;                        // �I�[�o�[�t���[ 
                    Console.WriteLine(a);
                }
            }
            catch (Exception e)               // ���ׂĂ̗�O�̕ߑ�
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
