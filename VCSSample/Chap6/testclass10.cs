using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap6_14
{
    class TestClass
    {
        static void Main()
        {
            // int�^�̒l��Ԃ����\�b�h
            int AddNums(int a, int b)
            {
                return a + b;
            }

            for ( int i=0; i<3; i++ )
            {
                int a = AddNums( i, 2 );
                Console.Write( a );  // �o�͒l�F234
            }
        }
    }
}
