using System;
using System.IO;
namespace Chap12_9
{
    class MainClass
    {
        static void Main()
        {
            // ファイルのオープン
            StreamReader sr = new StreamReader("sample.txt", System.Text.Encoding.Default);

            // ファイルの内容すべてを、1つの文字列に読み込む
            string text = sr.ReadToEnd();

            // ファイルのクローズ
            sr.Close();

            // 読み込んだファイルの内容の出力
            Console.Write(text);
        }
    }
}