using System;
namespace Chap8_7
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
            Music m;            // Music�N���X�^�̕ϐ�

            m = new Music2();   // Music2�N���X�̃C���X�^���X����
            m.BaseInfo();       // �o�͒l�FMusic
        }
    }
}