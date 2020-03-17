using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap6_instmem
{
    class Car
    {
        // フィールド
        public string name = "マイカー"; // インスタンスメンバーを初期化
        public int seats;
    }

    class MainClass
    {
        static void Main()
        {
            Car test = new Car();
            Car test2 = new Car();

            test2.name = "サブ";     // インスタンスメンバーに代入

            Console.WriteLine(test.name);  // 出力値："マイカー"
            Console.WriteLine(test2.name); // 出力値："サブ"
        }
    }
}