using System;
using System.IO;
namespace Chap12_13
{
    class MainClass
    {
        static void Main()
        {
            try
            {
                // �t�@�C���̃I�[�v��
                using (StreamReader sr =
                    new StreamReader("sample.txt", System.Text.Encoding.Default))
                {
                    string line = "";
                    while ((line = sr.ReadLine()) != null) // 1�s���ǂݍ���
                    {
                        // �ǂݍ���1�s�̏o��
                        Console.WriteLine(line);
                    }
                }
            }
            catch (Exception e)
            {
                // ��O�̓��e�̏o��
                Console.WriteLine(e.Message);
            }
        }
    }
}
