using System;
using System.IO;
namespace Chap12_11
{
    class MainClass
    {
        static void Main()
        {
            StreamReader sr = null;

            try
            {
                // �t�@�C���̃I�[�v��
                sr = new StreamReader("sample.txt", System.Text.Encoding.Default);

                // �t�@�C���̓��e���ׂĂ��A1�̕�����ɓǂݍ���
                string text = sr.ReadToEnd();

                // �ǂݍ��񂾃t�@�C���̓��e�̏o��
                Console.Write(text);
            }
            catch (Exception e)
            {
                // ��O�̓��e�̏o��
                Console.WriteLine(e.Message);
            }
            finally
            {
                // �t�@�C�����I�[�v������Ă���ꍇ
                if (sr != null)
                {
                    // �t�@�C���̃N���[�Y
                    sr.Close();
                }
            }
        }
    }
}