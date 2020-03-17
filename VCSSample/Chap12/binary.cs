using System;
using System.IO;
namespace Chap12_binary
{
    class MainClass
    {

        static void Main()
        {
            try
            {
                // �o�C�i���t�@�C�����o�C�g�^�z��ɓǂݍ���
                var bytes = File.ReadAllBytes("sample.png");

                // �f�[�^�̐擪10�o�C�g��16�i�\������
                Console.WriteLine(BitConverter.ToString(bytes, 0, 10)); // �o�͒l�F89-50-4E-47-0D-0A-1A-0A-00-00

                byte[] bytes2 = { 0x1, 0x2, 0x3 };

                // �o�C�g�^�z��̓��e����������
                File.WriteAllBytes("test.dat", bytes2);

                Console.WriteLine(BitConverter.ToString(File.ReadAllBytes("test.dat")));�@// �o�͒l�F01-02-03
            }
            catch (Exception e)
            {
                 Console.WriteLine(e.Message);
            }
        }
    }
}
