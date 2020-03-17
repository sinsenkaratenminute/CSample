using System;
namespace Chap8_3
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
        public override void BaseInfo() // ���\�b�h���I�[�o�[���C�h
        {
            Console.WriteLine("Song");
        }
    }

    // �h���N���X
    class Music2 : Music
    {
        new public void BaseInfo() // ���\�b�h���B��
        {
            Console.WriteLine("Music2");
        }
    }

    class MainClass
    {
        static void Main()
        {
            Music m = new Song();

            Song s = m as Song;
            Music2 m2 = m as Music2; // �_�E���L���X�g�ł��Ȃ��̂ŁAnull��Ԃ�

            Console.WriteLine(s == null);   // �o�͒l�FFalse
            Console.WriteLine(m2 == null);  // �o�͒l�FTrue
        }
    }
}
