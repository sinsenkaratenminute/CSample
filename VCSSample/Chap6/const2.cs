using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap6_const2
{
    class Car
    {
        // �t�B�[���h
        public string name;
        public int seats;

        // ����̃R���X�g���N�^�[
        public Car()
        {
            seats = 4; // 4�ŏ�����
        }

        // string�^�̃p�����[�^���󂯎��R���X�g���N�^�[
        public Car(string str)
        {
            seats = 4;
            name = str;
        }
    }

    class MainClass
    {
        static void Main()
        {
            Car test = new Car();
            Console.WriteLine(test.name);   // �����o�͂���Ȃ�

            Car test2 = new Car("�}�C�J�[");
            Console.WriteLine(test2.name);  // �o�͒l�F"�}�C�J�["
        }
    }
}