using System;
namespace Chap8_1
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
            // Song�N���X�̃C���X�^���X��Music�N���X�^�̕ϐ��ɑ��
            Music m = new Song();

            // Music�N���X�^�̕ϐ����L���X�g����Song�N���X�^�̕ϐ��ɑ��
            Song s = (Song)m;

            // Music�N���X�^�̕ϐ����L���X�g����Music2�N���X�^�̕ϐ��ɑ��
            // ����Song�^�Ȃ̂Ŏ��s���ɃG���[�ƂȂ�
            Music2 m2 = (Music2)m;
        }
    }
}