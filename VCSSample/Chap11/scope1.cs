using System;
namespace Chap11_scope1
{
    class MainClass
    {
        public static void Main()
        {
            int b = 2;

            // �ϐ�b���Q�Ƃł���
            Action<int> Multi = n => { Console.WriteLine( n * b ); };

            Multi(5);        // �o�͒l�F10

        }
    }
}