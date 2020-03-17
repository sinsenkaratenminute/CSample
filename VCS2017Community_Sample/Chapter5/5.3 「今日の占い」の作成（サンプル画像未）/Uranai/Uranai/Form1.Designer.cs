namespace Uranai
{
    partial class FormUranai
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
            this.textResult = new System.Windows.Forms.TextBox();
            this.pictureBoxResult = new System.Windows.Forms.PictureBox();
            this.buttonUranaiStart = new System.Windows.Forms.Button();
            this.dateTimeUranai = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxResult)).BeginInit();
            this.SuspendLayout();
            // 
            // textResult
            // 
            this.textResult.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textResult.Location = new System.Drawing.Point(12, 171);
            this.textResult.Multiline = true;
            this.textResult.Name = "textResult";
            this.textResult.Size = new System.Drawing.Size(260, 79);
            this.textResult.TabIndex = 9;
            // 
            // pictureBoxResult
            // 
            this.pictureBoxResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxResult.Image = global::Uranai.Properties.Resources.Title;
            this.pictureBoxResult.Location = new System.Drawing.Point(14, 65);
            this.pictureBoxResult.Name = "pictureBoxResult";
            this.pictureBoxResult.Size = new System.Drawing.Size(256, 100);
            this.pictureBoxResult.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxResult.TabIndex = 8;
            this.pictureBoxResult.TabStop = false;
            // 
            // buttonUranaiStart
            // 
            this.buttonUranaiStart.Location = new System.Drawing.Point(12, 36);
            this.buttonUranaiStart.Name = "buttonUranaiStart";
            this.buttonUranaiStart.Size = new System.Drawing.Size(260, 23);
            this.buttonUranaiStart.TabIndex = 7;
            this.buttonUranaiStart.Text = "占う";
            this.buttonUranaiStart.UseVisualStyleBackColor = true;
            this.buttonUranaiStart.Click += new System.EventHandler(this.buttonUranaiStart_Click);
            // 
            // dateTimeUranai
            // 
            this.dateTimeUranai.Location = new System.Drawing.Point(81, 11);
            this.dateTimeUranai.Name = "dateTimeUranai";
            this.dateTimeUranai.Size = new System.Drawing.Size(191, 19);
            this.dateTimeUranai.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "今日の日付";
            // 
            // FormUranai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.textResult);
            this.Controls.Add(this.pictureBoxResult);
            this.Controls.Add(this.buttonUranaiStart);
            this.Controls.Add(this.dateTimeUranai);
            this.Controls.Add(this.label1);
            this.Name = "FormUranai";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "占い";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textResult;
        private System.Windows.Forms.PictureBox pictureBoxResult;
        private System.Windows.Forms.Button buttonUranaiStart;
        private System.Windows.Forms.DateTimePicker dateTimeUranai;
        private System.Windows.Forms.Label label1;
    }
}

