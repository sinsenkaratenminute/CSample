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
                Console.WriteLine( ++i );    // �o�͌��ʂ�11�ƂȂ�B
            }
            while ( i < 5 );
        }
    }
}
