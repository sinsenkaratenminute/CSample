using System;
using System.Threading;
using System.Threading.Tasks;

namespace Chap11_thread2
{
    class MainClass
    {
        // スレッドで実行したい処理
        static public void ThreadMethod()
        {
            // 3秒間停止する
            Thread.Sleep( 3000 );
            Console.WriteLine( "finish" );
        }

        public static void Main()
        {
            Console.WriteLine("start");

            // RunメソッドにActionデリゲートを渡す
            var task = Task.Run( new Action(ThreadMethod) );

            // タスクが完了するまでアプリケーションが終了しないように待機する
            task.Wait();
        }
    }
}