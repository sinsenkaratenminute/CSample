using System;
namespace Chap10_3
{
    class MainClass
    {
        static void Main()
        {
            // 2�����z��
            int[,] a = new int[,] { { 1, 2 }, { 3, 4 }, { 5, 6 } };

            // 3�����z��
            int[,,] b = { { { 1, 2, 3 }, { 4, 5, 6 } }, { { 7, 8, 9 }, { 10, 11, 12 } } };

            // 2�����z��̎Q�Ɨ�
            Console.WriteLine(a[0, 0]); // �o�͒l�F1
            Console.WriteLine(a[0, 1]); // �o�͒l�F2
            Console.WriteLine(a[1, 0]); // �o�͒l�F3
            Console.WriteLine(a[1, 1]); // �o�͒l�F4
            Console.WriteLine(a[2, 0]); // �o�͒l�F5
            Console.WriteLine(a[2, 1]); // �o�͒l�F6

            // 3�����z��̎Q�Ɨ�
            Console.WriteLine(b[0, 0, 0]); // �o�͒l�F1
            Console.WriteLine(b[0, 0, 1]); // �o�͒l�F2
            Console.WriteLine(b[0, 0, 2]); // �o�͒l�F3
            Console.WriteLine(b[0, 1, 0]); // �o�͒l�F4
            Console.WriteLine(b[0, 1, 1]); // �o�͒l�F5
            Console.WriteLine(b[0, 1, 2]); // �o�͒l�F6
            Console.WriteLine(b[1, 0, 0]); // �o�͒l�F7
            Console.WriteLine(b[1, 0, 1]); // �o�͒l�F8
            Console.WriteLine(b[1, 0, 2]); // �o�͒l�F9
            Console.WriteLine(b[1, 1, 0]); // �o�͒l�F10
            Console.WriteLine(b[1, 1, 1]); // �o�͒l�F11
            Console.WriteLine(b[1, 1, 2]); // �o�͒l�F12
        }
    }
}