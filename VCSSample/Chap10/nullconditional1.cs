using System;
namespace Chap10_null3
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

            string n = t.Member.Name;
            // NullReferenceException���X���[�����

            Console.WriteLine( n );
        }
    }
}
