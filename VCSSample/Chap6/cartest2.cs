using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap6_2
{
    class Car
    {
        // �t�B�[���h
        public string name;
        public int seats = 4;
    }

    class MainClass
    {
        static void Main()
        {
            Car mycar1 = new Car();
            Car mycar2 = new Car();

            // �C���X�^���X���r�����
            Console.WriteLine(mycar1 == mycar2); // �o�͒l�FFalse

            mycar1.name = "���C��";
            mycar2.name = "�T�u";

            Console.WriteLine(mycar1.name);      // �o�͒l�F���C��
            Console.WriteLine(mycar2.name);      // �o�͒l�F�T�u
        }
    }
}