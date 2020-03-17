using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap10_tuple
{
    class tuple4
    {
        static void Main()
        {
            (int n, string name)  t1 = (1, "sample");
            (int num, string str) t2 = (3, "テスト");
 
            // タプルの代入
            t1 = t2;
            Console.WriteLine(t1.name);  // 出力値:テスト

            // タプルの代入(エラー、キャストが必要)
            // (byte n, string name) t3 = (3, "テスト");
            // t3 = t1;
        }
    }
}
