using System;
namespace Chap5_15
{

    class MainClass
    {
        static void Main()
        {
            for ( int i = 0; true; i++ )
            {
                if ( i == 3 )  // �ϐ�i��3�̏ꍇ
                {
                    break;     // ���[�v�𒆒f����
                }
                Console.WriteLine( i );
            }
        }
    }
}
