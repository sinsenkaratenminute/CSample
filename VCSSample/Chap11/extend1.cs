using System;
namespace Chap11_extend1
{
    // �g�����\�b�h���`�����N���X
    static class ExtendTestClass
    {
        // �g�����\�b�h�i�얞�x����j
        public static void CheckJ(this TestClass t)
        {
            // BMI��25�ȏ��얞�A18�������₹�����A����ȊO��W���Ƃ���B
            if (25 <= t.BMI())
            {
                Console.WriteLine("�얞�ł�");
            }
            else if (t.BMI() < 18)
            {
                Console.WriteLine("�₹�����ł�");
            }
            else
            {
                Console.WriteLine("�W���ł�");
            }
        }
    }

    // �̏d�A�g����ێ�����BMI�l���o�͂���N���X
    class TestClass
    {
        // �̏d�̃v���p�e�B
        public double Weight { get; }

        // �g���̃v���p�e�B
        public double Height { get; set; }


        // �̏d�A�g�����w�肵�ď�����
        public TestClass(double w, double h)
        {
            this.Weight = w; �@�@�@// �L���O����
            this.Height = h / 100; // �Z���`���[�g�������[�g���ɕϊ����Ċi�[
        }

        // BMI�l�����߂�
        public double BMI()
        {
            return this.Weight / (this.Height * this.Height);
        }
    }

    class MainClass
    {
        public static void Main()
        {
            // �g���Ƒ̏d���w��i�L���O�����A�Z���`���[�g���j
            TestClass a = new TestClass(80, 170);

            // �얞�x�̔���i�g�����\�b�h�j
            a.CheckJ();    // �o�͒l�F�얞�ł�

            var b = new TestClass(40, 160);
            b.CheckJ();    // �o�͒l�F�₹�����ł�
        }
    }
}