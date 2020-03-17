using System;
using System.Collections.Generic;
namespace Chap12_7_index
{
    class MainClass
    {
        class Medal
        {
            int gold;
            int silver;
            int bronze;

            // �R���X�g���N�^
            public Medal(int g, int s, int b)
            {
                gold = g;
                silver = s;
                bronze = b;
            }

            // �t�B�[���h�̒l���o��
            public void output()
            {
                Console.WriteLine("���F{0}, ��F{1}, ���F{2}", gold, silver, bronze);
            }
        }

        static void Main()
        {
            // 1�F�L�[�𕶎���A�l��Medal�N���X�Ƃ��ăC���X�^���X��
            // 2�F�v�f��ǉ��i�C���f�b�N�X�������q�ł̏������j
            var win = new Dictionary<string, Medal>()
            {
                ["Japan"] = new Medal(20, 10, 8),
                ["China"] = new Medal(10, 5, 30),
                ["USA"] = new Medal(15, 10, 2)
            };

        // 3�F"USA"���L�[��Medal�N���X���擾���ďo��
        var m = win["USA"];
            m.output();

            try
            {
                // 4�F"Russia"���L�[�Ƃ��Ēl���擾���悤�Ƃ����
                m = win["Russia"];
                m.output();
            }
            catch (Exception e)
            {
                // "Russia"�̓L�[�ɂȂ��̂ŗ�O������
                Console.WriteLine(e.Message);
            }

            // 5�F"China"���L�[��Medal�N���X���擾���ďo��
            win.TryGetValue("China", out m);
            m.output();

            // 6�F"����"�̓L�[�ɂȂ��̂�m�͎Q�ƌ^�̊���l�ł���null�ƂȂ�
            win.TryGetValue("����", out m);
            Console.WriteLine(m == null);

            // 7�F�L�[�����݂��邩�ǂ������m�F
            if (win.ContainsKey("Japan"))
            {
                Console.WriteLine("����");
            }

            // 8�F�l�����邩�ǂ����̊m�F
            win.TryGetValue("USA", out m);
            if (win.ContainsValue(m))
            {
                Console.WriteLine("�l����");
            }

            // 9�F�L�[�ƒl���
            foreach (KeyValuePair<string, Medal> kp in win)
            {
                Console.Write("{0} �@", kp.Key);
                kp.Value.output();
            }
        }
    }
}