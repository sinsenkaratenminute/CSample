using System;
namespace Chap5_14
{

    class MainClass
    {
        static void Main()
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(i);

                // このようにカウンタ変数を変更してしまうと...
                i--;
            }
        }
    }
}
