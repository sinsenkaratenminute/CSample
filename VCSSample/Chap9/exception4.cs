using System;
namespace Chap9_4
{
    class MainClass
    {
        static void Main()
        {
            try
            {
                int a = 0;
                int b = 0;
                a /= b;         // �[�����Z�̗�O����������
            }
            catch (Exception e)
            {
                // Message�v���p�e�B�̕\��
                Console.WriteLine(e.Message);
            }
        }
    }
}