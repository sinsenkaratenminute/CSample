using System;
namespace Chap8_5
{
    class MainClass
    {

        static void Main()
        {
            int a = 5;            // 値型の定義
            object obj;           // object型の参照変数

            obj = a;              // ボックス化
            int b = (int)obj;     // ボックス化解除

            Console.WriteLine(b); // 出力値：5

            // 元はint型なので実行時にエラーとなる
            // double d = (double)o; 

            Console.WriteLine(obj is double); // 出力値：False
            Console.WriteLine(obj is int);    // 出力値：True
        }
    }
}