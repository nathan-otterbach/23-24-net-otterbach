namespace Begrüßung
{
    public partial class Form1 : Form
    {
        string str_Begruessung;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            str_Begruessung = "Hallo FTE1";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = str_Begruessung;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}