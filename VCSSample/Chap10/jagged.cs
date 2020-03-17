using System;
namespace Chap10_6
{
    class MainClass
    {
        static void Main()
        {
            // 2�����z��̃x�[�X�ƂȂ�z����`
            int[][,] a = new int[3][,];

            // 2�����z����`���đ��
            a[0] = new int[,] { { 10, 20 }, { 100, 200 } };
            a[1] = new int[,] { { 30, 40, 50 }, { 300, 400, 500 } };
            a[2] = new int[,] { { 60, 70, 80, 90 }, { 600, 700, 800, 900 } };

            // �z��̎Q�Ɨ�
            Console.WriteLine(a[0][0, 0]);  // �o�͒l�F10
            Console.WriteLine(a[1][1, 1]);  // �o�͒l�F400
            Console.WriteLine(a[2][1, 3]);  // �o�͒l�F900

            // �x�[�X�ƂȂ�z��̃T�C�Y��\������
            Console.WriteLine(a.Length);    // �o�͒l�F3

            // �e�T�u�z��̃T�C�Y��\������
            Console.WriteLine(a[0].Length); // �o�͒l�F4
            Console.WriteLine(a[1].Length); // �o�͒l�F6
            Console.WriteLine(a[2].Length); // �o�͒l�F8

            // ��������\������
            Console.WriteLine(a.Rank);      // �o�͒l�F1
            Console.WriteLine(a[0].Rank);   // �o�͒l�F2
        }
    }
}
