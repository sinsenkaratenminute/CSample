using System;
using System.Collections;
namespace Chap12_8
{
    public class MainClass
    {
        // �Ǝ��̔�r����
        public class myReverserClass : IComparer
        {
            int IComparer.Compare(Object x, Object y)
            {
                // �p�����[�^���t�ɂ��Ĕ�r�������ʂ�Ԃ�
                return ((new CaseInsensitiveComparer()).Compare(y, x));
            }
        }

        public static void Main()
        {
            // SortedList�ɓƎ��̔�r������g�ݍ���
            var myList = new SortedList(new myReverserClass())
            {
                { "1st", "Tigers" },
                { "2nd", "Giants" },
                { "3rd", "Dragons" }
            };

            for (int i = 0; i < myList.Count; i++)
            {
                // �L�[�ƒl��\��
                Console.WriteLine("[{0}]{1}", myList.GetKey(i), myList.GetByIndex(i));
            }
        }
    }
}
