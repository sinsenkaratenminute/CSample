using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap6_10
{
    class TestClass
    {
        // a���R�{���ĕ\������
        public void TestFunc(ref int a)
        {
            a *= 3; // �p�����[�^�[�̕ϐ�a��3�{

            Console.WriteLine(a);
        }
    }

    class MainClass
    {
        static void Main()
        {
            TestClass test = new TestClass();
            int a = 5;               // ���������K�v

            test.TestFunc(ref a);  // �o�͒l�F15
            Console.WriteLine(a);  // �o�͒l�F15
        }
    }
}