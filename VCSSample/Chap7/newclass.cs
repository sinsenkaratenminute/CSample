using System;

namespace Chap7_4
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
    class Music2 : Music
    {
        new public int Type = 1;   // �����t�B�[���h���`

        new public void BaseInfo() // �������\�b�h���`
        {
            Console.WriteLine("Music2");
        }
    }

    class MainClass
    {
        static void Main()
        {
            Music2 m2 = new Music2();

            m2.BaseInfo();              // �o�͒l�FMusic2
            Console.WriteLine(m2.Type); // �o�͒l�F1
        }
    }
}