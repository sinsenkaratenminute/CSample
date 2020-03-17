using System;
namespace Chap10_7
{
    class MainClass
    {
        // 配列を横一列に表示する
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

            // 配列を定義通りに表示する
            PrintArray(arr);

            // 配列を昇順に並べる
            Array.Sort(arr);
            PrintArray(arr);

            // 配列を反転する（昇順になっていたので降順になる）
            Array.Reverse(arr);
            PrintArray(arr);
        }
    }
}