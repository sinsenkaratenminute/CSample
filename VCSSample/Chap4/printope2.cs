using System;

namespace Chap4_5
{
    class MainClass
    {
        static void Main()
        {
            int a = 2;  // 2êiêîÇ≈ÇÕ0000 0010
            int b = 15; // 2êiêîÇ≈ÇÕ0000 1111

            Console.WriteLine( Convert.ToString( a & b, 2 ) );
            Console.WriteLine( Convert.ToString( a | b, 2 ) );
            Console.WriteLine( Convert.ToString( a ^ b, 2 ) );
            Console.WriteLine( Convert.ToString( ~a, 2 ) );
        }
    }
}
