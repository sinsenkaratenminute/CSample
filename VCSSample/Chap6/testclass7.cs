using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap6_11
{
    class TestClass
    {
        // a��2���3������߂�
        public void TestFunc(int a, out int b, out int c)
        {
            b = a * a;
            c = a * a * a;
        }
    }

    class MainClass
    {
        static void Main()
        {
            TestClass test = new TestClass();

            int x, y;                   // �p�����[�^�ϐ��̏������͕s�v

            // �p�����[�^�ϐ�x��y��3��2���3�悪��������
            test.TestFunc( 3, out x, out y );

            //test.TestFunc(3, out int x, out var y);


            Console.WriteLine( x );     // �o�͒l�F9
            Console.WriteLine( y );     // �o�͒l�F27
        }
    }
}
