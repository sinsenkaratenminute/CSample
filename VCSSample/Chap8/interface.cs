using System;
namespace Chap8_9
{
    // インターフェイス
    interface IGetInfo
    {
        void getInfo();
    }

    // 派生クラス
    class SampleClass : IGetInfo
    {
        public void getInfo()
        {
            Console.WriteLine("SampleClass");
        }
    }

    class MainClass
    {
        static void Main()
        {
            SampleClass s = new SampleClass();
            s.getInfo();                        // 出力値："SampleClass"
        }
    }
}