using System;
namespace Chap9_custom
{
    // 独自の基本例外クラスの定義
    class BaseCustomException : Exception
    {
        public BaseCustomException(string msg) : base(msg)
        {
        }
    }

    // 独自の例外クラスの定義
    class CustomException : BaseCustomException
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
            catch (BaseCustomException e)      // ユーザー定義の例外の捕捉
            {
                Console.WriteLine("ユーザー定義");
                Console.WriteLine(e.Message);
            }
            catch (Exception e)                // すべての例外の捕捉
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}