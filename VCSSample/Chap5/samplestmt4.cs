using System;
namespace Chap5_4
{

    class MainClass
    {
        static void Main()
        {
            int month = DateTime.Now.Month; // ���݂̌����擾

            switch (month)
            {
                //case 7:
                //    Console.WriteLine( "����" );   // C#�ł̓G���[
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