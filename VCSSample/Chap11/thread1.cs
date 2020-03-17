using System;
using System.Threading;
namespace Chap11_thread1
{
    class MainClass
    {
        // スレッドで実行したい処理
        static　public void ThreadMethod()
        {
            // 3秒間停止する
            Thread.Sleep(3000);
            Console.WriteLine("finish");
        }

        public static void Main()
        {
            Console.WriteLine("start");

            // ThreadStartデリゲートを使ってスレッドを生成する
            var t = new Thread( new ThreadStart( ThreadMethod ) );

            // スレッド処理の開始
            t.Start();

            // スレッドが終了するまで待つ
            t.Join();
        }
    }
}