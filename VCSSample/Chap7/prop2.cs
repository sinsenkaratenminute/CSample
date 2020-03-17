using System;

namespace Chap7_10
{
    class SampleClass
    {
        public string Type { get; set; } = "nothing";
        public string Name { get; } = "abc";
    }

    class MainClass
    {
        static void Main()
        {
            var test = new SampleClass();
            Console.WriteLine(test.Type); // 出力値：nothing
            Console.WriteLine(test.Name); // 出力値：abc
        }
    }
}
