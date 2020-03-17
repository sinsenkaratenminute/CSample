namespace TwitterPost
{
    partial class FormTwitterPost
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
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
            this.butAuthorize = new System.Windows.Forms.Button();
            this.txtPIN = new System.Windows.Forms.TextBox();
            this.butPIN = new System.Windows.Forms.Button();
            this.txtTweet = new System.Windows.Forms.TextBox();
            this.butTweet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // butAuthorize
            // 
            this.butAuthorize.Location = new System.Drawing.Point(12, 12);
            this.butAuthorize.Name = "butAuthorize";
            this.butAuthorize.Size = new System.Drawing.Size(75, 23);
            this.butAuthorize.TabIndex = 0;
            this.butAuthorize.Text = "Twitter連携";
            this.butAuthorize.UseVisualStyleBackColor = true;
            this.butAuthorize.Click += new System.EventHandler(this.butAuthorize_Click);
            // 
            // txtPIN
            // 
            this.txtPIN.Location = new System.Drawing.Point(12, 43);
            this.txtPIN.Name = "txtPIN";
            this.txtPIN.Size = new System.Drawing.Size(100, 19);
            this.txtPIN.TabIndex = 1;
            // 
            // butPIN
            // 
            this.butPIN.Location = new System.Drawing.Point(118, 41);
            this.butPIN.Name = "butPIN";
            this.butPIN.Size = new System.Drawing.Size(75, 23);
            this.butPIN.TabIndex = 2;
            this.butPIN.Text = "PIN入力";
            this.butPIN.UseVisualStyleBackColor = true;
            this.butPIN.Click += new System.EventHandler(this.butPIN_Click);
            // 
            // txtTweet
            // 
            this.txtTweet.Location = new System.Drawing.Point(12, 70);
            this.txtTweet.Multiline = true;
            this.txtTweet.Name = "txtTweet";
            this.txtTweet.Size = new System.Drawing.Size(260, 150);
            this.txtTweet.TabIndex = 3;
            // 
            // butTweet
            // 
            this.butTweet.Location = new System.Drawing.Point(197, 226);
            this.butTweet.Name = "butTweet";
            this.butTweet.Size = new System.Drawing.Size(75, 23);
            this.butTweet.TabIndex = 4;
            this.butTweet.Text = "ツイート";
            this.butTweet.UseVisualStyleBackColor = true;
            this.butTweet.Click += new System.EventHandler(this.butTweet_Click);
            // 
            // FormTwitterPost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.butTweet);
            this.Controls.Add(this.txtTweet);
            this.Controls.Add(this.butPIN);
            this.Controls.Add(this.txtPIN);
            this.Controls.Add(this.butAuthorize);
            this.Name = "FormTwitterPost";
            this.Text = "Twitter投稿";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butAuthorize;
        private System.Windows.Forms.TextBox txtPIN;
        private System.Windows.Forms.Button butPIN;
        private System.Windows.Forms.TextBox txtTweet;
        private System.Windows.Forms.Button butTweet;
    }
}

