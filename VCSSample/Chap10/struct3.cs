namespace Chap10_11
{
    using System;

    // �\����
    struct Player
    {
        public string Name;     //���O
        public int Number;      //�w�ԍ�
        public string Position; //�|�W�V������

        // �p�����[�^�t���̃R���X�g���N�^
        public Player(int n, string s, string p)
        {
            Number = n;
            Name = s;
            Position = p;
        }
    }

    // �\���̂̔z��������o�Ɏ��N���X
    class Team
    {
        // �z��regular�ɃR�s�[�����f�[�^��
        int regularcnt;

        // Player�^�̔z��A�T�C�Y��3
        Player[] regular = new Player[3];

        // �z��regular�ɒǉ��i�\���̂̃p�����[�^�j
        public bool AddRegular(Player p)
        {
            // �z��̃T�C�Y�ɒB����܂Œǉ��ł���
            if (regularcnt < regular.Length)
            {
                // Player�^�̃f�[�^���R�s�[
                regular[regularcnt++] = p;
                return true;
            }
            return false;
        }

        // �z��regular�̗v�f��\��
        public void ShowRgular()
        {
            foreach (Player p in regular)
            {
                // ���O��������̂����\��
                if (p.Name != null)
                {
                    Console.WriteLine("{0} {1} {2}", p.Name, p.Number, p.Position);
                }
            }
        }

        // �z��regular�̗v�f��Ԃ��i�\���̖̂߂�l�j
        public Player GetRegular(int ix)
        {
            try
            {
                return regular[ix];
            }
            catch
            {
                // �͈͊O�̃C���f�b�N�X�Ȃ�A���Player��Ԃ�
                return new Player();
            }
        }
    }

    class MainClass
    {
        static void Main()
        {
            Team t = new Team();

            // Player�^�̃f�[�^��ǉ�
            t.AddRegular(new Player(53, "��", "�Z���^�["));
            t.AddRegular(new Player(6, "�S�{", "���t�g"));
            t.AddRegular(new Player(1, "���J", "�V���[�g"));
            t.AddRegular(new Player(39, "��c", "�L���b�`���["));

            // �ǉ�����Player��\��
            t.ShowRgular();

            // �C���f�b�N�X���w�肵��Player���擾
            Player p = t.GetRegular(1);
            Console.WriteLine(p.Name);

            // �C���f�b�N�X���͈͂𒴂����ꍇ
            p = t.GetRegular(5);
            Console.WriteLine(p.Name); // �����\������Ȃ�
        }
    }
}