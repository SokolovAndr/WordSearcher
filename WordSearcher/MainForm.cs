using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using static System.Windows.Forms.LinkLabel;
using Microsoft.VisualBasic.ApplicationServices;
using System.Reflection.PortableExecutable;
using System.Linq.Expressions;
using System.Diagnostics;

namespace WordSearcher
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();           
        }
        void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.PerformStep();
        }

        private void ChooseDirectoryButton_Click(object sender, EventArgs e)
        {
            ChooseFolder();
        }

        public void ChooseFolder()
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                DirectoryNameTextBox.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void SearchWordButton_Click(object sender, EventArgs e)
        {
            Thread thread1 = new Thread(SearchWord);
            thread1.Start();
            //SearchWord();
        }


        public void SearchWord()
        {
            try
            {
                Stopwatch stopwatch = new Stopwatch(); //�������� ����� ������ ��������
                stopwatch.Start(); //��������� �����-���� ��������

                this.Invoke((Action)(() => {
                    progressBar1.Value = 0;
                }));
                this.Invoke((Action)(() => {
                    listBox1.Items.Clear();
                }));
                string[] allFoundFiles = Directory.GetFiles(DirectoryNameTextBox.Text, "*.txt", SearchOption.AllDirectories);
                foreach (string file in allFoundFiles)
                {
                    string[] lines = System.IO.File.ReadAllLines(file);
                    int i = 0;
                    string b = WordTextBox.Text; //������� �����

                    if (WordTextBox.Text == String.Empty)
                    {
                        this.Invoke((Action)(() => {
                            listBox1.Items.Add(file);
                            timer1.Interval = 500; // 500 �����������
                            timer1.Enabled = true;
                            timer1.Tick += timer1_Tick;
                        }));
                    }
                    if (WordTextBox.Text != String.Empty)
                    {
                        foreach (string line in lines)
                        {
                            string[] var = lines[i].Split(default(string[]), StringSplitOptions.RemoveEmptyEntries);
                            i += 1;
                            foreach (string word in var)
                            {
                                if (b.Equals(word))
                                {
                                    this.Invoke((Action)(() => {
                                        listBox1.Items.Add(file);
                                        timer1.Interval = 500; // 500 �����������
                                        timer1.Enabled = true;
                                        timer1.Tick += timer1_Tick;
                                    }));
                                }
                            }
                        }
                    }
                }
                
                stopwatch.Stop(); //������������� �������
                MessageBox.Show(Convert.ToString(stopwatch.ElapsedMilliseconds) + " ����������", "����� ����������� �� �����", MessageBoxButtons.OK, MessageBoxIcon.Information); //������� ������� ����������� ���� ��������� �� ����������
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SaveReportButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "��������� �������� (*.txt)|*.txt|��� ����� (*.*)|*.*";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                StreamWriter streamWriter = new StreamWriter(saveFileDialog.FileName);
                for (int i = 0; i < listBox1.Items.Count; i++)
                {
                    streamWriter.WriteLine(listBox1.Items[i].ToString());                   
                }
                streamWriter.Close();
            }
        }

        private void ClearListBoxButton_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            WordTextBox.Text = null;
            richTextBox1.Text = null;
            DirectoryNameTextBox.Text = null;
            DirectoryNameTextBox2.Text = null;
            progressBar1.Value = 0;
        }

        private void CopyFilesButton_Click(object sender, EventArgs e)
        {
            ChooseFolder2();           
        }

        public void ChooseFolder2()
        {
            if (folderBrowserDialog2.ShowDialog() == DialogResult.OK)
            {
                DirectoryNameTextBox2.Text = folderBrowserDialog2.SelectedPath;
            }
        }

        private void ChangeButton_Click(object sender, EventArgs e)
        {
            try
            {
                ChangeValuesFromFile();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        async void ChangeValuesFromFile()
        {
            try
            {
                richTextBox1.Text = null;
                List<string> str;

                if (listBox1.SelectedItem != null)
                {
                    using (var sw = new StreamReader(listBox1.SelectedItem.ToString()))
                    {
                        string s = await sw.ReadToEndAsync();
                        s = s.Replace(WordTextBox.Text, "*******");
                        str = s.Split('\n').Select(s => s != "" ? s : "0").ToList();
                    }
                    foreach (var s in str)
                    {
                        await Task.Delay(50);
                        richTextBox1.Text += s + "\n";
                    }
                }
                else
                {
                    MessageBox.Show("�� ������ �� �������!");
                }
            }
            
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void ReadFileButton_Click(object sender, EventArgs e)
        {
            ReadFromFile();
        }

        async void ReadFromFile()
        {
            try
            {
                richTextBox1.Text = null;
                List<string> str;

                if(listBox1.SelectedItem != null)
                {
                    using (var sw = new StreamReader(listBox1.SelectedItem.ToString()))
                    {
                        string s = await sw.ReadToEndAsync();
                        str = s.Split('\n').Select(s => s != "" ? s : "0").ToList();
                    }
                    foreach (var s in str)
                    {
                        await Task.Delay(50);
                        richTextBox1.Text += s + "\n";
                    }
                }
                else
                {
                    MessageBox.Show("�� ������ �� �������!");
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        private void CopyButton_Click(object sender, EventArgs e)
        {
            try
            {
                if(listBox1.SelectedItem != null) 
                {
                    FileInfo fi = new FileInfo(listBox1.SelectedItem.ToString());
                    fi.CopyTo(DirectoryNameTextBox2.Text + "\\" + fi.Name);
                    MessageBox.Show("���� ������� ����������");
                }

                else
                {
                    MessageBox.Show("�� ������ �� �������!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "��������� �������� (*.txt)|*.txt|��� ����� (*.*)|*.*";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    StreamWriter streamWriter = new StreamWriter(saveFileDialog.FileName);
                    streamWriter.WriteLine(richTextBox1.Text);   
                    streamWriter.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}