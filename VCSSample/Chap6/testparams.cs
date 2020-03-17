using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap6_8
{
    class TestClass
    {
        // int�^�̉σp�����[�^�[�����v����
        public int SumAll(params int[] numary)
        {
            int sum = 0;

            // numary�̗v�f��foreach�Ŏ��o���č��v����
            foreach (int n in numary)
            {
                sum += n;
            }

            return sum; // ���v�l��Ԃ�
        }
    }

    class MainClass
    {
        static void Main()
        {
            TestClass test = new TestClass();

            Console.WriteLine(test.SumAll(1, 2));       // �o�͒l�F3
            Console.WriteLine(test.SumAll(5, 10, 15));  // �o�͒l�F30
            Console.WriteLine(test.SumAll());           // �o�͒l�F0
        }
    }
}