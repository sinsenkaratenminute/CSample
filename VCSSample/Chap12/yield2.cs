using System;
using System.Collections.Generic;
using System.Linq;
namespace Chap12_21
{
    class MainClass
    {
        static void Main()
        {
            // 1`number‚Ü‚Å‚ğ—ñ‹“‚·‚éŠÖ”
            IEnumerable<int> factorial( int number )
            {
                if ( (number < 1) || (100 < number) )
                {
                    Console.WriteLine("error");
                    yield break;

                }
                for ( int i = number; 0 < i; i-- )
                {
                    yield return i;
                }
            }

            foreach ( int v in factorial( 101 ) )
            {
                Console.WriteLine( v );
            }
        }

    }
}
