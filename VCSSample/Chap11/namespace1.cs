using System;

namespace Space1
{
    class Class1
    {
        public static void Output()
        {
            Console.WriteLine( "Space1.Class1" );
        }
    }
}

namespace Space2
{
    class Class2
    {
        public static void Output()
        {
            Console.WriteLine( "Space2.Class2" );
        }
    }
}

namespace Space1
{
    class Class3
    {
        public static void Output()
        {
            Console.WriteLine( "Space1.Class3" );
        }
    }
}

namespace SampleSpace
{
    class Class1
    {
        static void Main()
        {
            Space1.Class1.Output(); // �o�͒l�FSpace1.Class1
            Space2.Class2.Output(); // �o�͒l�FSpace2.Class2
            Space1.Class3.Output(); // �o�͒l�FSpace1.Class3
        }
    }
}
