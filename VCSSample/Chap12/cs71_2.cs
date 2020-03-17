using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace cs71_2
{
    class Program2
    {
        static void Main()
        {
            string TestString<T>(T prm)
            {
                switch (prm)
                {
                    case string tmp:
                        return tmp;

                    default:
                        return "Number";
                }
            }
            Console.WriteLine( TestString(123) );


            int n = default;     // 0
            string s = default;  // null
            Console.WriteLine(n);
            Console.WriteLine(s);


            int x = 1, y = 2;
            var t = (x, y);    // タプル型

            Console.WriteLine(t.x);
            Console.WriteLine(t.y);

            // C#7では、要素に名前がつかず、以下のようにする必要があった
            Console.WriteLine(t.Item1);
            Console.WriteLine(t.Item2);


        }
    }
}
