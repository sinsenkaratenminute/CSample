using System;
namespace Chap11_scope2
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
                };
            }
            Action action = CreateLambda(3);

            // �����_���̎��s
            action();           // �o�͒l�F6
        }
    }
}