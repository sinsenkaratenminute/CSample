using System;

namespace Chap7_8
{
    class MainClass
    {
        static void Main()
        {
            Music m = new Music();
            m.Type = 1;                   // set���Ă΂��
            Console.WriteLine(m.Type);    // get���Ă΂��
        }
    }
}
