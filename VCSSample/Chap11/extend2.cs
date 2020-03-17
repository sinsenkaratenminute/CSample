using System;
namespace Chap11_extend2
{
    public static class StringExtender
    {
        // �g�����\�b�h(16�i������𐔒l�^�ɕϊ�)
        public static int Hex2Int(this string s)
        {
            return Convert.ToInt32(s, 16);
        }
    }

    class Program
    {
        static void Main()
        {
            string s = "D3";
            Console.WriteLine(s.Hex2Int()); // �o�͒l�F211
        }
    }
}