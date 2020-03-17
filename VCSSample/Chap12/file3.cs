using System;
using System.IO;
namespace Chap12_11
{
    class MainClass
    {
        static void Main()
        {
            StreamReader sr = null;

            try
            {
                // ファイルのオープン
                sr = new StreamReader("sample.txt", System.Text.Encoding.Default);

                // ファイルの内容すべてを、1つの文字列に読み込む
                string text = sr.ReadToEnd();

                // 読み込んだファイルの内容の出力
                Console.Write(text);
            }
            catch (Exception e)
            {
                // 例外の内容の出力
                Console.WriteLine(e.Message);
            }
            finally
            {
                // ファイルがオープンされている場合
                if (sr != null)
                {
                    // ファイルのクローズ
                    sr.Close();
                }
            }
        }
    }
}