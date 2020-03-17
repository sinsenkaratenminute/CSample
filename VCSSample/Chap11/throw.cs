using System;
namespace Chap11_throw
{
    class MainClass
    {
        // �����_����=>���Z�q�̌�
        static public int Throw1() => throw new Exception( "Lambda" );

        static public string Throw2( int ct )
        {
            // �������Z�q�̑�2�܂��͑�3����
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
                
                // null���̉��Z�q�̌�
                var s = sample_var as string ?? throw new Exception();
            }
            catch ( Exception e )
            {
                Console.WriteLine( e.Message );
            }

        }
    }
}