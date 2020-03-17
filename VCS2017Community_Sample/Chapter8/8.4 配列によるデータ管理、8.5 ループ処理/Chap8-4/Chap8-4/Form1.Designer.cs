namespace Chap8_4
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
            this.butList1 = new System.Windows.Forms.Button();
            this.butList2 = new System.Windows.Forms.Button();
            this.butList3 = new System.Windows.Forms.Button();
            this.butList4 = new System.Windows.Forms.Button();
            this.butList5 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.butList6 = new System.Windows.Forms.Button();
            this.butList7 = new System.Windows.Forms.Button();
            this.moneyDataSet = new Chap8_4.MoneyDataSet();
            ((System.ComponentModel.ISupportInitialize)(this.moneyDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // butList1
            // 
            this.butList1.Location = new System.Drawing.Point(12, 27);
            this.butList1.Name = "butList1";
            this.butList1.Size = new System.Drawing.Size(219, 23);
            this.butList1.TabIndex = 0;
            this.butList1.Text = "List1";
            this.butList1.UseVisualStyleBackColor = true;
            this.butList1.Click += new System.EventHandler(this.butList1_Click);
            // 
            // butList2
            // 
            this.butList2.Location = new System.Drawing.Point(12, 55);
            this.butList2.Name = "butList2";
            this.butList2.Size = new System.Drawing.Size(219, 23);
            this.butList2.TabIndex = 1;
            this.butList2.Text = "List2";
            this.butList2.UseVisualStyleBackColor = true;
            this.butList2.Click += new System.EventHandler(this.butList2_Click);
            // 
            // butList3
            // 
            this.butList3.Location = new System.Drawing.Point(12, 107);
            this.butList3.Name = "butList3";
            this.butList3.Size = new System.Drawing.Size(219, 23);
            this.butList3.TabIndex = 2;
            this.butList3.Text = "List1";
            this.butList3.UseVisualStyleBackColor = true;
            this.butList3.Click += new System.EventHandler(this.butList3_Click);
            // 
            // butList4
            // 
            this.butList4.Location = new System.Drawing.Point(12, 159);
            this.butList4.Name = "butList4";
            this.butList4.Size = new System.Drawing.Size(219, 23);
            this.butList4.TabIndex = 3;
            this.butList4.Text = "List2";
            this.butList4.UseVisualStyleBackColor = true;
            this.butList4.Click += new System.EventHandler(this.butList4_Click);
            // 
            // butList5
            // 
            this.butList5.Location = new System.Drawing.Point(12, 210);
            this.butList5.Name = "butList5";
            this.butList5.Size = new System.Drawing.Size(219, 23);
            this.butList5.TabIndex = 4;
            this.butList5.Text = "List3";
            this.butList5.UseVisualStyleBackColor = true;
            this.butList5.Click += new System.EventHandler(this.butList5_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "8.4 ●配列を使う";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "8.5.1 ●For～Next文を使う";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "8.5.2 ●Do～Loop While文を使う";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(172, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "8.5.3 ●While～End While文を使う";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 249);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(157, 12);
            this.label5.TabIndex = 6;
            this.label5.Text = "8.5.4 ●For Each Next文を使う";
            // 
            // butList6
            // 
            this.butList6.Location = new System.Drawing.Point(13, 265);
            this.butList6.Name = "butList6";
            this.butList6.Size = new System.Drawing.Size(219, 21);
            this.butList6.TabIndex = 7;
            this.butList6.Text = "List4";
            this.butList6.UseVisualStyleBackColor = true;
            this.butList6.Click += new System.EventHandler(this.butList6_Click);
            // 
            // butList7
            // 
            this.butList7.Location = new System.Drawing.Point(13, 293);
            this.butList7.Name = "butList7";
            this.butList7.Size = new System.Drawing.Size(219, 21);
            this.butList7.TabIndex = 8;
            this.butList7.Text = "List5";
            this.butList7.UseVisualStyleBackColor = true;
            this.butList7.Click += new System.EventHandler(this.butList7_Click);
            // 
            // moneyDataSet
            // 
            this.moneyDataSet.DataSetName = "MoneyDataSet";
            this.moneyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(243, 328);
            this.Controls.Add(this.butList7);
            this.Controls.Add(this.butList6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.butList5);
            this.Controls.Add(this.butList4);
            this.Controls.Add(this.butList3);
            this.Controls.Add(this.butList2);
            this.Controls.Add(this.butList1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.moneyDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butList1;
        private System.Windows.Forms.Button butList2;
        private System.Windows.Forms.Button butList3;
        private System.Windows.Forms.Button butList4;
        private System.Windows.Forms.Button butList5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button butList6;
        private System.Windows.Forms.Button butList7;
        private Chap8_4.MoneyDataSet moneyDataSet;
    }
}

