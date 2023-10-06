namespace Gauß_algorithmus
{
    public partial class Form1 : Form
    {
        int start;
        int end;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();

            start = 1;
            end = 100;
            textBox1.Text = start.ToString();
            textBox2.Text = end.ToString();
            textBox3.Text = gauß_Algo(start, end).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();

            start = 50;
            end = 500000;
            textBox1.Text = start.ToString();
            textBox2.Text = end.ToString();
            textBox3.Text = gauß_Algo(start, end).ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();

            start = 1;
            end = 1000000;
            textBox1.Text = start.ToString();
            textBox2.Text = end.ToString();
            textBox3.Text = gauß_Algo(start, end).ToString();
        }

        private long gauß_Algo(int start, int end)
        {
            long n;
            if (end < 0 && start < 0) n = (end - start) - 1;
            if (end > 0 && start < 0) n = (end - start);
            if (end < start)
            {
                start = end;
                end = start;
                n = (end - start);
            }
            n = (end - start) + 1;

            return (n * (n + 1)) / 2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            start = int.Parse(textBox1.Text);
            end = int.Parse(textBox2.Text);
            textBox3.Text = gauß_Algo(start, end).ToString();
        }
    }
}