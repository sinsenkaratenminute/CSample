using System;
namespace Chap10_null1
{
    class MainClass
    {
        static void Main()
        {
            // null������ł���
            int? x = null;

            if (!x.HasValue) // �l���Ȃ��Ȃ�
            {
                Console.WriteLine("null");  // �o�͒l�Fnull
            }

            x = 10;
            if (x.HasValue) // �l�������
            {
                Console.WriteLine(x.Value); // �o�͒l�F10
            }

            Console.WriteLine(x == 10);     // �o�͒l�FTrue
            Console.WriteLine(x + 10);      // �o�͒l�F20
        }
    }
}