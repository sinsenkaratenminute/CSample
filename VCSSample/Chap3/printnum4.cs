using System;

namespace Chap3
{
    class MainClass4
    {
        static void Main()
        {
            int a = 10, b = 20;

            Console.WriteLine( a ); // �o�͒l�F10
            Console.WriteLine( b ); // �o�͒l�F20

            int c, d;

            c = a; // �����f�[�^�^�̕ϐ��ŏ��������邱�Ƃ��ł���
            d = b;

            Console.WriteLine( c ); // �o�͒l�F10
            Console.WriteLine( d ); // �o�͒l�F20
        }
    }
}
