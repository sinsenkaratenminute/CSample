using System;
namespace Chap11_6
{
    class MainClass
    {
        public static void Main()
        {
            // �����_�����g�����f���Q�[�g�^�̕ϐ��̒�`
            Action<int> delVar = n => { Console.WriteLine(n); };

            delVar(123);        // �o�͒l�F123
        }
    }
}