using static System.Console;
using static System.Math;
using static System.DateTime; // �\���̂��\

class UsingStatic
{
    static void Main()
    {
        // System.Math.Sqrt�̏ȗ�
        var sq = Sqrt( 10 * 10 );
        WriteLine( sq );            // �o�͒l�F10

        // System.DateTime.Now�̏ȗ�
        WriteLine( Now );           // �o�͒l�F2017/06/10 10:17:41
    }
}
