using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap6_1
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
            Car mycar = new Car();            // Carクラスのインスタンスを生成
            mycar.name = "マイカー";           // .でデータメンバーを指定
            Console.WriteLine(mycar.name);    // 出力値：マイカー
            Console.WriteLine(mycar.seats);   // 出力値：4
        }
    }
}
