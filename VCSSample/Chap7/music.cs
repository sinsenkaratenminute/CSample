using System;

namespace Chap7_1
{
    // ��{�N���X
    class Music
    {
        public int Type = 0;
        public string Name = "Music";

        public void BaseInfo()
        {
            Console.WriteLine("Music");
        }
    }

    // �h���N���X
    class Song : Music
    {
        public string Key = "C#";

        public void DrvInfo()
        {
            Console.WriteLine("Song");
        }
    }

    class MainClass
    {
        static void Main()
        {
            Song s = new Song();         // �h���N���X�̃C���X�^���X

            Console.WriteLine(s.Key);    // �o�͒l�F"C#"
            s.DrvInfo();                 // �o�͒l�F"Song"

            // ��{�N���X�̃����o�[�ɃA�N�Z�X�ł���
            Console.WriteLine(s.Type); // �o�͒l�F0
            s.BaseInfo();                // �o�͒l�F"Music"

            Music m = new Music();       // ��{�N���X�̃C���X�^���X

            Console.WriteLine(m.Type); // �o�͒l�F0
            m.BaseInfo();                // �o�͒l�F"Music"
        }
    }
}