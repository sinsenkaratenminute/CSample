namespace Chap8_3
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナ変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナで生成されたコード

        /// <summary>
        /// デザイナ サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディタで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.butList2 = new System.Windows.Forms.Button();
            this.butList3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnList1 = new System.Windows.Forms.Button();
            this.btnList4 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.moneyDataSet = new MoneyDataSet();
            this.moneyDataTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.日付DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.分類DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.品名DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.金額DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.備考DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moneyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moneyDataTableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // butList2
            // 
            this.butList2.Location = new System.Drawing.Point(12, 25);
            this.butList2.Name = "butList2";
            this.butList2.Size = new System.Drawing.Size(220, 25);
            this.butList2.TabIndex = 0;
            this.butList2.Text = "List2:データ型変換の記述例(1)";
            this.butList2.UseVisualStyleBackColor = true;
            this.butList2.Click += new System.EventHandler(this.butList2_Click);
            // 
            // butList3
            // 
            this.butList3.Location = new System.Drawing.Point(12, 90);
            this.butList3.Name = "butList3";
            this.butList3.Size = new System.Drawing.Size(220, 25);
            this.butList3.TabIndex = 1;
            this.butList3.Text = "List3:データ型変換の記述例(2)";
            this.butList3.UseVisualStyleBackColor = true;
            this.butList3.Click += new System.EventHandler(this.butList3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "8.3.2　●ToString()メソッドを使う";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "8.3.3　●Parse()メソッドを使う";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(271, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(245, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "8.3.4　●CSV形式のデータをデータセットに読み込む";
            // 
            // btnList1
            // 
            this.btnList1.Location = new System.Drawing.Point(274, 25);
            this.btnList1.Name = "btnList1";
            this.btnList1.Size = new System.Drawing.Size(242, 23);
            this.btnList1.TabIndex = 5;
            this.btnList1.Text = "List5　CSVファイル取り込みの記述例";
            this.btnList1.UseVisualStyleBackColor = true;
            this.btnList1.Click += new System.EventHandler(this.btnList1_Click);
            // 
            // btnList4
            // 
            this.btnList4.Location = new System.Drawing.Point(12, 133);
            this.btnList4.Name = "btnList4";
            this.btnList4.Size = new System.Drawing.Size(219, 23);
            this.btnList4.TabIndex = 6;
            this.btnList4.Text = "List4　CSVファイル作成の記述例";
            this.btnList4.UseVisualStyleBackColor = true;
            this.btnList4.Click += new System.EventHandler(this.btnList4_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.日付DataGridViewTextBoxColumn,
            this.分類DataGridViewTextBoxColumn,
            this.品名DataGridViewTextBoxColumn,
            this.金額DataGridViewTextBoxColumn,
            this.備考DataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.moneyDataTableBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 162);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(546, 247);
            this.dataGridView1.TabIndex = 7;
            // 
            // moneyDataSet
            // 
            this.moneyDataSet.DataSetName = "MoneyDataSet";
            this.moneyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // moneyDataTableBindingSource
            // 
            this.moneyDataTableBindingSource.DataMember = "moneyDataTable";
            this.moneyDataTableBindingSource.DataSource = this.moneyDataSet;
            // 
            // 日付DataGridViewTextBoxColumn
            // 
            this.日付DataGridViewTextBoxColumn.DataPropertyName = "日付";
            this.日付DataGridViewTextBoxColumn.HeaderText = "日付";
            this.日付DataGridViewTextBoxColumn.Name = "日付DataGridViewTextBoxColumn";
            // 
            // 分類DataGridViewTextBoxColumn
            // 
            this.分類DataGridViewTextBoxColumn.DataPropertyName = "分類";
            this.分類DataGridViewTextBoxColumn.HeaderText = "分類";
            this.分類DataGridViewTextBoxColumn.Name = "分類DataGridViewTextBoxColumn";
            // 
            // 品名DataGridViewTextBoxColumn
            // 
            this.品名DataGridViewTextBoxColumn.DataPropertyName = "品名";
            this.品名DataGridViewTextBoxColumn.HeaderText = "品名";
            this.品名DataGridViewTextBoxColumn.Name = "品名DataGridViewTextBoxColumn";
            // 
            // 金額DataGridViewTextBoxColumn
            // 
            this.金額DataGridViewTextBoxColumn.DataPropertyName = "金額";
            this.金額DataGridViewTextBoxColumn.HeaderText = "金額";
            this.金額DataGridViewTextBoxColumn.Name = "金額DataGridViewTextBoxColumn";
            // 
            // 備考DataGridViewTextBoxColumn
            // 
            this.備考DataGridViewTextBoxColumn.DataPropertyName = "備考";
            this.備考DataGridViewTextBoxColumn.HeaderText = "備考";
            this.備考DataGridViewTextBoxColumn.Name = "備考DataGridViewTextBoxColumn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 421);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnList4);
            this.Controls.Add(this.btnList1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.butList3);
            this.Controls.Add(this.butList2);
            this.Name = "Form1";
            this.Text = "Chapter8-3 文字列の処理サンプル";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moneyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moneyDataTableBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butList2;
        private System.Windows.Forms.Button butList3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnList1;
        private System.Windows.Forms.Button btnList4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 日付DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 分類DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 品名DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 金額DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 備考DataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource moneyDataTableBindingSource;
        private MoneyDataSet moneyDataSet;
    }
}

