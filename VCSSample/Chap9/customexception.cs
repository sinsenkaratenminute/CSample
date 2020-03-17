using System;
namespace Chap9_custom
{
    // �Ǝ��̊�{��O�N���X�̒�`
    class BaseCustomException : Exception
    {
        public BaseCustomException(string msg) : base(msg)
        {
        }
    }

    // �Ǝ��̗�O�N���X�̒�`
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
                // ���[�U�[��`�̗�O���X���[
                throw new CustomException("��O���X���[");
            }
            catch (BaseCustomException e)      // ���[�U�[��`�̗�O�̕ߑ�
            {
                Console.WriteLine("���[�U�[��`");
                Console.WriteLine(e.Message);
            }
            catch (Exception e)                // ���ׂĂ̗�O�̕ߑ�
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}