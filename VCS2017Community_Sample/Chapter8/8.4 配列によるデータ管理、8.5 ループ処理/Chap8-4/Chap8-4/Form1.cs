using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Chap8_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // List1:サンプルコード（1週間に使用した金額の平均値を求める場合の記述例）
        private void butList1_Click(object sender, EventArgs e)
        {
            int moneySun = 1200; // 日曜日の出費
            int moneyMon = 750; // 月曜日の出費
            int moneyTue = 650; // 火曜日の出費
            int moneyWed = 680; // 水曜日の出費
            int moneyThu = 760; // 木曜日の出費
            int moneyFri = 980; // 金曜日の出費
            int moneySat = 1050; // 土曜日の出費
            int sum; // 一週間出費合計
            double average; // 一週間に使用した金額の平均値。小数以下も扱う型
            sum = moneySun + moneyMon + moneyTue + moneyWed + moneyThu + moneyFri +
            moneySat;
            average = sum / 7;
            MessageBox.Show(average.ToString());
        }

        // List 2: サンプルコード（配列の定義の記述例）
        private void butList2_Click(object sender, EventArgs e)
        {
            int[] moneyArray = new int[7];
            moneyArray[0] = 1200; // 日曜日の出費
            moneyArray[1] = 750; // 月曜日の出費
            moneyArray[2] = 650; // 火曜日の出費
            moneyArray[3] = 680; // 水曜日の出費
            moneyArray[4] = 760; // 木曜日の出費
            moneyArray[5] = 980; // 金曜日の出費
            moneyArray[6] = 1050; // 土曜日の出費
            int sum; // 一週間出費合計
            double average; // 一週間に使用した金額の平均値。小数以下も扱う型
            sum = moneyArray[0]
            + moneyArray[1]
            + moneyArray[2]
            + moneyArray[3]
            + moneyArray[4]
            + moneyArray[5]
            + moneyArray[6];
            average = sum / 7;
            MessageBox.Show(average.ToString());
        }

        // List 3:サンプルコード（forループ文の記述例）
        private void butList3_Click(object sender, EventArgs e)
        {
            int[] moneyArray = new int[7];
            moneyArray[0] = 1200; // 日曜日の出費
            moneyArray[1] = 750; // 月曜日の出費
            moneyArray[2] = 650; // 火曜日の出費
            moneyArray[3] = 680; // 水曜日の出費
            moneyArray[4] = 760; // 木曜日の出費
            moneyArray[5] = 980; // 金曜日の出費
            moneyArray[6] = 1050; // 土曜日の出費
            int sum; // 一週間出費合計
            double average; // 一週間に使用した金額の平均値。小数以下も扱う型
            sum = 0;
            for (int i = 0; i < 7; i++)
            {
                sum = sum + moneyArray[i];
            }
            average = sum / 7;
            MessageBox.Show(average.ToString());
        }

        // List 4:サンプルコード（doループ文の記述例）
        private void butList4_Click(object sender, EventArgs e)
        {
            int i = 0;
            do
            {
                MessageBox.Show(i.ToString());
                i++;
            } while (i < 3);
            MessageBox.Show("Doループ終了:" + i.ToString());
        }

        // List 5:サンプルコード（whileループ文の記述例）
        private void butList5_Click(object sender, EventArgs e)
        {
            int i = 0;
            while (i < 3)
            {
                MessageBox.Show(i.ToString());
                i++;
            }
            MessageBox.Show("whileループ終了:" + i.ToString());
        }

        // List 6:サンプルコード（forループ文の記述例）
        private void butList6_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < moneyDataSet.moneyDataTable.Rows.Count; i++)
            {
                moneyDataSet.moneyDataTable[i].品名 = "みかん";
            }
            // ブレークポイントで止めて MoneyDataSet の値をDataSetビジュアライザーで表示し、
            // 品名が「みかん」に変更されていることを確認してください
        }

        // List 7:サンプルコード（foreachループ文の記述例）
        private void butList7_Click(object sender, EventArgs e)
        {
            foreach (var dr in moneyDataSet.moneyDataTable)
            {
                dr.品名 = "みかん";
            }
            // ブレークポイントで止めて MoneyDataSet の値をDataSetビジュアライザーで表示し、
            // 品名が「みかん」に変更されていることを確認してください
        }

        // 初期化
        private void Form1_Load(object sender, EventArgs e)
        {
            string delimStr = ","; // 区切り文字
            char[] delimiter = delimStr.ToCharArray(); // 区切り文字をまとめる
            string[] strData;
            string strLine = "2011/07/07,食事,カレー,750,大盛";
            strData = strLine.Split(delimiter);
            moneyDataSet.moneyDataTable.AddmoneyDataTableRow(
            DateTime.Parse(strData[0]),
            strData[1],
            strData[2],
            int.Parse(strData[3]),
            strData[4]);
        }
    }
}
