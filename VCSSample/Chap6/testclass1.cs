using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap6_4
{
    class MainClass
    {
        // 値を返さない、パラメーターのないメソッド
        public void PrintOne()
        {
            Console.WriteLine("1");
        }

        static void Main()
        {
            MainClass test = new MainClass();   // インスタンス生成
            test.PrintOne();                    // printOneメソッド呼び出し
                                                // 出力値：1
        }
    }
}