using System;
namespace Chap9_11
{
    class MainClass
    {
        static void Main()
        {
            try
            {
                ushort x = 300;              // 300 = 256 + 44
                byte y;

                y = unchecked((byte)x);    // byte�^�ɕϊ�����ƃI�[�o�[�t���[����
                Console.WriteLine(y);      // �o�͒l: 44

                y = checked((byte)x);      // �I�[�o�[�t���[��O�̃X���[
                Console.WriteLine(y);

            }
            catch (OverflowException e)    // �I�[�o�[�t���[��O�̕ߑ�
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
