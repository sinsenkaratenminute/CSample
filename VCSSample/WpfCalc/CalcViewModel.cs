﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace WpfCalc
{
    abstract class ViewModelBase : INotifyPropertyChanged
    {
        // プロパティの変更通知
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
    class CalcViewModel : ViewModelBase
    {
        // 計算結果のプロパティ
        public string Label { get; private set; } = "0";

        // 電卓クラスのインスタンス化
        ClassCalc Calc = new ClassCalc();

        // 数字ボタンが押されたときの処理
        public void NumCommand(object content)
        {
            // ボタン名を数値に変換
            var n = int.Parse((string)content);

            // 電卓クラスの、数字キー処理を呼び出す
            Calc.NumKey(n);

            // 計算結果の設定
            Label = Calc.Result;
            OnPropertyChanged(nameof(Label));
        }
        // 演算ボタンのイベントハンドラ
        public void CmdCommand(object content)
        {
            switch ((string)content)
            {
                case "C":
                    // 初期化処理
                    Calc.ClrKey();
                    break;

                case ".":
                    Calc.DotKey();
                    break;

                case "/":
                    Calc.DivisionKey();
                    break;

                case "*":
                    Calc.MultiKey();
                    break;

                case "+":
                    Calc.PlusKey();
                    break;

                case "-":
                    Calc.MinusKey();
                    break;

                case "=":
                    Calc.EnterKey();
                    break;
            }

            // 計算結果の設定
            Label = Calc.Result;
            OnPropertyChanged(nameof(Label));
        }
    }
}
