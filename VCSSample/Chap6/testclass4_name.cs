using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap6_name
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

            // �ǂ���������Ăяo���ɂȂ�
            int a = test.CalcAdd( a: 3, b: p );   // ���\�b�h�̌Ăяo��
            int b = test.CalcAdd( b: p, a: 3 );   // ���\�b�h�̌Ăяo��

            Console.WriteLine(a);               // �o�͒l�F7
            Console.WriteLine(b);               // �o�͒l�F7
        }
    }
}