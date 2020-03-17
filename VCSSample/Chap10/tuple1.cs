using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap10_tuple
{
    class tuple2
    {
        static void Main()
        {
            // タプル型の戻り値
            (string, int) GetMember()
            {
                var n = "Wings";
                var a = 18;
                return ( n, a );
            }
            var m = GetMember();
            Console.WriteLine(m.Item1); // 出力値: Wings
            Console.WriteLine(m.Item2); // 出力値: 18


        }
    }
}
