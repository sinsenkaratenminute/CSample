using System;
namespace Chap5_3
{

    class MainClass
    {
        static void Main()
        {
            int month = DateTime.Now.Month; // ���݂̌����擾

            switch (month)
            {
                case 1:
                    Console.WriteLine( "�r��" );
                    break;
                case 2:
                    Console.WriteLine( "�@��" );
                    break;
                case 3:
                    Console.WriteLine( "�퐶" );
                    break;
                case 7:
                case 8:
                    Console.WriteLine( "�ċx��" );
                    break;
                default:
                    Console.WriteLine( month + "��" );
                    break;
            }
        }
    }
}