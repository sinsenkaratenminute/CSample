using System;
namespace Chap7_11
{
    class SampleClass
    {
        // �t�B�[���h
        public int v1 = 10;
        private int v2;

        // �f�t�H���g�R���X�g���N�^
        public SampleClass()
        {
            Console.WriteLine(this.v1);
        }

    }

    class MainClass
    {
        static void Main()
        {
            var test = new SampleClass { v1 = 20 }; // �o�͒l�F10
            Console.WriteLine(test.v1);             // �o�͒l�F20

            // �ȉ��̃R�����g���͂����ƃR���p�C���G���[�ƂȂ�
            // private�̃����o�͐ݒ�ł��Ȃ�
            // var test2 = new SampleClass { v2 = 20 };
        }
    }
}