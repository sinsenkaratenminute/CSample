using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalPolymorphismSample
{
    //　動物クラス
    public abstract class Animal
    {
        public string color;    // 色
        public string smell;    // 匂い
        public string taste;    // 味

        public abstract string Sing();
    }

    //　猫クラス
    public class Cat : Animal
    {
        public string ear;      // 耳の形

        public override string Sing()
        {
            return "ニャー";
        }
    }

    // 犬クラス
    public class Dog : Animal
    {
        public string nose;     // 鼻の形

        public override string Sing()
        {
            return "ワン";
        }
    }

    // 鳥クラス
    public class Bird : Animal
    {
        public string beak;     // くちばしの形

        public override string Sing()
        {
            return "ピヨ";
        }

    }
}
