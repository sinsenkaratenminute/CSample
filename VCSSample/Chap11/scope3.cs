using System;
namespace Chap11_scope3
{
    class MainClass
    {
        public static void Main()
        {
            // �����A�߂�l���Ȃ������_����Ԃ����[�J���֐�
            Action CreateLambda(int n)
            {
                int b = 2;
                return () =>
                {
                    Console.WriteLine(n * b);
                    // ���[�J���ϐ����C���N�������g����
                    b++;
                };
            }
            Action action = CreateLambda(3);

            // �����_���̎��s
            action();           // �o�͒l�F6
            // ���̃����_���̎��s�ł��ϐ�b�͗L��
            action();           // �o�͒l�F9
        }
    }
}