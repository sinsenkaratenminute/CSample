using System;
namespace Chap9_6
{
    class CustomException : Exception
    {
        public CustomException(string msg) : base(msg)
        {
        }
    }

    class MainClass
    {
        static void Main()
        {
            try
            {
                // ユーザー定義の例外をスロー
                throw new CustomException("例外をスロー");
            }
            catch (CustomException e)          // ユーザー定義の例外の捕捉
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}