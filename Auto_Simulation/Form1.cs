
namespace Auto_Simulation
{
    public partial class Form1 : Form
    {
        private CAuto[] arr_autos = new CAuto[5];
        private CFahrer[] arr_fahrer = new CFahrer[5];
        private bool _movingRight = false;

        public Form1()
        {
            InitializeComponent();
            DoubleBuffered = true;

            for (int i = 0; i < arr_autos.Length; i++)
            {
                arr_fahrer[i] = new CFahrer(Color.Beige, Color.Black, 20, 60, i * 80 + 10);
                arr_autos[i] = new CAuto(Color.Red, Color.Black, Color.Gray, 100, 10, i * 80, arr_fahrer[i]);
                comboBox1.Items.Add("Auto " + i);
            }

            comboBox1.SelectedIndex = 0;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            timer1.Start();
            _movingRight = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != -1)
            {
                arr_autos[comboBox1.SelectedIndex].removeFahrer();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (_movingRight)
            {
                foreach (CAuto auto in arr_autos)
                {
                    auto.X += 10;
                    if (auto.Fahrer != null)
                    {
                        auto.Fahrer.X += 10;
                    }
                    if (auto.X >= ClientSize.Width - auto.Groeﬂe - 10)
                    {
                        _movingRight = false;
                    }
                }
            }
            else
            {
                foreach (CAuto auto in arr_autos)
                {
                    auto.X -= 10;
                    if (auto.Fahrer != null)
                    {
                        auto.Fahrer.X -= 10;
                    }
                    if (auto.X <= 10)
                    {
                        _movingRight = true;
                    }
                }
            }

            this.Refresh();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            foreach (CAuto auto in arr_autos)
            {
                auto.draw(e.Graphics);
            }
        }
    }
}