using System;
using System.IO;
namespace Chap12_nameof
{
    class MainClass
    {
        static void Main()
        {
            void test( string chk_str )
            {
                if ( chk_str == null )
                {
                    throw new ArgumentNullException( nameof(chk_str) );
                }
            }

            try
            {
                test( null );
            }
            catch ( Exception e )
            {
                Console.WriteLine( e.Message );
            }
        }
    }
}
