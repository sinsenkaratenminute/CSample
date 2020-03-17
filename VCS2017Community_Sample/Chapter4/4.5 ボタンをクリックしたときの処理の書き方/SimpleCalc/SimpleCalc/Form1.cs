using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CalcButton_Click(object sender, EventArgs e)
        {
            // 変数の宣言
            int valueLeft;                               // 入力値1用の整数型変数
            int valueRight;                              // 入力値1用の整数型変数
            int valueAnswer;                             // 計算結果用整数型変数
            // 値の取り込み
            valueLeft = int.Parse(Input1TextBox.Text);   // 入力値1を整数型に変換後代入
            valueRight = int.Parse(Input2TextBox.Text);  // 入力値2を整数型に変換後代入
            // 取り込んだ値の計算
            valueAnswer = valueLeft + valueRight;
            // 計算結果を出力
            AnswerTextBox.Text = valueAnswer.ToString(); // 文字列に変換後代入
        }
    }
}
