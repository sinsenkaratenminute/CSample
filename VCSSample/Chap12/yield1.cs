using System;
using System.Collections.Generic;
using System.Linq;
namespace Chap12_20
{
    class MainClass
    {
        static void Main()
        {
            // 1`number‚Ü‚Å‚ğ—ñ‹“‚·‚éŠÖ”
            IEnumerable<int> factorial( int number )
            {
                for ( int i = number; 0 < i; i-- )
                {
                    yield return i;
                }
            }

            foreach ( int v in factorial( 3 ) )
            {
                Console.WriteLine( v );
            }
        }

    }
}
