using System;
namespace Chap10_null2
{
    class MainClass
    {
        static void Main()
        {
            int? a = null;
            Console.WriteLine(a ?? 10); // �o�͒l�F10

            a = 5;
            Console.WriteLine(a ?? 10); // �o�͒l�F5

            // �Q�ƌ^�ł��g����
            string s = null;
            Console.WriteLine(s ?? "Empty"); // �o�͒l�FEmpty
        }
    }
}
