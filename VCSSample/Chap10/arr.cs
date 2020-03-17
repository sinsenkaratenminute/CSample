using System;
namespace Chap10_2
{
    class MainClass
    {
        static void Main()
        {
            int[] array2 = { 1, 3, 5 };
            string[] weekDays = { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" };

            Console.WriteLine(weekDays[array2[1]]); // èoóÕíl: Wed
        }
    }
}
