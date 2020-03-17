using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap10_tuple
{
    class tuple3
    {
        static void Main()
        {
            // タプル型の戻り値
            ( string name, int age ) GetMember()
            {
                var n = "Wings";
                var a = 18;
                return ( n, a );
            }
            ( string name, int age ) = GetMember();
            Console.WriteLine(name); // 出力値: Wings
            Console.WriteLine(age);  // 出力値: 18

            (var name1, var age1 ) = GetMember();
            // 以下のようにも書ける
            // var ( name1, age1 ) = GetMember();

            (_, int age2) = GetMember();
            Console.WriteLine(age2);  // 出力値: 18

        }
    }
}
