using System;
namespace Chap5_2
{

    class MainClass
    {
        static void Main()
        {
            int x = 15;

            if ( x < 10 )
            {
                x *= 10;
            }
            else
            {
                x = -x;
            }
            Console.WriteLine( x );  // o—Í’lF-15
        }
    }
}
