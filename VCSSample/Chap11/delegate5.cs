using System;
namespace Chap11_5
{
    // SampleDel�Ƃ������O�̃f���Q�[�g���`
    delegate void SampleDel(int x);

    class MainClass
    {
        public static void Main()
        {
            // �������\�b�h���g�����f���Q�[�g�^�̕ϐ��̒�`
            SampleDel delVar = delegate (int n) { Console.WriteLine(n); };
            delVar(123);        // �o�͒l�F123
        }
    }
}