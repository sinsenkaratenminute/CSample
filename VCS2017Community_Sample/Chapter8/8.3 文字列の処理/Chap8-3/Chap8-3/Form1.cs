using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Chap8_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // List2:データ型変換の記述例(1)
        private void butList2_Click(object sender, EventArgs e)
        {
            String strData; // 変換後の値を入れる変数
            // 日付型を文字列型に変換する例
            DateTime dtmEntryDate = DateTime.Today;
            strData = dtmEntryDate.ToString();
            MessageBox.Show(strData);

            // 数値型を文字列型に変換する例
            int intDataCount = 10;
            strData = intDataCount.ToString();
            MessageBox.Show(strData);
        }

        // List3:データ型変換の記述例(2)
        private void butList3_Click(object sender, EventArgs e)
        {
            String strData; // 変換前の値を入れる変数
            // 文字列を日付型に変換
            strData = "2006/10/10"; // 文字列
            DateTime dtmEntryDate;
            dtmEntryDate = DateTime.Parse(strData);

            // 文字列を数値型に変換
            strData = "1000"; // 文字列
            int intDataCount;
            intDataCount = int.Parse(strData);

            MessageBox.Show("実行結果を確認するには、ブレークポイントを設定して変数の値を確認してください。");
        }

        // List4　CSVファイル作成の記述例
        private void btnList4_Click(object sender, EventArgs e)
        {
            string strData; // 変換前の値を入れる変数
            strData = moneyDataSet.moneyDataTable[0].日付.ToShortDateString() + "," +
            moneyDataSet.moneyDataTable[0].分類 + "," +
            moneyDataSet.moneyDataTable[0].品名 + "," +
            moneyDataSet.moneyDataTable[0].金額.ToString() + "," +
            moneyDataSet.moneyDataTable[0].備考;
            MessageBox.Show(strData);
        }

        // List5　CSVファイル取り込みの記述例
        private void btnList1_Click(object sender, EventArgs e)
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

        // 初期化処理　
        // Form1表示時に初期データを挿入します。処理はList5と同じです。
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
