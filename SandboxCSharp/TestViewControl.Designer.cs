namespace SandboxCSharp
{
    partial class TestViewControl
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

        #region コンポーネント デザイナーで生成されたコード

        /// <summary> 
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を 
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.textBox_stdin = new System.Windows.Forms.TextBox();
            this.textBox_stdout = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.textBox_stdin);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.textBox_stdout);
            this.splitContainer1.Size = new System.Drawing.Size(354, 309);
            this.splitContainer1.SplitterDistance = 144;
            this.splitContainer1.TabIndex = 1;
            // 
            // textBox_stdin
            // 
            this.textBox_stdin.AcceptsReturn = true;
            this.textBox_stdin.AcceptsTab = true;
            this.textBox_stdin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_stdin.Font = new System.Drawing.Font("ＭＳ ゴシック", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_stdin.Location = new System.Drawing.Point(0, 0);
            this.textBox_stdin.Multiline = true;
            this.textBox_stdin.Name = "textBox_stdin";
            this.textBox_stdin.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_stdin.Size = new System.Drawing.Size(354, 144);
            this.textBox_stdin.TabIndex = 0;
            // 
            // textBox_stdout
            // 
            this.textBox_stdout.AcceptsReturn = true;
            this.textBox_stdout.AcceptsTab = true;
            this.textBox_stdout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_stdout.Font = new System.Drawing.Font("ＭＳ ゴシック", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_stdout.Location = new System.Drawing.Point(0, 0);
            this.textBox_stdout.Multiline = true;
            this.textBox_stdout.Name = "textBox_stdout";
            this.textBox_stdout.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_stdout.Size = new System.Drawing.Size(354, 161);
            this.textBox_stdout.TabIndex = 0;
            // 
            // TestViewControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Name = "TestViewControl";
            this.Size = new System.Drawing.Size(354, 309);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox textBox_stdin;
        private System.Windows.Forms.TextBox textBox_stdout;
    }
}
