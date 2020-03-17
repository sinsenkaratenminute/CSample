using System;
using System.Threading;
using System.Threading.Tasks;

namespace Chap11_thread5
{
    class MainClass
    {
        // �񓯊����\�b�h
        public static async Task<long> ThreadMethodAsync()
        {
            long val = 0;

            // Task<long>�^��Ԃ�
            return await Task.Run(() =>
            {
                for ( long i = 1; i <= 1000000000; i++ )
                {
                    val += i;
                }
                // long�^�̒l��Ԃ�
                return val;
            });
        }

        public static void Main()
        {
            Console.WriteLine( "start" );

            Task<long> t = ThreadMethodAsync();

            // �^�X�N����������܂ŃA�v���P�[�V�������I�����Ȃ��悤�ɑҋ@����
            t.Wait();

            // ���ʂ̕\��
            Console.WriteLine( t.Result ); // �o�͒l�F500000000500000000
        }
    }
}