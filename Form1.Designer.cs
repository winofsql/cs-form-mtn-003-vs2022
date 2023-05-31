namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ヘッド部 = new GroupBox();
            社員コード = new TextBox();
            ラベル1 = new Label();
            ラベル2 = new Label();
            確認 = new Button();
            処理区分 = new ComboBox();
            ラベル3 = new Label();
            ラベル4 = new Label();
            Label5 = new Label();
            ボディ部 = new GroupBox();
            給与 = new TextBox();
            氏名 = new TextBox();
            生年月日 = new DateTimePicker();
            更新 = new Button();
            キャンセル = new Button();
            メインメニュー = new MenuStrip();
            テストToolStripMenuItem = new ToolStripMenuItem();
            ヘッド部.SuspendLayout();
            ボディ部.SuspendLayout();
            メインメニュー.SuspendLayout();
            SuspendLayout();
            // 
            // ヘッド部
            // 
            ヘッド部.Controls.Add(社員コード);
            ヘッド部.Controls.Add(ラベル1);
            ヘッド部.Controls.Add(ラベル2);
            ヘッド部.Controls.Add(確認);
            ヘッド部.Controls.Add(処理区分);
            ヘッド部.Location = new Point(64, 56);
            ヘッド部.Margin = new Padding(4);
            ヘッド部.Name = "ヘッド部";
            ヘッド部.Padding = new Padding(4);
            ヘッド部.Size = new Size(559, 139);
            ヘッド部.TabIndex = 2;
            ヘッド部.TabStop = false;
            ヘッド部.Text = "ヘッド部";
            // 
            // 社員コード
            // 
            社員コード.Location = new Point(141, 83);
            社員コード.Name = "社員コード";
            社員コード.Size = new Size(51, 23);
            社員コード.TabIndex = 3;
            // 
            // ラベル1
            // 
            ラベル1.AutoSize = true;
            ラベル1.Location = new Point(24, 38);
            ラベル1.Margin = new Padding(4, 0, 4, 0);
            ラベル1.Name = "ラベル1";
            ラベル1.Size = new Size(55, 15);
            ラベル1.TabIndex = 0;
            ラベル1.Text = "処理区分";
            // 
            // ラベル2
            // 
            ラベル2.AutoSize = true;
            ラベル2.Location = new Point(24, 86);
            ラベル2.Margin = new Padding(4, 0, 4, 0);
            ラベル2.Name = "ラベル2";
            ラベル2.Size = new Size(55, 15);
            ラベル2.TabIndex = 1;
            ラベル2.Text = "社員コード";
            // 
            // 確認
            // 
            確認.Location = new Point(404, 34);
            確認.Margin = new Padding(4);
            確認.Name = "確認";
            確認.Size = new Size(133, 26);
            確認.TabIndex = 4;
            確認.Text = "確認";
            確認.UseVisualStyleBackColor = true;
            確認.Click += 確認_Click;
            // 
            // 処理区分
            // 
            処理区分.CausesValidation = false;
            処理区分.DropDownStyle = ComboBoxStyle.DropDownList;
            処理区分.FormattingEnabled = true;
            処理区分.Items.AddRange(new object[] { "新規", "修正", "削除" });
            処理区分.Location = new Point(140, 34);
            処理区分.Margin = new Padding(4);
            処理区分.Name = "処理区分";
            処理区分.Size = new Size(148, 23);
            処理区分.TabIndex = 2;
            // 
            // ラベル3
            // 
            ラベル3.AutoSize = true;
            ラベル3.Location = new Point(24, 52);
            ラベル3.Margin = new Padding(4, 0, 4, 0);
            ラベル3.Name = "ラベル3";
            ラベル3.Size = new Size(31, 15);
            ラベル3.TabIndex = 0;
            ラベル3.Text = "氏名";
            // 
            // ラベル4
            // 
            ラベル4.AutoSize = true;
            ラベル4.Location = new Point(24, 101);
            ラベル4.Margin = new Padding(4, 0, 4, 0);
            ラベル4.Name = "ラベル4";
            ラベル4.Size = new Size(31, 15);
            ラベル4.TabIndex = 1;
            ラベル4.Text = "給与";
            // 
            // Label5
            // 
            Label5.AutoSize = true;
            Label5.Location = new Point(24, 154);
            Label5.Margin = new Padding(4, 0, 4, 0);
            Label5.Name = "Label5";
            Label5.Size = new Size(55, 15);
            Label5.TabIndex = 2;
            Label5.Text = "生年月日";
            // 
            // ボディ部
            // 
            ボディ部.Controls.Add(給与);
            ボディ部.Controls.Add(氏名);
            ボディ部.Controls.Add(ラベル4);
            ボディ部.Controls.Add(ラベル3);
            ボディ部.Controls.Add(Label5);
            ボディ部.Controls.Add(生年月日);
            ボディ部.Controls.Add(更新);
            ボディ部.Controls.Add(キャンセル);
            ボディ部.Enabled = false;
            ボディ部.Location = new Point(64, 218);
            ボディ部.Margin = new Padding(4);
            ボディ部.Name = "ボディ部";
            ボディ部.Padding = new Padding(4);
            ボディ部.Size = new Size(559, 241);
            ボディ部.TabIndex = 3;
            ボディ部.TabStop = false;
            ボディ部.Text = "ボディ部";
            // 
            // 給与
            // 
            給与.Location = new Point(140, 98);
            給与.Name = "給与";
            給与.Size = new Size(114, 23);
            給与.TabIndex = 4;
            // 
            // 氏名
            // 
            氏名.Location = new Point(141, 49);
            氏名.Name = "氏名";
            氏名.Size = new Size(147, 23);
            氏名.TabIndex = 3;
            // 
            // 生年月日
            // 
            生年月日.Location = new Point(141, 150);
            生年月日.Margin = new Padding(4);
            生年月日.Name = "生年月日";
            生年月日.ShowCheckBox = true;
            生年月日.Size = new Size(213, 23);
            生年月日.TabIndex = 5;
            // 
            // 更新
            // 
            更新.Location = new Point(404, 125);
            更新.Margin = new Padding(4);
            更新.Name = "更新";
            更新.Size = new Size(133, 26);
            更新.TabIndex = 6;
            更新.Text = "更新";
            更新.UseVisualStyleBackColor = true;
            // 
            // キャンセル
            // 
            キャンセル.CausesValidation = false;
            キャンセル.Location = new Point(405, 174);
            キャンセル.Margin = new Padding(4);
            キャンセル.Name = "キャンセル";
            キャンセル.Size = new Size(133, 26);
            キャンセル.TabIndex = 7;
            キャンセル.Text = "キャンセル";
            キャンセル.UseVisualStyleBackColor = true;
            キャンセル.Click += キャンセル_Click;
            // 
            // メインメニュー
            // 
            メインメニュー.Items.AddRange(new ToolStripItem[] { テストToolStripMenuItem });
            メインメニュー.Location = new Point(0, 0);
            メインメニュー.Name = "メインメニュー";
            メインメニュー.Padding = new Padding(7, 2, 0, 2);
            メインメニュー.Size = new Size(716, 24);
            メインメニュー.TabIndex = 4;
            メインメニュー.Text = "メインメニュー";
            // 
            // テストToolStripMenuItem
            // 
            テストToolStripMenuItem.Name = "テストToolStripMenuItem";
            テストToolStripMenuItem.Size = new Size(45, 20);
            テストToolStripMenuItem.Text = "テスト";
            テストToolStripMenuItem.Click += テストToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(716, 556);
            Controls.Add(ヘッド部);
            Controls.Add(ボディ部);
            Controls.Add(メインメニュー);
            KeyPreview = true;
            MainMenuStrip = メインメニュー;
            Margin = new Padding(4);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            FormClosed += Form1_FormClosed;
            Load += Form1_Load;
            Shown += Form1_Shown;
            ヘッド部.ResumeLayout(false);
            ヘッド部.PerformLayout();
            ボディ部.ResumeLayout(false);
            ボディ部.PerformLayout();
            メインメニュー.ResumeLayout(false);
            メインメニュー.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        internal GroupBox ヘッド部;
        internal Label ラベル2;
        internal Label ラベル1;
        internal Button 確認;
        internal ComboBox 処理区分;
        internal GroupBox ボディ部;
        internal Label Label5;
        internal Label ラベル4;
        internal Label ラベル3;
        internal DateTimePicker 生年月日;
        internal Button 更新;
        internal Button キャンセル;
        private MenuStrip メインメニュー;
        private ToolStripMenuItem テストToolStripMenuItem;
        private TextBox 社員コード;
        private TextBox 氏名;
        private TextBox 給与;
    }
}