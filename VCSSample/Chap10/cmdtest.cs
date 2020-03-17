using System;
namespace Chap10_8
{
    public class MainClass
    {
        // コマンドライン引数を表示する
        static void Main( string[] args )
        {
            for ( int i = 0; i < args.Length; ++i )
            {
                // 配列argsの要素を表示する
                Console.WriteLine( "パラメータ{0} : {1}", i, args[i] );
            }
        }
    }
}
