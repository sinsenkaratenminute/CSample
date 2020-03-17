using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyHouseKeepingBook
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            AddData();
        }

        private void 追加AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddData();
        }

        private void AddData()
        {
            ItemForm frmItem = new ItemForm(categoryDataSet1);
            DialogResult drRet = frmItem.ShowDialog();
            if (drRet == DialogResult.OK)
            {
                moneyDataSet.moneyDataTable.AddmoneyDataTableRow(
                frmItem.monCalendar.SelectionRange.Start,
                frmItem.cmbCategory.Text,
                frmItem.txtItem.Text,
                int.Parse(frmItem.mtxtMoney.Text),
                frmItem.txtRemarks.Text);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            categoryDataSet1.CategoryDataTable.AddCategoryDataTableRow("給料", "入金");
            categoryDataSet1.CategoryDataTable.AddCategoryDataTableRow("食費", "出金");
            categoryDataSet1.CategoryDataTable.AddCategoryDataTableRow("雑費", "出金");
            categoryDataSet1.CategoryDataTable.AddCategoryDataTableRow("住居", "出金");
        }

        private void buttonEnd_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void 終了XToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SaveData()
        {
            string path = "MoneyData.csv"; //出力ファイル名
            string strData = ""; //1行分のデータ
            System.IO.StreamWriter sw = new System.IO.StreamWriter(
                    path,
                    false,
                    System.Text.Encoding.Default);
            foreach (MoneyDataSet.moneyDataTableRow drMoney
            in moneyDataSet.moneyDataTable)
            {
                strData = drMoney.日付.ToShortDateString() + ","
                        + drMoney.分類 + ","
                        + drMoney.品名 + ","
                        + drMoney.金額.ToString() + ","
                        + drMoney.備考;
                sw.WriteLine(strData);
            }
            sw.Close();
        }

        private void 保存SToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveData();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveData();
        }
    }
}
