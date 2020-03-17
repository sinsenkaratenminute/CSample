using System;
namespace Chap10_7
{
    class MainClass
    {
        // �z��������ɕ\������
        public static void PrintArray(int[] a)
        {
            foreach (int x in a)
            {
                Console.Write("{0} ", x);
            }
            Console.WriteLine("");
        }

        static void Main()
        {
            int[] arr = { 22, -14, 2, -17, 41, 6, 29 };

            // �z����`�ʂ�ɕ\������
            PrintArray(arr);

            // �z��������ɕ��ׂ�
            Array.Sort(arr);
            PrintArray(arr);

            // �z��𔽓]����i�����ɂȂ��Ă����̂ō~���ɂȂ�j
            Array.Reverse(arr);
            PrintArray(arr);
        }
    }
}