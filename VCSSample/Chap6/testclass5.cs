using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap6_9
{
    class TestClass
    {
        // a��3�{���ĕ\������
        public void TestFunc(int a)
        {
            // �p�����[�^�[�̕ϐ�a��3�{
            a *= 3;

            Console.WriteLine(a);
        }
    }

    class MainClass
    {
        static void Main()
        {
            TestClass test = new TestClass();
            int a = 5;

            test.TestFunc(a);     // �o�͒l�F15
            Console.WriteLine(a); // �o�͒l�F5
        }
    }
}