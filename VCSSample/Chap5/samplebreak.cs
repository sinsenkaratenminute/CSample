using System;
namespace Chap5_15
{

    class MainClass
    {
        static void Main()
        {
            for ( int i = 0; true; i++ )
            {
                if ( i == 3 )  // •Ï”i‚ª3‚Ìê‡
                {
                    break;     // ƒ‹[ƒv‚ğ’†’f‚·‚é
                }
                Console.WriteLine( i );
            }
        }
    }
}
