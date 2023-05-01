using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using static System.Windows.Forms.LinkLabel;
using Microsoft.VisualBasic.ApplicationServices;
using System.Reflection.PortableExecutable;
using System.Linq.Expressions;

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
            progressBar1.Value = 0;
            listBox1.Items.Clear();
            string[] allFoundFiles = Directory.GetFiles(DirectoryNameTextBox.Text, "*.txt", SearchOption.AllDirectories);
            foreach (string file in allFoundFiles)
            {
                string[] lines = System.IO.File.ReadAllLines(file);
                int i = 0;
                string b = WordTextBox.Text; //Искомое слово

                if (WordTextBox.Text == String.Empty)
                {
                    listBox1.Items.Add(file);
                    #region 
                    //timer1.Interval = 500; // 500 миллисекунд
                    timer1.Enabled = true;
                    timer1.Tick += timer1_Tick;
                    #endregion
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
                                listBox1.Items.Add(file);
                                //timer1.Interval = 500; // 500 миллисекунд
                                #region 
                                timer1.Enabled = true;
                                timer1.Tick += timer1_Tick;
                                break;
                                #endregion
                            }
                        }
                    }
                }
            }
        }

        private void SaveReportButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Текстовый документ (*.txt)|*.txt|Все файлы (*.*)|*.*";

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
                using (var sw = new StreamReader(listBox1.SelectedItem.ToString()))
                {
                    string s = await sw.ReadToEndAsync();
                    s = s.Replace(WordTextBox.Text, "*******");
                    str = s.Split('\n').Select(s => s != "" ? s : "0").ToList();
                }
                foreach (var s in str)
                {
                    //await Task.Delay(300);
                    richTextBox1.Text += s + "\n";
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
            richTextBox1.Text = null;
            List<string> str;
            using (var sw = new StreamReader(listBox1.SelectedItem.ToString()))
            {
                string s = await sw.ReadToEndAsync();
                str = s.Split('\n').Select(s => s != "" ? s : "0").ToList();
            }
            foreach (var s in str)
            {
                //await Task.Delay(300);
                richTextBox1.Text += s + "\n";
            }
        }
        private void CopyButton_Click(object sender, EventArgs e)
        {
            try
            {
                FileInfo fi = new FileInfo(listBox1.SelectedItem.ToString());
                fi.CopyTo(DirectoryNameTextBox2.Text + "\\" + fi.Name);
                MessageBox.Show("Файл успешно скопирован");
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
                saveFileDialog.Filter = "Текстовый документ (*.txt)|*.txt|Все файлы (*.*)|*.*";

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