using System;
namespace Chap10_8
{
    public class MainClass
    {
        // �R�}���h���C��������\������
        static void Main( string[] args )
        {
            for ( int i = 0; i < args.Length; ++i )
            {
                // �z��args�̗v�f��\������
                Console.WriteLine( "�p�����[�^{0} : {1}", i, args[i] );
            }
        }
    }
}
