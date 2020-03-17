using System;
namespace Chap4_3
{
    class MainClass
    {
        static void Main()
        {
            int a = 5;

            Console.WriteLine( ++a );   // 出力値：6
            Console.WriteLine( a );     // 出力値：6

            int b = 5;

            Console.WriteLine( b++ );   // 出力値：5
            Console.WriteLine( b );     // 出力値：6
        }
    }
}
