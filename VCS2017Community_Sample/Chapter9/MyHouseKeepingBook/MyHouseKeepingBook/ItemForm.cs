﻿using System;
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
    public partial class ItemForm : Form
    {
        private ItemForm()
        {
            // 引数なしのコンストラクタは使用しない
        }

        public ItemForm(CategoryDataSet dsCategory)
        {
            InitializeComponent();
            categoryDataSet.Merge(dsCategory);
        }

        public ItemForm(CategoryDataSet dsCategory,
                        DateTime nowDate,
                        string category,
                        string item,
                        int money,
                        string remarks)
        {
            InitializeComponent(); //初期化処理
            categoryDataSet.Merge(dsCategory);
            monCalendar.SetDate(nowDate);
            cmbCategory.Text = category;
            txtItem.Text = item;
            mtxtMoney.Text = money.ToString();
            txtRemarks.Text = remarks;
        }
    }
}
