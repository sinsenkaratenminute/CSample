using System;
using System.Collections.Generic;
namespace Chap12_2
{
    class MainClass
    {
        static void Main()
        {
            // string�^��List�Ƃ��ăC���X�^���X��
            List<string> slist = new List<string>();

            slist.Add("Hello");
            slist.Add("World");

            // �C���f�b�N�X�ɂ��Q�Ɓi�L���X�g�s�v�j
            string s = slist[1];    // �o�͒l�FWorld

            Console.WriteLine(s);
        }
    }
}
