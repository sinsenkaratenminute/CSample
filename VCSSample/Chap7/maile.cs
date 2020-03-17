using System;

namespace Chap7_m
{
    // メートルをマイルに変換するクラス
    class GetMile
    {
        public double this[double m]
        {
            get
            {
                // インデックスのmをデータとして使っている
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