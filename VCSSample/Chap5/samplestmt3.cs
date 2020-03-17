using System;
namespace Chap5_3
{

    class MainClass
    {
        static void Main()
        {
            int month = DateTime.Now.Month; // Œ»İ‚ÌŒ‚ğæ“¾

            switch (month)
            {
                case 1:
                    Console.WriteLine( "–rŒ" );
                    break;
                case 2:
                    Console.WriteLine( "”@Œ" );
                    break;
                case 3:
                    Console.WriteLine( "–í¶" );
                    break;
                case 7:
                case 8:
                    Console.WriteLine( "‰Ä‹x‚İ" );
                    break;
                default:
                    Console.WriteLine( month + "Œ" );
                    break;
            }
        }
    }
}