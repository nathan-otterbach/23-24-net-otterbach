namespace Perspektivische_Felder
{
    public partial class Form1 : Form
    {
        private Ebene[] _ebenen = new Ebene[2];
        private PointF[] _punkte1 = new PointF[4];
        private PointF[] _punkte2 = new PointF[4];

        private Graphics g => CreateGraphics();

        public Form1()
        {
            this.DoubleBuffered = true;
            InitializeComponent();

            _punkte1[0] = new PointF(100, 50);
            _punkte1[1] = new PointF(200, 50);
            _punkte1[2] = new PointF(150, 150);
            _punkte1[3] = new PointF(50, 150);

            _punkte2[0] = new PointF(250, 50);
            _punkte2[1] = new PointF(350, 50);
            _punkte2[2] = new PointF(300, 150);
            _punkte2[3] = new PointF(200, 150);

            _ebenen[0] = new Ebene(_punkte1, 4);
            _ebenen[1] = new Ebene(_punkte2, 4);
        }

        private void draw_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            for (int i = 0; i < _ebenen.Length; i++)
            {
                _ebenen[i].draw(g);
            }
        }

        private void animate_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            for (int i = 0; i < _ebenen.Length; i++)
            {
                _ebenen[i].delete(g);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < _ebenen.Length; i++)
            {
                _ebenen[i].animate(g);
            }
        }
    }
}
