using System;

namespace Chap7_m
{
    // ���[�g�����}�C���ɕϊ�����N���X
    class GetMile
    {
        public double this[double m]
        {
            get
            {
                // �C���f�b�N�X��m���f�[�^�Ƃ��Ďg���Ă���
                return m * 1609.344;
            }
        }
    }

    class MainClass
    {
        static void Main()
        {
            GetMile gm = new GetMile();

            Console.WriteLine(gm[2]);
            Console.WriteLine(gm[3]);
        }
    }
}