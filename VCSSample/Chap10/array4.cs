using System;
namespace Chap10_5
{
    class MainClass
    {
        static void Main()
        {
            // 2�����z��
            string[,] a = { { "��", "��" }, { "�O", "�l" }, { "��", "�Z" } };

            // 2�����z���\�����ďo�͂���
            for (int i = 0; i < a.Length / a.Rank; i++)
            {
                // �����̐��������ɕ\��
                for (int j = 0; j < a.Rank; j++)
                {
                    Console.Write(a[i, j] + " ");
                }
                Console.WriteLine(""); // ���s
            }
        }
    }
}
