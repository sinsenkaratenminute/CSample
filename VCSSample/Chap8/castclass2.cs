using System;
namespace Chap8_2
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
            Song s = (Song)m;

            Console.WriteLine(m is Song);   // �o�͒l�FTrue
            Console.WriteLine(m is Music2); // �o�͒l�FFalse
        }
    }
}