using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap6_static3
{

    class Car
    {
        public string name;       // �C���X�^���X�����o�[
        public static int seats;  // �ÓI�����o�[

        public Car()
        {
            name = "�}�C�J�[";
            Console.WriteLine(name);
        }

        // �ÓI�R���X�g���N�^�[
        static Car()
        {
            seats = 4;
            Console.WriteLine(seats);
        }

        // �ÓI���\�b�h
        public static void SetSeat(int n)
        {
            seats = n; // �ÓI�����o�[�ɑ��
        }

        public void Display()
        {
            Console.WriteLine(seats); // �ÓI���\�b�h�̌Ăяo��
        }
    }

    class MainClass
    {
        static void Main()
        {
            Car test = new Car();  // �ÓI�R���X�g���N�^�[�Ɗ���̃R���X�g���N�^�[���Ăяo�����

            Car.SetSeat(5);        // �ÓI�����o�[��5��ݒ�

            Car test2 = new Car(); // ����̃R���X�g���N�^�[�݂̂��Ăяo�����

            test2.Display();       // �ÓI�����o�[�̒l�͕ύX����Ă��Ȃ�
        }
    }
}