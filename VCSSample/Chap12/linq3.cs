using System;
using System.Linq;
namespace Chap12_17
{
    class MainClass
    {
        static void Main()
        {
            // c:\�ȉ��̃t�@�C�����擾
            var result = from f in System.IO.Directory.GetFiles("c:\\")
                         where f.Length < 10 // ������10�����̂���
                         select f;

            // ���ʃf�[�^��\��
            foreach (var x in result)
            {
                Console.WriteLine(x);
            }
        }
    }
}