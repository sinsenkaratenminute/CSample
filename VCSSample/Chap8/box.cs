using System;
namespace Chap8_5
{
    class MainClass
    {

        static void Main()
        {
            int a = 5;            // �l�^�̒�`
            object obj;           // object�^�̎Q�ƕϐ�

            obj = a;              // �{�b�N�X��
            int b = (int)obj;     // �{�b�N�X������

            Console.WriteLine(b); // �o�͒l�F5

            // ����int�^�Ȃ̂Ŏ��s���ɃG���[�ƂȂ�
            // double d = (double)o; 

            Console.WriteLine(obj is double); // �o�͒l�FFalse
            Console.WriteLine(obj is int);    // �o�͒l�FTrue
        }
    }
}