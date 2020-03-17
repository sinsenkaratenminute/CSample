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
            catch (DivideByZeroException e)    // �[�����Z��O�̕ߑ�
            {
                Console.WriteLine(e.Message);
            }
            catch (ArithmeticException e)      // �Z�p���Z��O�̕ߑ�
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)                // ���ׂĂ̗�O�̕ߑ�
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}