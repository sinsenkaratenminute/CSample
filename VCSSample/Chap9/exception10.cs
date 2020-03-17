using System;
namespace Chap9_filter2
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
            catch (Exception e)
                when (e is DivideByZeroException || e is ArithmeticException)
            {
                Console.WriteLine( e.Message );
            }
            catch (Exception e)   // すべての例外の捕捉
            {
                Console.WriteLine( e.Message );
            }
        }
    }
}