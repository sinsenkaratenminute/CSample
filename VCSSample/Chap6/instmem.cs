using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap6_instmem
{
    class Car
    {
        // �t�B�[���h
        public string name = "�}�C�J�["; // �C���X�^���X�����o�[��������
        public int seats;
    }

    class MainClass
    {
        static void Main()
        {
            Car test = new Car();
            Car test2 = new Car();

            test2.name = "�T�u";     // �C���X�^���X�����o�[�ɑ��

            Console.WriteLine(test.name);  // �o�͒l�F"�}�C�J�["
            Console.WriteLine(test2.name); // �o�͒l�F"�T�u"
        }
    }
}