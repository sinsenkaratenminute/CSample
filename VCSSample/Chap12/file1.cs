using System;
using System.IO;
namespace Chap12_9
{
    class MainClass
    {
        static void Main()
        {
            // �t�@�C���̃I�[�v��
            StreamReader sr = new StreamReader("sample.txt", System.Text.Encoding.Default);

            // �t�@�C���̓��e���ׂĂ��A1�̕�����ɓǂݍ���
            string text = sr.ReadToEnd();

            // �t�@�C���̃N���[�Y
            sr.Close();

            // �ǂݍ��񂾃t�@�C���̓��e�̏o��
            Console.Write(text);
        }
    }
}