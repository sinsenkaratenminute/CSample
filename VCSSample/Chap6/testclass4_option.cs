using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap6_option
{
    class TestClass
    {
        // 省略可能なパラメーターを持つメソッド
        public void PrintName(int no, string name = "nanashi")
        {
            Console.WriteLine( no + "→" + name );
        }
    }

    class MainClass
    {
        static void Main()
        {
            TestClass test = new TestClass();

            test.PrintName( 10 ); // test.SampleMethod( 10, "nanashi" );と同じ意味
            // 出力値：10→nanashi
        }
    }
}