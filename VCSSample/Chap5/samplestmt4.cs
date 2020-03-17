using System;
namespace Chap5_4
{

    class MainClass
    {
        static void Main()
        {
            int month = DateTime.Now.Month; // Œ»İ‚ÌŒ‚ğæ“¾

            switch (month)
            {
                //case 7:
                //    Console.WriteLine( "Œ±" );   // C#‚Å‚ÍƒGƒ‰[
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