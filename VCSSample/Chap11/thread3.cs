using System;
using System.Threading;
using System.Threading.Tasks;

namespace Chap11_thread3
{
    class MainClass
    {
        // �X���b�h�Ŏ��s����������
        static public void ThreadMethod()
        {
            // 3�b�Ԓ�~����
            Thread.Sleep(3000);
            Console.WriteLine("finish");
        }

        public static void Main()
        {
            Console.WriteLine("start");

            // Invoke���\�b�h��Action�f���Q�[�g��n��
            Parallel.Invoke(new Action(ThreadMethod),
               () =>
               {
                   // 5�b�Ԓ�~����
                   Thread.Sleep(5000);
                   Console.WriteLine("finish");
               });
        }
    }
}