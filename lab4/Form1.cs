using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Threading;

namespace lab4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void openWordsBtn_Click(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();
        }

        private void openFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            Stopwatch stopWatch = new Stopwatch();
            String filename = openFileDialog.FileName;
            stopWatch.Start();
            StreamReader reader = new System.IO.StreamReader(filename);
            String words = reader.ReadToEnd();
            reader.Close();
            pushWordToList(words);
            stopWatch.Stop();
            TimeSpan workTime = stopWatch.Elapsed;
            workTimeLabel.Text = workTime.TotalMilliseconds.ToString() + " ms";
                       
        }

        private void pushWordToList(String _words)
        {
            String[] sep = { "\n","\r",",",".",";" };
            String[] words = _words.Split(sep,StringSplitOptions.RemoveEmptyEntries);
            foreach (var word in words){
                if (!wordList.Items.Contains(word))
                {
                    wordList.Items.Add(word);
                }
            }
        }

        private void findWordBtn_Click(object sender, EventArgs e)
        {
            Stopwatch stopWatch = new Stopwatch();
            if (!(searchWordText.Text.Replace(" ","").Length == 0)){
                stopWatch.Start();
                if (wordList.Items.Contains(searchWordText.Text))
                {
                    wordList.SetSelected(wordList.Items.IndexOf(searchWordText.Text), true);
                    stopWatch.Stop();
                }
                else
                {
                    stopWatch.Stop();
                    MessageBox.Show("Слово '" + searchWordText.Text + "' не найдено!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                String searchTime = stopWatch.Elapsed.TotalMilliseconds.ToString();
                searchTimeLabel.Text = searchTime;
            }else
            {
                MessageBox.Show("Введите слово для поиска", "Ошибка",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            wordList.Items.Clear();
            searchWordText.Clear();
            workTimeLabel.Text = "0 ms";
            searchWordText.Clear();
            searchTimeLabel.Text = "0 ms";
        }
    }
}
