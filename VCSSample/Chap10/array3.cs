using System;
namespace Chap10_4
{
    class MainClass
    {
        static void Main()
        {
            string[] weekDays = { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" };

            for (int i = 0; i < weekDays.Length; i++)
            {
                // �z��̗v�f�����ׂďo��
                Console.WriteLine(weekDays[i]);
            }

            foreach (string s in weekDays)
            {
                // �z��̗v�f�����ׂďo�́ifor���[�v�ƌ��ʂ͓����j
                Console.WriteLine(s);
            }

            // �z��̗v�f�̍��v�����߂�
            int[] a = { 1, 2, 3 };
            int sum = 0;
            for (int i = 0; i < a.Length; i++)
            {
                sum += a[i];
            }
            Console.WriteLine(sum); // �o�͒l�F6
        }
    }
}