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
                Console.WriteLine( "�G���[����" );
            }
            // Message �v���p�e�B�� "error" �ȊO�̂Ƃ�
            catch (Exception e)
            {
                Console.WriteLine( "���̑��̗�O" );
            }
        }
    }
}