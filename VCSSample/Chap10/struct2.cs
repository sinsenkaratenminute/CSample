namespace Chap10_10
{
    using System;

    struct Simple
    {
        public int Number ;
        public string Name;

        // �p�����[�^�[�t���̃R���X�g���N�^�[
        public Simple( int n, string s )
        {
            Number = n;
            Name = s;
        }

    }

    class MainClass
    {
        static void Main()
        {
            // ����̃R���X�g���N�^�[���Ăяo�����
            // Simple s1 = new Simple();

            Simple s1 = default(Simple);

            Console.WriteLine( s1.Number );   // �o�͒l�F0�iint�^�̊���l�j
            Console.WriteLine( s1.Name );     // �����o�͂���Ȃ��istring�^�̊���lnull�j

            // �����I�ɃR���X�g���N�^�[���Ăяo��
            Simple s2 = new Simple( 1, "testname" );

            Console.WriteLine( s2.Number );   // �o�͒l�F1
            Console.WriteLine( s2.Name );     // �o�͒l�Ftestname

            // �R���X�g���N�^�[�͌Ă΂�Ȃ�
            Simple ss;

            // �����o������`�ŃR���p�C���G���[
            // Console.WriteLine(ss.name);
        }
    }
}