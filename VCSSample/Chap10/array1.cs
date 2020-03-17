using System;
namespace Chap10_1
{
    class MainClass
    {
        static void Main()
        {
            // int型配列の定義
            int[] array = new int[10];

            // 代入
            array[0] = 1;
            array[1] = 2;

            // 参照
            Console.WriteLine(array[0] + array[1]); // 出力値：3
        }
    }
}