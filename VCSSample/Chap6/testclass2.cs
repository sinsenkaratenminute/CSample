using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap6_5
{
    class TestClass
    {
        // int�^��Ԃ����\�b�h
        public int MyMethod1()
        {
            return 10;
        }

        // �l��Ԃ��Ȃ����\�b�h
        public void MyMethod2(int a)
        {
            if (a < 3)
            {
                return;              // a��3�����Ȃ烁�\�b�h���I��
            }

            Console.WriteLine(a); // a��3�ȏ�Ȃ���s�����
        }
    }
}