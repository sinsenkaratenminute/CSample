using System;

namespace Chap7_5
{
    // ��{�N���X
    class BaseClass
    {
        public int Type = 0;
    }

    class NewClass : BaseClass
    {
        new public int Type = 1;   // �����t�B�[���h���`

        // type�t�B�[���h�̒l�̕\��
        public void print()
        {
            Console.WriteLine(this.Type); // ���g�̃����o�ɃA�N�Z�X
            Console.WriteLine(base.Type); // ��{�N���X�̃����o�ɃA�N�Z�X
        }
    }

    class MainClass
    {
        static void Main()
        {
            NewClass n = new NewClass();

            n.print(); // �h���N���X�Ɗ�{�N���X��type�t�B�[���h�̒l��\��
        }
    }
}