using System;
namespace Chap8_type1
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
            if (s != null)
            {
                s.BaseInfo();  // �o�͒l�FSong
            }
            // �_�E���L���X�g�ł���ꍇ��s2����`�����
            if (m is Song s2)
            {
                s2.BaseInfo();  // �o�͒l�FSong
            }

            Music2 m2 = m as Music2;
            if (m2 != null)
            {
                m2.BaseInfo();
            }

            if (m is Music2 m3)
            {
                m3.BaseInfo();
            }
        }
    }
}
