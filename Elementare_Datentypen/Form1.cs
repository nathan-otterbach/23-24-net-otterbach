namespace Elementare_Datentypen
{
    public partial class Form1 : Form
    {
        byte v_byte = 45;
        int end = 30;
        double ergebnis = 2.7334;

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

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = v_byte.ToString();
            textBox2.Text = end.ToString();
            textBox3.Text = ergebnis.ToString();
        }
    }
}