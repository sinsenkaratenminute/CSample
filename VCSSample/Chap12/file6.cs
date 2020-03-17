using System;
using System.IO;
namespace Chap12_14
{
    class MainClass
    {
        // ファイル書き込み（常に上書き）
        static void write(string name)
        {
            using (var sw = new StreamWriter(name, false, System.Text.Encoding.Default))
            {
                // 1行書き込み
                sw.WriteLine("サンプル1");
                sw.WriteLine("サンプル2");
                sw.WriteLine("サンプル3");
            }
        }

        // ファイル読み込み
        static void read(string name)
        {
            using (StreamReader sr = new StreamReader(name, System.Text.Encoding.Default))
            {
                string line = "";
                while ((line = sr.ReadLine()) != null) // 1行ずつ読み込み
                {
                    Console.WriteLine(line);
                }
            }
        }

        static void Main()
        {
            try
            {
                string name = "sample.txt";

                // ファイル書き込み
                write(name);

                // ファイル読み込み
                read(name);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
