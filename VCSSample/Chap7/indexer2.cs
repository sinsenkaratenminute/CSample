using System;
using System.Collections.Generic;
namespace Chap7_13
{
    class MainClass
    {
        static void Main()
        {
            Dictionary<string, string> dict = new Dictionary<string, string>();

            dict["Mon"] = "��";  // �v�f�̒ǉ�
            dict["Tue"] = "��";  // �V

            Console.WriteLine(dict["Mon"]); // �o�͒l�F��
        }
    }
}
