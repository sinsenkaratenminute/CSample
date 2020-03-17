using System;
namespace Chap9_10
{
    class MainClass
    {
        static void Main()
        {
            try
            {
                // オーバーフローを検出
                checked
                {
                    short a = short.MaxValue;   // short型の最大値を代入
                    Console.WriteLine(a);

                    a++;                        // オーバーフロー 
                    Console.WriteLine(a);
                }
            }
            catch (Exception e)               // すべての例外の捕捉
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
