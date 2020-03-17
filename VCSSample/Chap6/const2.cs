using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap6_const2
{
    class Car
    {
        // フィールド
        public string name;
        public int seats;

        // 既定のコンストラクター
        public Car()
        {
            seats = 4; // 4で初期化
        }

        // string型のパラメータを受け取るコンストラクター
        public Car(string str)
        {
            seats = 4;
            name = str;
        }
    }

    class MainClass
    {
        static void Main()
        {
            Car test = new Car();
            Console.WriteLine(test.name);   // 何も出力されない

            Car test2 = new Car("マイカー");
            Console.WriteLine(test2.name);  // 出力値："マイカー"
        }
    }
}