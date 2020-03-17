using System;
using System.Collections;
namespace Chap12_1
{
    class MainClass
    {
        static void Main()
        {
            // ArrayListをインスタンス化
            ArrayList a = new ArrayList();

            a.Add("Hello");
            a.Add("World");

            // キャストが必要というエラーになる
            // string s = a[0];

            // インデックスによる参照
            string s = (string)a[1];    // 出力値：World

            Console.WriteLine(s);
        }
    }
}