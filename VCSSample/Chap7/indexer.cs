using System;
namespace Chap7_12
{
    class TestArray
    {
        // private�Ȃ̂ŊO������̓A�N�Z�X�ł��Ȃ�
        int[] array = new int[3];

        // �C���f�N�T�[�̒�`
        public int this[int index]
        {
            set
            {
                array[index] = value;
            }
            get
            {
                return array[index];
            }
        }
    }

    class MainClass
    {
        static void Main()
        {
            var t = new TestArray();

            // �z��̂悤�ɑ���ł���
            t[0] = 5;
            t[1] = 10;
            t[2] = 15;

            // �z��̂悤�ɎQ�Ƃł���
            Console.WriteLine(t[1]); // �o�͒l�F10

            // �I�u�W�F�N�g�������q�ł̃C���f�N�T�[
            var t2 = new TestArray()
            {
                [0] = 5,
                [1] = 10,
                [2] = 15
            };
            Console.WriteLine(t2[2]); // �o�͒l�F15
        }

    }
}