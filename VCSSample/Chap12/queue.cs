using System;
using System.Collections.Generic;
namespace Chap12_6
{
    class MainClass
    {
        static void Main()
        {
            var q = new Queue<int>();

            // �v�f��ǉ�
            q.Enqueue(10);
            q.Enqueue(11);
            q.Enqueue(12);
            q.Enqueue(13);

            // �擪�̗v�f���擾���č폜
            Console.WriteLine(q.Dequeue());    // �o�͒l�F10
            Console.WriteLine(q.Dequeue());    // �o�͒l�F11

            // �擪�̗v�f���擾
            Console.WriteLine(q.Peek());       // �o�͒l�F12

            // �擪�̗v�f���擾���č폜
            Console.WriteLine(q.Dequeue());    // �o�͒l�F12

            // ���ׂĂ̗v�f�̍폜
            q.Clear();

            // �v�f��ǉ�
            q.Enqueue(1);
            q.Enqueue(2);
            q.Enqueue(3);

            // ���ׂĂ̗v�f�̎擾
            foreach (var i in q)
            {
                Console.WriteLine(i);
            }

            // �擪�̗v�f���擾���č폜
            Console.WriteLine(q.Dequeue());    // �o�͒l�F1
        }
    }
}