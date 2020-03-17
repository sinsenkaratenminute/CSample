using System;
namespace Chap5_8
{

    class MainClass
    {
        static void Main()
        {
            int i = 10;

            do
            {
                Console.WriteLine( ++i );    // o—ÍŒ‹‰Ê‚Í11‚Æ‚È‚éB
            }
            while ( i < 5 );
        }
    }
}
