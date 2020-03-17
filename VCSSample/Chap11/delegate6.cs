using System;
namespace Chap11_6
{
    class MainClass
    {
        public static void Main()
        {
            // ラムダ式を使ったデリゲート型の変数の定義
            Action<int> delVar = n => { Console.WriteLine(n); };

            delVar(123);        // 出力値：123
        }
    }
}