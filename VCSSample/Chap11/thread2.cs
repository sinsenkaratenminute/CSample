using System;
using System.Threading;
using System.Threading.Tasks;

namespace Chap11_thread2
{
    class MainClass
    {
        // �X���b�h�Ŏ��s����������
        static public void ThreadMethod()
        {
            // 3�b�Ԓ�~����
            Thread.Sleep( 3000 );
            Console.WriteLine( "finish" );
        }

        public static void Main()
        {
            Console.WriteLine("start");

            // Run���\�b�h��Action�f���Q�[�g��n��
            var task = Task.Run( new Action(ThreadMethod) );

            // �^�X�N����������܂ŃA�v���P�[�V�������I�����Ȃ��悤�ɑҋ@����
            task.Wait();
        }
    }
}