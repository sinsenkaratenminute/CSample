using System;
namespace Chap9_filter1
{
    class MainClass
    {
        static void Main()
        {
            try
            {
                throw new Exception( "error" );
            }
            catch (Exception e) when (e.Message == "error")
            {
                Console.WriteLine( "エラー発生" );
            }
            // Message プロパティが "error" 以外のとき
            catch (Exception e)
            {
                Console.WriteLine( "その他の例外" );
            }
        }
    }
}