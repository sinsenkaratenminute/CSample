using System;
namespace Chap9_2
{
    class MainClass
    {
        static void Main()
        {
            try
            {
                int a = 0;
                int b = 0;
                a /= b;         // ƒ[ƒœZ‚Ì—áŠO‚ª”­¶‚·‚é
            }
            catch
            {
                Console.WriteLine("—áŠO”­¶");
            }
            finally
            {
                Console.WriteLine("I—¹");
            }
        }
    }
}