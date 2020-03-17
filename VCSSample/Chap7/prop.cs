using System;

namespace Chap7_9
{
    class SampleClass
    {
        // 自動で内部的なstring型のフィールドが生成される
        public string Type { get; set; }
    }

    class MainClass
    {
        static void Main()
        {
            var test = new SampleClass();

            test.Type = "A";
            Console.WriteLine(test.Type); // 出力値：A
        }
    }
}
