using System;
using System.Threading;
using System.Threading.Tasks;

namespace Chap11_thread3
{
    class MainClass
    {
        // ÉXÉåÉbÉhÇ≈é¿çsÇµÇΩÇ¢èàóù
        static public void ThreadMethod()
        {
            // 3ïbä‘í‚é~Ç∑ÇÈ
            Thread.Sleep(3000);
            Console.WriteLine("finish");
        }

        public static void Main()
        {
            Console.WriteLine("start");

            // InvokeÉÅÉ\ÉbÉhÇ…ActionÉfÉäÉQÅ[ÉgÇìnÇ∑
            Parallel.Invoke(new Action(ThreadMethod),
               () =>
               {
                   // 5ïbä‘í‚é~Ç∑ÇÈ
                   Thread.Sleep(5000);
                   Console.WriteLine("finish");
               });
        }
    }
}