using System;
namespace Chap11_event
{
    // SampleEventHandler�Ƃ������O�̃f���Q�[�g���`
    delegate void SampleEventHandler();
    // �C�x���g�𔭐�������N���X
    class TestClass
    {
        // �������\�b�h���g����event��threeEvent��������
        public event SampleEventHandler ThreeEvent = delegate { };
        // �����_�����g�����ꍇ
        // public event SampleEventHandler threeEvent = () => {};
        // 1�`20��\���B�������A3�̔{���̂Ƃ��̓C�x���g�𔭐�������
        public void OnThreeEvent()
        {
            for (int i = 1; i <= 20; i++)
            {
                Console.WriteLine(i);
                if (i % 3 == 0)
                {
                    ThreeEvent();
                }
            }
        }
    }
    class MainClass
    {
        public static void Main()
        {
            TestClass t = new TestClass();
            // �C�x���g�n���h���[��ǉ�
            t.ThreeEvent += delegate { Console.WriteLine("�~�~"); };
            // �����_�����g�����ꍇ
            // t.threeEvent += ( ) => Console.WriteLine( "�~�~" );
            // �C�x���g���������鏈��
            t.OnThreeEvent();
        }
    }
}