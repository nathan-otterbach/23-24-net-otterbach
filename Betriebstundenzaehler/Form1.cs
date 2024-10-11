using System.Diagnostics;

namespace Betriebstundenzaehler
{
    public partial class Form1 : Form
    {
        private string path = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
        private readonly Stopwatch stopwatch = new Stopwatch();
        private int oldTime = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadFile($"{path}/test.txt");
            oldTime = Convert.ToInt32(textBox1.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!stopwatch.IsRunning)
            {
                textBox1.Clear();
                stopwatch.Start();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (stopwatch.IsRunning)
            {
                stopwatch.Stop();
                textBox1.Text += $"{stopwatch.ElapsedMilliseconds + textBox1.Text}";
            }

            SaveFile($"{path}/test.txt", textBox1.Lines);
        }

        private void LoadFile(string path)
        {
            if (!File.Exists(path))
            {
                File.Create(path);
            }

            string[] text = File.ReadAllLines(path);
            foreach (string line in text)
            {
                textBox1.Text += line + Environment.NewLine;
            }
        }

        private void SaveFile(string path, string[] text)
        {
            File.WriteAllLines(path, text);
        }
    }
}
