namespace WordSearcher
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.ChooseDirectoryButton = new System.Windows.Forms.Button();
            this.DirectoryNameTextBox = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.SearchWordButton = new System.Windows.Forms.Button();
            this.WordTextBox = new System.Windows.Forms.TextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.CopyFilesButton = new System.Windows.Forms.Button();
            this.SaveReportButton = new System.Windows.Forms.Button();
            this.ClearListBoxButton = new System.Windows.Forms.Button();
            this.folderBrowserDialog2 = new System.Windows.Forms.FolderBrowserDialog();
            this.DirectoryNameTextBox2 = new System.Windows.Forms.TextBox();
            this.CopyButton = new System.Windows.Forms.Button();
            this.ChangeButton = new System.Windows.Forms.Button();
            this.folderBrowserDialog3 = new System.Windows.Forms.FolderBrowserDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.ReadFileButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ChooseDirectoryButton
            // 
            this.ChooseDirectoryButton.Location = new System.Drawing.Point(24, 23);
            this.ChooseDirectoryButton.Name = "ChooseDirectoryButton";
            this.ChooseDirectoryButton.Size = new System.Drawing.Size(129, 23);
            this.ChooseDirectoryButton.TabIndex = 0;
            this.ChooseDirectoryButton.Text = "Выберите папку:";
            this.ChooseDirectoryButton.UseVisualStyleBackColor = true;
            this.ChooseDirectoryButton.Click += new System.EventHandler(this.ChooseDirectoryButton_Click);
            // 
            // DirectoryNameTextBox
            // 
            this.DirectoryNameTextBox.Location = new System.Drawing.Point(168, 24);
            this.DirectoryNameTextBox.Name = "DirectoryNameTextBox";
            this.DirectoryNameTextBox.Size = new System.Drawing.Size(539, 23);
            this.DirectoryNameTextBox.TabIndex = 1;
            // 
            // SearchWordButton
            // 
            this.SearchWordButton.Location = new System.Drawing.Point(24, 61);
            this.SearchWordButton.Name = "SearchWordButton";
            this.SearchWordButton.Size = new System.Drawing.Size(129, 23);
            this.SearchWordButton.TabIndex = 2;
            this.SearchWordButton.Text = "Искать слово:";
            this.SearchWordButton.UseVisualStyleBackColor = true;
            this.SearchWordButton.Click += new System.EventHandler(this.SearchWordButton_Click);
            // 
            // WordTextBox
            // 
            this.WordTextBox.Location = new System.Drawing.Point(168, 61);
            this.WordTextBox.Name = "WordTextBox";
            this.WordTextBox.Size = new System.Drawing.Size(539, 23);
            this.WordTextBox.TabIndex = 3;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(26, 100);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(681, 23);
            this.progressBar1.TabIndex = 4;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(26, 138);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(681, 244);
            this.listBox1.TabIndex = 6;
            // 
            // CopyFilesButton
            // 
            this.CopyFilesButton.Location = new System.Drawing.Point(26, 402);
            this.CopyFilesButton.Name = "CopyFilesButton";
            this.CopyFilesButton.Size = new System.Drawing.Size(202, 23);
            this.CopyFilesButton.TabIndex = 7;
            this.CopyFilesButton.Text = "Выберите папку для копирования";
            this.CopyFilesButton.UseVisualStyleBackColor = true;
            this.CopyFilesButton.Click += new System.EventHandler(this.CopyFilesButton_Click);
            // 
            // SaveReportButton
            // 
            this.SaveReportButton.Location = new System.Drawing.Point(24, 442);
            this.SaveReportButton.Name = "SaveReportButton";
            this.SaveReportButton.Size = new System.Drawing.Size(204, 27);
            this.SaveReportButton.TabIndex = 9;
            this.SaveReportButton.Text = "Сохранить отчет";
            this.SaveReportButton.UseVisualStyleBackColor = true;
            this.SaveReportButton.Click += new System.EventHandler(this.SaveReportButton_Click);
            // 
            // ClearListBoxButton
            // 
            this.ClearListBoxButton.Location = new System.Drawing.Point(250, 442);
            this.ClearListBoxButton.Name = "ClearListBoxButton";
            this.ClearListBoxButton.Size = new System.Drawing.Size(187, 27);
            this.ClearListBoxButton.TabIndex = 10;
            this.ClearListBoxButton.Text = "Очистить все";
            this.ClearListBoxButton.UseVisualStyleBackColor = true;
            this.ClearListBoxButton.Click += new System.EventHandler(this.ClearListBoxButton_Click);
            // 
            // DirectoryNameTextBox2
            // 
            this.DirectoryNameTextBox2.Location = new System.Drawing.Point(250, 402);
            this.DirectoryNameTextBox2.Name = "DirectoryNameTextBox2";
            this.DirectoryNameTextBox2.Size = new System.Drawing.Size(337, 23);
            this.DirectoryNameTextBox2.TabIndex = 11;
            // 
            // CopyButton
            // 
            this.CopyButton.Location = new System.Drawing.Point(593, 402);
            this.CopyButton.Name = "CopyButton";
            this.CopyButton.Size = new System.Drawing.Size(114, 23);
            this.CopyButton.TabIndex = 12;
            this.CopyButton.Text = "Копировать";
            this.CopyButton.UseVisualStyleBackColor = true;
            this.CopyButton.Click += new System.EventHandler(this.CopyButton_Click);
            // 
            // ChangeButton
            // 
            this.ChangeButton.Location = new System.Drawing.Point(740, 231);
            this.ChangeButton.Name = "ChangeButton";
            this.ChangeButton.Size = new System.Drawing.Size(83, 64);
            this.ChangeButton.TabIndex = 14;
            this.ChangeButton.Text = "Заменить";
            this.ChangeButton.UseVisualStyleBackColor = true;
            this.ChangeButton.Click += new System.EventHandler(this.ChangeButton_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(841, 23);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(238, 446);
            this.richTextBox1.TabIndex = 15;
            this.richTextBox1.Text = "";
            // 
            // ReadFileButton
            // 
            this.ReadFileButton.Location = new System.Drawing.Point(740, 138);
            this.ReadFileButton.Name = "ReadFileButton";
            this.ReadFileButton.Size = new System.Drawing.Size(83, 64);
            this.ReadFileButton.TabIndex = 16;
            this.ReadFileButton.Text = "Просмотр файла";
            this.ReadFileButton.UseVisualStyleBackColor = true;
            this.ReadFileButton.Click += new System.EventHandler(this.ReadFileButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(740, 318);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(83, 64);
            this.SaveButton.TabIndex = 17;
            this.SaveButton.Text = "Сохранить";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1117, 504);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.ReadFileButton);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.ChangeButton);
            this.Controls.Add(this.CopyButton);
            this.Controls.Add(this.DirectoryNameTextBox2);
            this.Controls.Add(this.ClearListBoxButton);
            this.Controls.Add(this.SaveReportButton);
            this.Controls.Add(this.CopyFilesButton);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.WordTextBox);
            this.Controls.Add(this.SearchWordButton);
            this.Controls.Add(this.DirectoryNameTextBox);
            this.Controls.Add(this.ChooseDirectoryButton);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Поиск и замена слов";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button ChooseDirectoryButton;
        public TextBox DirectoryNameTextBox;
        private FolderBrowserDialog folderBrowserDialog1;
        private Button SearchWordButton;
        private TextBox WordTextBox;
        private ProgressBar progressBar1;
        private ListBox listBox1;
        private Button CopyFilesButton;
        private Button SaveReportButton;
        private Button ClearListBoxButton;
        private FolderBrowserDialog folderBrowserDialog2;
        public TextBox DirectoryNameTextBox2;
        private Button CopyButton;
        private Button ChangeButton;
        private FolderBrowserDialog folderBrowserDialog3;
        private System.Windows.Forms.Timer timer1;
        private RichTextBox richTextBox1;
        private Button ReadFileButton;
        private Button SaveButton;
    }
}