namespace SimpleCalc
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
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

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.CalcButton = new System.Windows.Forms.Button();
            this.AnswerTextBox = new System.Windows.Forms.TextBox();
            this.EqualLabel = new System.Windows.Forms.Label();
            this.Input2TextBox = new System.Windows.Forms.TextBox();
            this.PlusLabel = new System.Windows.Forms.Label();
            this.Input1TextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CalcButton
            // 
            this.CalcButton.Location = new System.Drawing.Point(33, 46);
            this.CalcButton.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.CalcButton.Name = "CalcButton";
            this.CalcButton.Size = new System.Drawing.Size(575, 34);
            this.CalcButton.TabIndex = 11;
            this.CalcButton.Text = "計算する";
            this.CalcButton.UseVisualStyleBackColor = true;
            this.CalcButton.Click += new System.EventHandler(this.CalcButton_Click);
            // 
            // AnswerTextBox
            // 
            this.AnswerTextBox.Location = new System.Drawing.Point(442, 9);
            this.AnswerTextBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.AnswerTextBox.Name = "AnswerTextBox";
            this.AnswerTextBox.Size = new System.Drawing.Size(164, 25);
            this.AnswerTextBox.TabIndex = 10;
            // 
            // EqualLabel
            // 
            this.EqualLabel.AutoSize = true;
            this.EqualLabel.Location = new System.Drawing.Point(413, 14);
            this.EqualLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.EqualLabel.Name = "EqualLabel";
            this.EqualLabel.Size = new System.Drawing.Size(17, 18);
            this.EqualLabel.TabIndex = 9;
            this.EqualLabel.Text = "=";
            // 
            // Input2TextBox
            // 
            this.Input2TextBox.Location = new System.Drawing.Point(237, 9);
            this.Input2TextBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Input2TextBox.Name = "Input2TextBox";
            this.Input2TextBox.Size = new System.Drawing.Size(164, 25);
            this.Input2TextBox.TabIndex = 8;
            // 
            // PlusLabel
            // 
            this.PlusLabel.AutoSize = true;
            this.PlusLabel.Location = new System.Drawing.Point(208, 14);
            this.PlusLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.PlusLabel.Name = "PlusLabel";
            this.PlusLabel.Size = new System.Drawing.Size(17, 18);
            this.PlusLabel.TabIndex = 7;
            this.PlusLabel.Text = "+";
            // 
            // Input1TextBox
            // 
            this.Input1TextBox.Location = new System.Drawing.Point(32, 9);
            this.Input1TextBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Input1TextBox.Name = "Input1TextBox";
            this.Input1TextBox.Size = new System.Drawing.Size(164, 25);
            this.Input1TextBox.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 92);
            this.Controls.Add(this.CalcButton);
            this.Controls.Add(this.AnswerTextBox);
            this.Controls.Add(this.EqualLabel);
            this.Controls.Add(this.Input2TextBox);
            this.Controls.Add(this.PlusLabel);
            this.Controls.Add(this.Input1TextBox);
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form1";
            this.Text = "簡単計算プログラム";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CalcButton;
        private System.Windows.Forms.TextBox AnswerTextBox;
        private System.Windows.Forms.Label EqualLabel;
        private System.Windows.Forms.TextBox Input2TextBox;
        private System.Windows.Forms.Label PlusLabel;
        private System.Windows.Forms.TextBox Input1TextBox;
    }
}

