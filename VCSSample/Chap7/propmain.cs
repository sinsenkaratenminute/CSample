using System;

namespace Chap7_8
{
    class MainClass
    {
        static void Main()
        {
            Music m = new Music();
            m.Type = 1;                   // setが呼ばれる
            Console.WriteLine(m.Type);    // getが呼ばれる
        }
    }
}
