using System;
namespace Chap8_9
{
    // �C���^�[�t�F�C�X
    interface IGetInfo
    {
        void getInfo();
    }

    // �h���N���X
    class SampleClass : IGetInfo
    {
        public void getInfo()
        {
            Console.WriteLine("SampleClass");
        }
    }

    class MainClass
    {
        static void Main()
        {
            SampleClass s = new SampleClass();
            s.getInfo();                        // �o�͒l�F"SampleClass"
        }
    }
}