using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap6_static
{
    class Car
    {
        public string name;       // インスタンスメンバー
        public static int seats;  // 静的メンバー

        public Car()
        {
            name = "マイカー";
        }

        public void Display()
        {
            Console.WriteLine(seats); // seats静的フィールドの値を出力
        }
    }

    class MainClass
    {
        static void Main()
        {
            Car.seats = 5;   // seats静的フィールドに5を設定

            // インスタンスを作成
            Car test = new Car();
            test.Display();  // 出力値：5

            // 別のインスタンスでも静的フィールドの値は同じになる
            Car test2 = new Car();
            test2.Display(); // 出力値：5
        }
    }
}