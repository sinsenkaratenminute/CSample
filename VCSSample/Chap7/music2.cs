using System;

namespace Chap7_2
{
    // ��{�N���X
    class Music
    {
        public Music()                  // 2. ��{�N���X�̃R���X�g���N�^�[���s
        {
            Console.WriteLine("��{�N���X�̃R���X�g���N�^�[");
        }
    }

    // �h���N���X
    class Song : Music
    {
        public string Key = "C#";       // 1. �t�B�[���h�̏�����

        public Song()                   // 3. �h���N���X�̃R���X�g���N�^�[���s
        {
            Console.WriteLine("�h���N���X�̃R���X�g���N�^�[");
        }
    }

    class MainClass
    {
        static void Main()
        {
            Song s = new Song();
        }
    }
}