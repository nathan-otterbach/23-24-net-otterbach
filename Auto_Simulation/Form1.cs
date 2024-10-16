
namespace Auto_Simulation
{
    public partial class Form1 : Form
    {
        private Graphics _graphics => CreateGraphics();
        private Cl_Auto _auto = new Cl_Auto(Color.Red, Color.Black, Color.Gray, 100, 10, 10, 250);
        private bool _movingRight = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            timer1.Start();

            _movingRight = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Refresh();
            if (_movingRight)
            {
                _auto.X += 10;
                if (_auto.X >= ClientSize.Width - _auto.Groeﬂe - 10)
                {
                    _movingRight = false;
                }
            }
            else
            {
                _auto.X -= 10;
                if (_auto.X <= 10)
                {
                    _movingRight = true;
                }
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            _auto.Draw(_graphics);
        }
    }
}