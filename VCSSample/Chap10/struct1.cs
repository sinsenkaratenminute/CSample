using System;
namespace Chap10_9
{
    struct Simple
    {
        public int Number;
        public string Name;
    }

    class MainClass
    {
        static void Main()
        {
            Simple ss;         // new�͕s�v

            ss.Number = 0;     // int�^�̃t�B�[���h�ɒl��ݒ�
            ss.Name = "test";  // string�^�̃t�B�[���h�ɒl��ݒ�

            Console.WriteLine( ss.Number );   // �o�͒l�F0
            Console.WriteLine( ss.Name );     // �o�͒l�Ftest
        }
    }
}