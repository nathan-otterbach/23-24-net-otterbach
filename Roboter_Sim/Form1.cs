namespace Roboter_Sim
{
    public partial class Form1 : Form
    {
        bool right_end = false;
        int width;

        public Form1()
        {
            InitializeComponent();
            this.Width = width;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        // stop
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            timer2.Enabled = false;
            pictureBox1.BackColor = Color.Red;
            pictureBox1.Location = new Point(10, 100);
        }

        // start
        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.Red;
            timer1.Enabled = true;
            timer2.Enabled = true;
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

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (right_end == false)
            {
                move_Forward();
            }
            else if(right_end == true)
            {
                move_Backward();
            }
        }

        private void move_Forward()
        {
            for (int i = 10; i <= 630; i++)
            {
                pictureBox1.Location = new Point(i, 100);
            }
            right_end = true;
        }

        private void move_Backward()
        {
            for (int i = 0; i <= 620; i++)
            {
                pictureBox1.Location = new Point(630-i, 100);
            }
            right_end = false;
        }
    }
}