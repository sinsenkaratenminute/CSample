using System;
namespace Chap10_null4
{
    // ���O�Ɣԍ��̃N���X
    public class Person
    {
        public int No;
        public string Name;
    }
    // Person�N���X�̃t�B�[���h�����N���X
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
            // ?.���Z�q��??���Z�q�̑g�ݍ��킹
            string n2 = t2.Member?.Name ?? "nothing";
            Console.WriteLine(n2);  // �o�͒l�Fnothing
        }
    }
}
