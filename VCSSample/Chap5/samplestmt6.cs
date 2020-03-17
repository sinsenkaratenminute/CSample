using System;
namespace Chap5_6
{

    class MainClass
    {
        static void Main()
        {
            for ( int i = 0, j = 0; i + j < 10; i++, j += 2 )
            {
                Console.WriteLine( "{0},{1}", i, j );
            }
        }
    }
}
