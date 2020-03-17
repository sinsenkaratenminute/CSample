
using System;

namespace Practice8_3
{
    interface DoAnimal
    {
        void Cry();
    }
    class Animal
    {
        // ...その他のメンバー...
    }

    // Animalクラスを継承してDoAnimalインターフェイスを実装する
    class Dog : Animal, DoAnimal
    {
        public void Cry()
        {
            Console.WriteLine("bow-wow");
        }
    }

}
