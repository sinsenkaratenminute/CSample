using System;
using System.Collections.Generic;
using System.Linq;
namespace Chap12_18
{
    class MainClass
    {
        static void Main()
        {
            // string��LIST
            var names = new List<string>() { "Tigers", "Giants", "Dragons" };

            // LINQ�ɂ��f�[�^���o
            var result = from n in names select n;

            // ���ʃf�[�^��\���i1�j
            foreach (var x in result)
            {
                Console.WriteLine(x);
            }

            Console.WriteLine("");

            // names[1]��names[2]�����ւ���
            string tmp = names[1];
            names[1] = names[2];
            names[2] = tmp;

            // ���ʃf�[�^��\���i2�j
            foreach (var x in result)
            {
                Console.WriteLine(x);
            }
        }
    }
}