using System;
using System.Linq;
namespace Chap12_15
{
    class MainClass
    {
        static void Main()
        {
            // ���l�^�̔z��f�[�^
            int[] num = { 1, 2, 9, 28, 30, 31, 15, 42 };

            // 30�����𒊏o�iLINQ�̃N�G�����j
            var numsQuery = from n in num
                            where n < 30
                            select n;

            // ���ʃf�[�^��\��
            foreach (var x in numsQuery)
            {
                Console.Write("{0}, ", x);
            }

            Console.WriteLine();

            // 3�̔{���𒊏o�iLINQ�̃��\�b�h�\���j
            var numsMethod = num.Where(x => (x % 3) == 0);

            // ���ʃf�[�^��\��
            foreach (var x in numsMethod)
            {
                Console.Write("{0}, ", x);
            }
        }
    }
}
