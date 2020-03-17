using System;
using System.Collections.Generic;
using System.Linq;
namespace Chap12_19
{
    class MainClass
    {
        static void Main()
        {
            // string�^�̃��X�g
            var names = new List<string>() { "Tigers", "Giants", "Dragons" };

            // LINQ�ɂ��擾�����f�[�^��z��ɕϊ�
            var result = (from n in names select n).ToArray();

            // �擾�����f�[�^���o��
            foreach (var x in result)
            {
                Console.WriteLine(x);
            }

            Console.WriteLine("");

            // names[1]��names[2]�����ւ���
            string tmp = names[1];
            names[1] = names[2];
            names[2] = tmp;

            // �Ăуf�[�^���o��
            foreach (var x in result)
            {
                Console.WriteLine(x);
            }
        }
    }
}
