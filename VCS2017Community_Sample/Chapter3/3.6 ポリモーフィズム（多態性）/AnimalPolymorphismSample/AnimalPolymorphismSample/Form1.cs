using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnimalPolymorphismSample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cat cat1;               // 猫クラスのインスタンスを生成するための変数を定義
            Dog dog1;               // 犬クラスのインスタンスを生成するための変数を定義
            Bird bird1;             // 鳥クラスのインスタンスを生成するための変数を定義

            cat1 = new Cat();       // 猫クラスのインスタンスを生成し、動物クラスのインスタンス（入れ物）に代入
            dog1 = new Dog();       // 犬クラスのインスタンスを生成し、動物クラスのインスタンス（入れ物）に代入
            bird1 = new Bird();     // 鳥クラスのインスタンスを生成し、動物クラスのインスタンス（入れ物）に代入

            textBox1.Text = cat1.Sing();            // 動物クラスのインスタンス.鳴く() で鳴き声を表示
            textBox2.Text = dog1.Sing();            // 動物クラスのインスタンス.鳴く() で鳴き声を表示
            textBox3.Text = bird1.Sing();           // 動物クラスのインスタンス.鳴く() で鳴き声を表示

        }
    }
}
