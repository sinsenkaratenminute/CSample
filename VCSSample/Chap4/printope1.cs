using System;

namespace Chap4_4
{
    class MainClass
    {
        static void Main()
        {
            int x = -5;

            Console.WriteLine( x >= 0 ? x : -x );    // �o�͒l�F5
            Console.WriteLine( x < 0 ? '��' : '��' );  // �o�͒l�F��
        }
    }
}
