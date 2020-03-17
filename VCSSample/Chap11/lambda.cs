using System;
namespace Chap11_lambda
{
    public class SampleLambda
    {
        private int num;
        private string[] str_nums = new string[5];

        // �����_���ɂ��v���p�e�B�[�igetter�Ɠ����j
        public string Name => "nothing";

        public string this[int key]
        {
            // �C���f�N�T�[��getter
            get => str_nums[key];

            // �C���f�N�T�[��setter
            set => str_nums[key] = value;
        }

        // �����_���ɂ��R���X�g���N�^�[
        public SampleLambda() => num = 3;

        // �����_���ɂ�郁�\�b�h
        public int Multi(int a) => a * num;
        // �ȉ��Ɠ���
        // public int Multi( int a )
        // {
        //    return a * num;
        // }
    }

    class Program
    {
        static void Main()
        {
            var c = new SampleLambda();

            Console.WriteLine(c.Name);      // �o�͒l�Fnothing
            Console.WriteLine(c.Multi(5));  // �o�͒l�F15

            c[1] = "test";
            Console.WriteLine(c[1]);        // �o�͒l�Ftest
        }
    }

}