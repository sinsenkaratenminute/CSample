using System;
using System.Collections.Generic;
namespace Chap12_5
{
    class MainClass
    {
        static void Main()
        {
            var st = new Stack<int>();

            // �v�f��ǉ�
            st.Push(10);
            st.Push(11);
            st.Push(12);
            st.Push(13);

            // �擪�̗v�f���擾���č폜
            Console.WriteLine(st.Pop());    // �o�͒l�F13
            Console.WriteLine(st.Pop());    // �o�͒l�F12

            // �擪�̗v�f���擾
            Console.WriteLine(st.Peek());   // �o�͒l�F11

            // �擪�̗v�f���擾���č폜
            Console.WriteLine(st.Pop());    // �o�͒l�F11

            // ���ׂĂ̗v�f�̍폜
            st.Clear();

            // �v�f��ǉ�
            st.Push(1);
            st.Push(2);
            st.Push(3);

            // ���ׂĂ̗v�f�����ԂɎ擾
            foreach (var i in st)
            {
                Console.WriteLine(i);
            }

            // �擪�̗v�f���擾���č폜
            Console.WriteLine(st.Pop());    // �o�͒l�F3
        }
    }
}