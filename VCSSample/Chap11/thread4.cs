using System;
using System.Threading;
using System.Threading.Tasks;

namespace Chap11_thread4
{
     class MainClass
     {
        // �񓯊����\�b�h
        public static async Task ThreadMethodAsync()
        {
            await Task.Run(() => {
                // 3�b�Ԓ�~����
                Thread.Sleep(3000);
                Console.WriteLine("finish");
            });
        }

        public static void Main()
        {
            Console.WriteLine( "start" );

            Task t = ThreadMethodAsync();

            // �^�X�N����������܂ŃA�v���P�[�V�������I�����Ȃ��悤�ɑҋ@����
            t.Wait();
        }
     }
}