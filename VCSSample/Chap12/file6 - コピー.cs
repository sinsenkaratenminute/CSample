using System;
using System.IO;
namespace Chap12_14
{
    class MainClass
    {
        // �t�@�C���������݁i��ɏ㏑���j
        static void write(string name)
        {
            using (var sw = new StreamWriter(name, false, System.Text.Encoding.Default))
            {
                // 1�s��������
                sw.WriteLine("�T���v��1");
                sw.WriteLine("�T���v��2");
                sw.WriteLine("�T���v��3");
            }
        }

        // �t�@�C���ǂݍ���
        static void read(string name)
        {
            using (StreamReader sr = new StreamReader(name, System.Text.Encoding.Default))
            {
                string line = "";
                while ((line = sr.ReadLine()) != null) // 1�s���ǂݍ���
                {
                    Console.WriteLine(line);
                }
            }
        }

        static void Main()
        {
            try
            {
                string name = "sample.txt";

                // �t�@�C����������
                write(name);

                // �t�@�C���ǂݍ���
                read(name);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
