using System;
namespace Chap5_9
{
    class MainClass
    {
        static void Main()
        {
            string[] j = { "グー", "チョキ", "パー" };

            // 配列のデータを1つずつ取得
            foreach (string str in j)
            {
                Console.WriteLine(str);
            }
        }
    }
}
