using System;
namespace Chap11_1
{
    // SampleDel�Ƃ������O�̃f���Q�[�g���`
    delegate void SampleDel(int x);

    class MainClass
    {
        // ���ۂɌĂ΂�郁�\�b�h
        static void TestMethod(int n)
        {
            Console.WriteLine(n);
        }

        public static void Main()
        {
            // SampleDel�^�̕ϐ���錾
            SampleDel delVar;

            // �f���Q�[�g�^�̕ϐ��̃C���X�^���X���i���\�b�h�{�̂�o�^�j
            delVar = new SampleDel(TestMethod);

            // �f���Q�[�g����ă��\�b�h���Ăяo�����
            delVar(123);        // �o�͒l�F123
        }
    }
}