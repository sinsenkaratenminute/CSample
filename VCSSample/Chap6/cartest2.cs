using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap6_2
{
    class Car
    {
        // フィールド
        public string name;
        public int seats = 4;
    }

    class MainClass
    {
        static void Main()
        {
            Car mycar1 = new Car();
            Car mycar2 = new Car();

            // インスタンスを比較すると
            Console.WriteLine(mycar1 == mycar2); // 出力値：False

            mycar1.name = "メイン";
            mycar2.name = "サブ";

            Console.WriteLine(mycar1.name);      // 出力値：メイン
            Console.WriteLine(mycar2.name);      // 出力値：サブ
        }
    }
}