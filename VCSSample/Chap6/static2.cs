using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap6_static2
{

    class Car
    {
        public string name;       // �C���X�^���X�����o�[
        public static int seats;  // �ÓI�����o�[

        public Car()
        {
            name = "�}�C�J�[";
        }

        // �ÓI���\�b�h
        public static void SetSeat(int n)
        {
            seats = n; // �ÓI�����o�[�̂݃A�N�Z�X�\
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
            Car.SetSeat(5); // �ÓI�����o�[��5��ݒ�

            Car test = new Car();
            test.Display();  // �o�͒l�F5

            Car test2 = new Car();
            test2.Display(); // �o�͒l�F5
        }
    }
}