using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap6_3
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
            Car mycar3 = mycar2; // �C���X�^���X�̑��

            mycar3.name = "�T�u�J�["; // mycar3�̃����o�[��ύX

            Console.WriteLine(mycar3.name);      // �o�͒l�F�T�u�J�[
            Console.WriteLine(mycar2.name);      // �o�͒l�F�T�u�J�[

            // �C���X�^���X���r�����
            Console.WriteLine(mycar2 == mycar3); // �o�͒l�FTrue
        }
    }
}