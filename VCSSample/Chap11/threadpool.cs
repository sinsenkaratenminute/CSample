using System;
using System.Threading;
using System.Threading.Tasks;

namespace Chap11_threadpool
{
    class MainClass
    {
        static void Main(string[] args)
        {
            // �X���b�h�Ŏ��s���鏈��
            void testThread(Object stateInfo)
            {
                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine(stateInfo + " " + i);
                    Thread.Sleep(200);
                }
            }

            // WaitCallback�f���Q�[�g���g���ăX���b�h�v�[���Ƀ��\�b�h��o�^����
            ThreadPool.QueueUserWorkItem(new WaitCallback(testThread), "1");
            ThreadPool.QueueUserWorkItem(new WaitCallback(testThread), "2");
            ThreadPool.QueueUserWorkItem(new WaitCallback(testThread), "3");

            // �A�v���P�[�V�������I�����Ȃ��悤�ɑҋ@����
            Console.ReadLine();
        }
    }
}