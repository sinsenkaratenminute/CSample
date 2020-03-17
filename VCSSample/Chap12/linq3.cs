using System;
using System.Linq;
namespace Chap12_17
{
    class MainClass
    {
        static void Main()
        {
            // c:\以下のファイルを取得
            var result = from f in System.IO.Directory.GetFiles("c:\\")
                         where f.Length < 10 // 長さが10未満のもの
                         select f;

            // 結果データを表示
            foreach (var x in result)
            {
                Console.WriteLine(x);
            }
        }
    }
}