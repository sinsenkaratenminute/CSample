using System;
using System.IO;
namespace Chap12_12
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
                    // �t�@�C���̓��e���ׂĂ��A1�̕�����ɓǂݍ���
                    string text = sr.ReadToEnd();

                    // �ǂݍ��񂾃t�@�C���̓��e�̏o��
                    Console.Write(text);
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