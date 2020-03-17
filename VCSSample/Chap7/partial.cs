using System;

namespace Chap7_14
{
    partial class Sample
    {
        int a = 1;
    }

    partial class Sample
    {
        public void test()
        {
            Console.WriteLine(a);
        }
    }

    class MainClass
    {
        static void Main()
        {
            Sample testClass = new Sample();

            testClass.test();  // o—Í’lF1
        }
    }
}