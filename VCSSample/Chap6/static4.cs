using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap6_static4
{
    static class ClassStatic
    {
        // �ÓI�����o�[
        public static int a;

        // �ÓI�R���X�g���N�^�[
        static ClassStatic()
        {
            a = 5;
        }

        // �ÓI���\�b�h
        public static void Display()
        {
            Console.WriteLine(a); // �ÓI���\�b�h�̌Ăяo��
        }
    }

    class MainClass
    {
        static void Main()
        {
            ClassStatic.Display(); // �o�͒l�F5
        }
    }
}