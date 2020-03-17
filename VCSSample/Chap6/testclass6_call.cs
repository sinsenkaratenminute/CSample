using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap6_call
{
    class TestClass
    {
        // a���R�{����
        public ref int TestFunc(ref int a)
        {
            a *= 3;
            return ref a; // �Q�ƂŕԂ�
        }
    }

    class MainClass
    {
        static void Main()
        {
            TestClass test = new TestClass();

            int a = 5;
            
            ref int b = ref test.TestFunc( ref a ); // �߂�l�́A�ϐ�a�̎Q��
            Console.WriteLine( a );  // �o�͒l�F15
            Console.WriteLine( b );  // �o�͒l�F15

            b = 10;
            Console.WriteLine( a );  // �o�͒l�F10
            Console.WriteLine( b );  // �o�͒l�F10
        }
    }
}