using System;
namespace Chap4_3
{
    class MainClass
    {
        static void Main()
        {
            int a = 5;

            Console.WriteLine( ++a );   // �o�͒l�F6
            Console.WriteLine( a );     // �o�͒l�F6

            int b = 5;

            Console.WriteLine( b++ );   // �o�͒l�F5
            Console.WriteLine( b );     // �o�͒l�F6
        }
    }
}
