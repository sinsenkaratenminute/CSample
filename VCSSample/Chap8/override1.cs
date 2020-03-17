using System;
namespace Chap8_6
{
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
        public override void BaseInfo() // �������\�b�h���`
        {
            Console.WriteLine("Song");
        }
    }

    // �h���N���X
    class Symphony : Music
    {
        public override void BaseInfo() // �������\�b�h���`
        {
            Console.WriteLine("Symphony");
        }
    }

    class MainClass
    {
        static void Main()
        {
            Music m;            // Music�N���X�^�̕ϐ�

            m = new Song();     // Song�N���X�̃C���X�^���X����
            m.BaseInfo();       // �o�͒l�Fsong

            m = new Symphony(); // Symphony�N���X�̃C���X�^���X����
            m.BaseInfo();       // �o�͒l�FSymphony
        }
    }
}
