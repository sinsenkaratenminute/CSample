
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace Practice12_2
{
    class Practice
    {
        static void Main()
        {
            // 指定のファイル名のファイルに文字列を上書きで書き込む
            void WriteContents(string name, string contents)
            {
                using (var sw =
                    new StreamWriter(name, false, System.Text.Encoding.Default))
                {
                    sw.Write(contents);
                }
            }

            // 非同期メソッド
            async Task GetWebAsync(string url)
            {
                using (var client = new HttpClient())
                {
                    // Webページの内容を文字列で取得する
                    string c = await client.GetStringAsync(url);

                    WriteContents( "yahoo.txt", c );
                }
            }
            try
            {
                Task t = GetWebAsync( "http://www.yahoo.co.jp/" );
                t.Wait();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
