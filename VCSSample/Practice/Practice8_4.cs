
using System;

namespace Practice8_4
{
    class Practice
    {
        static void Main()
        {
            object val = 1;

            if ( val is int n )
            {
                Console.WriteLine( $"値は{n}です" );
            }
        }
    }

}
