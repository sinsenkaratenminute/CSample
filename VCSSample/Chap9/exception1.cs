using System;
namespace Chap9_1
{
    class MainClass
    {
        static void Main()
        {
            try
            {
                int a = 10;
                int b = 0;

                Console.WriteLine("try");

                a /= b;         // �[�����Z�̗�O����������

                Console.WriteLine("�G���[");
            }
            catch
            {
                Console.WriteLine("��O����");
            }
        }
    }
}
