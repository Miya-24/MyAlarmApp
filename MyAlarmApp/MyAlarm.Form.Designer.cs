
namespace MyAlarmApp
{
    partial class MyAlarmForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
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
            this.StartButton = new System.Windows.Forms.Button();
            this.StopButton = new System.Windows.Forms.Button();
            this.TimeValueTextBox = new System.Windows.Forms.TextBox();
            this.TimeComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(82, 235);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(99, 40);
            this.StartButton.TabIndex = 0;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // StopButton
            // 
            this.StopButton.Location = new System.Drawing.Point(222, 235);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(99, 40);
            this.StopButton.TabIndex = 1;
            this.StopButton.Text = "Stop";
            this.StopButton.UseVisualStyleBackColor = true;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // TimeValueTextBox
            // 
            this.TimeValueTextBox.Location = new System.Drawing.Point(82, 141);
            this.TimeValueTextBox.Name = "TimeValueTextBox";
            this.TimeValueTextBox.Size = new System.Drawing.Size(129, 19);
            this.TimeValueTextBox.TabIndex = 2;
            this.TimeValueTextBox.TextChanged += new System.EventHandler(this.TimeValueTextBox_TextChanged);
            // 
            // TimeComboBox
            // 
            this.TimeComboBox.AllowDrop = true;
            this.TimeComboBox.FormattingEnabled = true;
            this.TimeComboBox.Items.AddRange(new object[] {
            "Seconds",
            "Minutes",
            "Hours"});
            this.TimeComboBox.Location = new System.Drawing.Point(252, 141);
            this.TimeComboBox.Name = "TimeComboBox";
            this.TimeComboBox.Size = new System.Drawing.Size(69, 20);
            this.TimeComboBox.TabIndex = 3;
            this.TimeComboBox.SelectedIndexChanged += new System.EventHandler(this.TimeComboBox_SelectedIndexChanged);
            // 
            // MyAlarmForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 372);
            this.Controls.Add(this.TimeComboBox);
            this.Controls.Add(this.TimeValueTextBox);
            this.Controls.Add(this.StopButton);
            this.Controls.Add(this.StartButton);
            this.Name = "MyAlarmForm";
            this.Text = "MyAlarm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.TextBox TimeValueTextBox;
        private System.Windows.Forms.ComboBox TimeComboBox;
    }
}

