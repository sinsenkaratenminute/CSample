using System;
using System.Collections.Generic;
namespace Chap12_3
{
    class MainClass
    {
        static void Main()
        {
            // �R���N�V�����������q��p������`
            var list = new List<string>() { "Hello", "World", "Good-Bye" };

            // foreach�ɂ��f�[�^�Q��
            foreach (var s in list)
            {
                Console.WriteLine(s);
            }

        }
    }
}