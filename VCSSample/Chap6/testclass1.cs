using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap6_4
{
    class MainClass
    {
        // �l��Ԃ��Ȃ��A�p�����[�^�[�̂Ȃ����\�b�h
        public void PrintOne()
        {
            Console.WriteLine("1");
        }

        static void Main()
        {
            MainClass test = new MainClass();   // �C���X�^���X����
            test.PrintOne();                    // printOne���\�b�h�Ăяo��
                                                // �o�͒l�F1
        }
    }
}