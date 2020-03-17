using System;
namespace Chap10_null3
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

            string n = t.Member.Name;
            // NullReferenceExceptionがスローされる

            Console.WriteLine( n );
        }
    }
}
