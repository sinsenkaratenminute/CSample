using System;
namespace Chap10_null4
{
    // 名前と番号のクラス
    public class Person
    {
        public int No;
        public string Name;
    }
    // Personクラスのフィールドを持つクラス
    public class Team
    {
        public Person Member;
    }
    class MainClass
    {
        static void Main()
        {
            var t = new Team();

            string n = t.Member?.Name;
            Console.WriteLine( n );

            var t2 = new Team();
            // ?.演算子と??演算子の組み合わせ
            string n2 = t2.Member?.Name ?? "nothing";
            Console.WriteLine(n2);  // 出力値：nothing
        }
    }
}
