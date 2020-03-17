using System;
using System.Threading;
using System.Threading.Tasks;

namespace Chap11_thread4
{
     class MainClass
     {
        // 非同期メソッド
        public static async Task ThreadMethodAsync()
        {
            await Task.Run(() => {
                // 3秒間停止する
                Thread.Sleep(3000);
                Console.WriteLine("finish");
            });
        }

        public static void Main()
        {
            Console.WriteLine( "start" );

            Task t = ThreadMethodAsync();

            // タスクが完了するまでアプリケーションが終了しないように待機する
            t.Wait();
        }
     }
}