using System;

namespace Chap5_12
{
    class MainClass
    {
        static void Main()
        {
            for ( int i = 0; true; i++ )
            {
                if ( i < 8 )
                {
                    continue; // �J�E���^�ϐ����X�V���ă��[�v�̐擪�ɖ߂�
                }
                else if ( i == 10 )
                {
                    break; // ���[�v�𒆒f����
                }
                Console.WriteLine( i );
            }
        }
    }
}
