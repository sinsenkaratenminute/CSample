using System;

namespace Chap7_9
{
    class SampleClass
    {
        // �����œ����I��string�^�̃t�B�[���h�����������
        public string Type { get; set; }
    }

    class MainClass
    {
        static void Main()
        {
            var test = new SampleClass();

            test.Type = "A";
            Console.WriteLine(test.Type); // �o�͒l�FA
        }
    }
}
