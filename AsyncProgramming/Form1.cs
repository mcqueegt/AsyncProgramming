namespace AsyncProgramming
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Gavin McQueen
        private void Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void browse1_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtFile1.Text = openFileDialog1.FileName.Split("\\").LastOrDefault();
            }
        }

        private void browse2_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog2.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtFile2.Text = openFileDialog2.FileName.Split("\\").LastOrDefault();
            }
        }
        //Gavin McQueen
        private async void Submit_Click(object sender, EventArgs e)
        {
            lstReport1.Items.Clear();
            lstReport2.Items.Clear();
            List<Task> tasks = new List<Task>();
            var file1 = openFileDialog1.FileName;
            var file2 = openFileDialog2.FileName;
            var wordTask1 = ReadBook1(file1);
            var wordTask2 = ReadBook2(file2);
            tasks.Add(wordTask1);
            tasks.Add(wordTask2);
            await Task.WhenAll(tasks);
        }
        //Gavin McQueen
        private async Task ReadBook1(string File1)
        {
            var lines = await File.ReadAllLinesAsync(File1);

            var arrayLinesCleaned = lines.Where(x => x != string.Empty)
                                         .AsParallel()
                                         .Select(x => x.ToLower()
                                         .Trim()
                                         .Replace(",", "")
                                         .Replace(".", "")
                                         .Replace("!", "")
                                         .Replace("?", "")
                                         .Replace("'", ""));

            var arrayOfWords = arrayLinesCleaned.SelectMany(x => x.Split(" "));
            Dictionary<string, int> wordDic = new Dictionary<string, int>();
            arrayOfWords.ToList().ForEach(x =>
            {
                if (wordDic.ContainsKey(x))
                {
                    wordDic[x]++;
                }
                else
                {
                    wordDic.Add(x, 1);
                }
            }
            );
            //Gavin McQueen
            var top10 = wordDic.Where(x => !string.IsNullOrWhiteSpace(x.Key))
                               .OrderByDescending(x => x.Value)
                               .Take(10);

            foreach (var word in top10)
            {
                lstReport1.Items.Add(word.Key + " - " + word.Value);
            }

        }

        private async Task ReadBook2(string File2)
        {
            var lines = await File.ReadAllLinesAsync(File2);
            var arrayLinesCleaned = lines.Where(x => x != string.Empty)
                                         .AsParallel()
                                         .Select(x => x.ToLower()
                                         .Trim()
                                         .Replace(",", "")
                                         .Replace(".", "")
                                         .Replace("!", "")
                                         .Replace("?", "")
                                         .Replace("'", ""));
            var ArrayofWords = arrayLinesCleaned.SelectMany(x => x.Split(" "));
            Dictionary<string , int> wordDic = new Dictionary<string, int>();
            ArrayofWords.ToList().ForEach(x =>
            {
                if (wordDic.ContainsKey(x))
                {
                    wordDic[x]++;
                }
                else
                {
                    wordDic.Add(x, 1);
                }
            }
            );

            var top10 = wordDic.Where(x => !string.IsNullOrWhiteSpace(x.Key))
                               .OrderByDescending(x => x.Value)
                               .Take(10);

            foreach (var word in top10)
            {
                lstReport2.Items.Add(word.Key + " - " + word.Value);
            }
        } //Gavin McQueen

    }
}
