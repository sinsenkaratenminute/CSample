using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap6_7
{
    class TestClass
    {
        // 2�̃p�����[�^�[���󂯎����int�^�̒l��Ԃ����\�b�h
        public int CalcAdd(int a, int b)
        {
            return a + b; // �p�����[�^�[��a��b�����Z���ĕԂ�
        }
    }

    class MainClass
    {
        static void Main()
        {
            TestClass test = new TestClass();

            int p = 4;
            int a = test.CalcAdd(3, p);   // ���\�b�h�̌Ăяo��

            Console.WriteLine(a);         // �o�͒l�F7
        }
    }
}