using System;
namespace Chap9_1
{
    class MainClass
    {
        static void Main()
        {
            try
            {
                int a = 10;
                int b = 0;

                Console.WriteLine("try");

                a /= b;         // ゼロ除算の例外が発生する

                Console.WriteLine("エラー");
            }
            catch
            {
                Console.WriteLine("例外発生");
            }
        }
    }
}
