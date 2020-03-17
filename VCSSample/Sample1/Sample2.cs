// Sample2.cs 名前を入力して表示するプログラム2
using System;

namespace Sample
{
    class Sample1
    {
        static string program_ver = "sample #1";

        static void Main()
        {
            Console.WriteLine( program_ver );
            Console.Write( "お名前は？≫ " );
            string name = Console.ReadLine();
            Console.WriteLine( $"ようこそ、{name}さん !" );
        }
    }
}
