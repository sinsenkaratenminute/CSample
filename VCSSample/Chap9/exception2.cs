using System;
namespace Chap9_2
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
            catch
            {
                Console.WriteLine("��O����");
            }
            finally
            {
                Console.WriteLine("�I��");
            }
        }
    }
}