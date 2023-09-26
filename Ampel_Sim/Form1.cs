using System.Diagnostics;

namespace Ampel_Sim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        // stop
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            pictureBox1.BackColor = Color.Red;
        }

        // start
        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.Red;
            timer1.Enabled = true;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pictureBox1.BackColor == Color.Red)
            {
                pictureBox1.BackColor = Color.Yellow;
            }
            else if (pictureBox1.BackColor == Color.Yellow)
            {
                pictureBox1.BackColor = Color.Green;
            }
            else if (pictureBox1.BackColor == Color.Green)
            {
                pictureBox1.BackColor = Color.Red;
            }
        }
    }
}