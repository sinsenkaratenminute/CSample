using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap6_option
{
    class TestClass
    {
        // �ȗ��\�ȃp�����[�^�[�������\�b�h
        public void PrintName(int no, string name = "nanashi")
        {
            Console.WriteLine( no + "��" + name );
        }
    }

    class MainClass
    {
        static void Main()
        {
            TestClass test = new TestClass();

            test.PrintName( 10 ); // test.SampleMethod( 10, "nanashi" );�Ɠ����Ӗ�
            // �o�͒l�F10��nanashi
        }
    }
}