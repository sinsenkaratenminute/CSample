using System;
using System.Collections.Generic;
namespace Chap12_4
{
    class MainClass
    {
        static void Main()
        {
            // LinkedList�N���X�̗��p
            var list = new LinkedList<string>();

            // 1�ڂ̗v�f��ǉ�
            list.AddFirst("First");

            // 2�ڂ̗v�f��ǉ�
            list.AddFirst("Last");

            for (int i = 0; i < 3; i++)
            {
                // �擪�̗v�f�̌��i�̒l�𕶎���ɕϊ��������̂�ǉ�
                list.AddAfter(list.First, i.ToString());
            }

            // ���ׂĂ̗v�f�����Ԃɕ\��
            foreach (var s in list)
            {
                Console.WriteLine(s);
            }
        }
    }
}
