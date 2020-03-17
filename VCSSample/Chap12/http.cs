using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace Chap12_http
{
    class MainClass
    {
        static void Main()
        {
            // 非同期メソッド
            async Task GetWebLengthAsync(string url)
            {
                using (var client = new HttpClient())
                {
                    string c = await client.GetStringAsync(url);
                    Console.WriteLine($"{url} : {c.Length}");
                }
            }

            Task t1 = GetWebLengthAsync("http://www.yahoo.co.jp/");
            Task t2 = GetWebLengthAsync("http://www.msn.com/");

            Console.ReadLine();
        }
    }
}