using System;
namespace Chap9_13
{
    class MainClass
    {
        static void Main()
        {
            checked
            {
                float x = 1e35f;
                float y = 1e-35f;
                // ��O�Ƃ͂Ȃ�Ȃ�
                Console.WriteLine(x * x);   // �o�͒l�F+��
                Console.WriteLine(y * y);   // �o�͒l�F0
            }
        }
    }
}