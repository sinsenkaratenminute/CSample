using System;
using System.Collections;
namespace Chap12_1
{
    class MainClass
    {
        static void Main()
        {
            // ArrayList���C���X�^���X��
            ArrayList a = new ArrayList();

            a.Add("Hello");
            a.Add("World");

            // �L���X�g���K�v�Ƃ����G���[�ɂȂ�
            // string s = a[0];

            // �C���f�b�N�X�ɂ��Q��
            string s = (string)a[1];    // �o�͒l�FWorld

            Console.WriteLine(s);
        }
    }
}