using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap6_6
{
    class TestClass
    {
        // �l��Ԃ��Ȃ����\�b�h
        public void MyMethod3(int a)
        {
            if (a < 3)
            {
               // return 2;   // void�Ȃ̂ɖ߂�l�������ƃG���[�ɂȂ�
            }
            return;         // ����̓G���[�ɂȂ�Ȃ�
        }

        /*
        // int�^�̒l��Ԃ����\�b�h
        public int MyMethod4(int a)
        {
            if (a < 3)
            {
                return;     // �l���K�v
            }
            // �l��Ԃ����\�b�h�ł�return���͏ȗ��ł��Ȃ�
        }
        */
    }
}