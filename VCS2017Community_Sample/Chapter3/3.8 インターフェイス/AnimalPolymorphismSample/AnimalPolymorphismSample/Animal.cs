using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalPolymorphismSample
{
    // トッピングインターフェイス
    public interface ITopping
    {
        string WrapChocolate();
    }

    //　動物クラス
    public abstract class Animal
    {
        public string color;    // 色
        public string smell;    // 匂い
        public string taste;    // 味

        public abstract string Sing();
    }

    //　猫クラス
    public class Cat : Animal, ITopping
    {
        public string ear;      // 耳の形

        












        public override string Sing()
        {
            return "ニャー";
        }

        public string WrapChocolate()
        {
            return "ホワイトチョコ";
        }
    }

    // 犬クラス
    public class Dog : Animal, ITopping
    {
        public string nose;     // 鼻の形

        public override string Sing()
        {
            return "ワン";
        }
        public string WrapChocolate()
        {
            return "ビターチョコ";
        }
    }

    // 鳥クラス
    public class Bird : Animal, ITopping
    {
        public string beak;     // くちばしの形

        public override string Sing()
        {
            return "ピヨ";
        }

        public string WrapChocolate()
        {
            return "チョコ";
        }
    }
}
