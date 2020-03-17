using System;

namespace Chap7_6
{
    // ��{�N���X
    class Music
    {
        public virtual void BaseInfo()
        {
            Console.WriteLine("Music");
        }
    }

    // �h���N���X
    class Song : Music
    {
        public override void BaseInfo() // ��{�N���X�̃��\�b�h���I�[�o�[���C�h
        {
            Console.WriteLine("Song");
        }
    }

    // �h���N���X
    class Music2 : Music
    {
        new public void BaseInfo() // ��{�N���X�̃��\�b�h���B��
        {
            Console.WriteLine("Music2");
        }
    }

    class MainClass
    {
        static void Main()
        {
            Song s = new Song();
            s.BaseInfo();              // �o�͒l�F"Song"

            Music2 m2 = new Music2();
            m2.BaseInfo();             // �o�͒l�F"Music2"

            Music m = new Music();
            m.BaseInfo();              // �o�͒l�F"Music"
        }
    }
}