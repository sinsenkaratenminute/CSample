using System;
namespace Chap4_6
{
    class MainClass
    {
        static void Main()
        {
            int a = 162; // 16�i���\�L�ł́A0xA2

            // 2�i��������ɕϊ�
            Console.WriteLine( Convert.ToString( a, 2 ) );      // �o�͒l�F00010100010
            Console.WriteLine( Convert.ToString( a << 3, 2 ) ); // �o�͒l�F10100010000
            Console.WriteLine( Convert.ToString( a >> 3, 2 ) ); // �o�͒l�F00000010100
        }
    }
}
