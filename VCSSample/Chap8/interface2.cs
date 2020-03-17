using System;
namespace Chap8_10
{
    // �v���p�e�B�̃C���^�[�t�F�C�X
    interface IPoint
    {
        // �v���p�e�B
        int Px
        {
            get; set;
        }

        int Py
        {
            get; set;
        }
    }

    // �v���p�e�B�݂̂̃C���^�[�t�F�C�X������
    class ReversePoint : IPoint
    {
        // �t�B�[���h�iprivate�j
        int x;
        int y;

        // �R���X�g���N�^
        public ReversePoint(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        // �C���^�[�t�F�C�X�̎���
        public int Px
        {
            get { return -x; }
            set { x = value; }
        }
        public int Py
        {
            get { return -y; }
            set { y = value; }
        }
    }

    class MainClass
    {
        // �p�����[�^��IPoint�C���^�[�t�F�C�X�̐ÓI���\�b�h
        public static void DisplayPoint(IPoint point)
        {
            Console.WriteLine("x={0},y={1}", point.Px, point.Py);
        }

        static void Main()
        {
            ReversePoint p1 = new ReversePoint(12, 300);

            // �v���p�e�B�̎Q��
            Console.WriteLine(p1.Px);   // �o�͒l�F12
            Console.WriteLine(p1.Py);   // �o�͒l�F300

            ReversePoint p2 = new ReversePoint(12, 300);

            // �v���p�e�B�̎Q��
            DisplayPoint(p2); // �o�͒l�F"x=-12, y=-300"

        }
    }
}