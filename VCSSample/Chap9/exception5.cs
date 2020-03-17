using System;
namespace Chap9_5
{
    class MainClass
    {
        static void Main()
        {
            int x = 10;
            int y = 0;

            try
            {
                int z = x / y;
            }
            catch (DivideByZeroException e)    // ƒ[ƒœZ—áŠO‚Ì•ß‘¨
            {
                Console.WriteLine(e.Message);
            }
            catch (ArithmeticException e)      // Zp‰‰Z—áŠO‚Ì•ß‘¨
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)                // ‚·‚×‚Ä‚Ì—áŠO‚Ì•ß‘¨
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}