using System;
namespace Chap8_8
{
    // ���ۃN���X�i��{�N���X�j
    abstract class Music
    {
        public abstract void GetInfo();     // ���ۃ��\�b�h
    }

    // �h���N���X
    class Song : Music
    {
        public override void GetInfo()      // override������
        {
            Console.WriteLine("Song");
        }
    }

    class MainClass
    {
        static void Main()
        {
            Song s = new Song();
            s.GetInfo();                   // �o�͒l�FSong
        }
    }
}