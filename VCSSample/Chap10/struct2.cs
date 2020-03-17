namespace Chap10_10
{
    using System;

    struct Simple
    {
        public int Number ;
        public string Name;

        // パラメーター付きのコンストラクター
        public Simple( int n, string s )
        {
            Number = n;
            Name = s;
        }

    }

    class MainClass
    {
        static void Main()
        {
            // 既定のコンストラクターが呼び出される
            // Simple s1 = new Simple();

            Simple s1 = default(Simple);

            Console.WriteLine( s1.Number );   // 出力値：0（int型の既定値）
            Console.WriteLine( s1.Name );     // 何も出力されない（string型の既定値null）

            // 明示的にコンストラクターを呼び出す
            Simple s2 = new Simple( 1, "testname" );

            Console.WriteLine( s2.Number );   // 出力値：1
            Console.WriteLine( s2.Name );     // 出力値：testname

            // コンストラクターは呼ばれない
            Simple ss;

            // メンバが未定義でコンパイルエラー
            // Console.WriteLine(ss.name);
        }
    }
}