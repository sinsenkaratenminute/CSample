using System;
namespace Chap11_throw
{
    class MainClass
    {
        // ƒ‰ƒ€ƒ_®‚Ì=>‰‰Zq‚ÌŒã
        static public int Throw1() => throw new Exception( "Lambda" );

        static public string Throw2( int ct )
        {
            // ğŒ‰‰Zq‚Ì‘æ2‚Ü‚½‚Í‘æ3ˆø”
            return ( ct < 0 ) ? throw new InvalidOperationException( "nothing" ) : ct.ToString();
        }

        public static void Main()
        {
            try {
                Throw1();
            }
            catch ( Exception e )
            {
                Console.WriteLine( e.Message );
            }
            try
            {
                Throw2( -1 );
            }
            catch ( Exception e )
            {
                Console.WriteLine( e.Message );
            }

            try
            {
                object sample_var = null;
                
                // null‡‘Ì‰‰Zq‚ÌŒã
                var s = sample_var as string ?? throw new Exception();
            }
            catch ( Exception e )
            {
                Console.WriteLine( e.Message );
            }

        }
    }
}