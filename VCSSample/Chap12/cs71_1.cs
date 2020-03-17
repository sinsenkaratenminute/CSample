using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace cs71_1
{
    class Program1
    {
        static async Task Main()
        {
            string url = "http://www.yahoo.co.jp/";
            using (var client = new HttpClient())
            {
                string c = await client.GetStringAsync(url);
                Console.WriteLine($"{url} : {c.Length}");
            }
        }
    }
}
