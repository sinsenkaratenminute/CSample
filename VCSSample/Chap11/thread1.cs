using System;
using System.Threading;
namespace Chap11_thread1
{
    class MainClass
    {
        // �X���b�h�Ŏ��s����������
        static�@public void ThreadMethod()
        {
            // 3�b�Ԓ�~����
            Thread.Sleep(3000);
            Console.WriteLine("finish");
        }

        public static void Main()
        {
            Console.WriteLine("start");

            // ThreadStart�f���Q�[�g���g���ăX���b�h�𐶐�����
            var t = new Thread( new ThreadStart( ThreadMethod ) );

            // �X���b�h�����̊J�n
            t.Start();

            // �X���b�h���I������܂ő҂�
            t.Join();
        }
    }
}