using static System.Console;
using static System.Math;
using static System.DateTime; // 構造体も可能

class UsingStatic
{
    static void Main()
    {
        // System.Math.Sqrtの省略
        var sq = Sqrt( 10 * 10 );
        WriteLine( sq );            // 出力値：10

        // System.DateTime.Nowの省略
        WriteLine( Now );           // 出力値：2017/06/10 10:17:41
    }
}
