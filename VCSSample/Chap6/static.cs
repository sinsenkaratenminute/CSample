using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap6_static
{
    class Car
    {
        public string name;       // �C���X�^���X�����o�[
        public static int seats;  // �ÓI�����o�[

        public Car()
        {
            name = "�}�C�J�[";
        }

        public void Display()
        {
            Console.WriteLine(seats); // seats�ÓI�t�B�[���h�̒l���o��
        }
    }

    class MainClass
    {
        static void Main()
        {
            Car.seats = 5;   // seats�ÓI�t�B�[���h��5��ݒ�

            // �C���X�^���X���쐬
            Car test = new Car();
            test.Display();  // �o�͒l�F5

            // �ʂ̃C���X�^���X�ł��ÓI�t�B�[���h�̒l�͓����ɂȂ�
            Car test2 = new Car();
            test2.Display(); // �o�͒l�F5
        }
    }
}