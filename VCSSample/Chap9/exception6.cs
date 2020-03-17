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
                // ���[�U�[��`�̗�O���X���[
                throw new CustomException("��O���X���[");
            }
            catch (CustomException e)          // ���[�U�[��`�̗�O�̕ߑ�
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}