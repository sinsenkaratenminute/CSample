// Sample1.cs 名前を入力して表示するプログラム
class Sample1
{
    static string program_ver = "sample #1";

    static void Main()
    {
        System.Console.WriteLine( program_ver );
        System.Console.Write( "お名前は？≫ " );
        string name = System.Console.ReadLine();
        System.Console.WriteLine( $"ようこそ、{name}さん !" );
    }
}
