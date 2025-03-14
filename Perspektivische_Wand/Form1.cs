namespace Perspektivische_Wand
{
    public partial class Form1 : Form
    {
        private Bodenplatte _bodenplatte;
        private Rueckfront _rueckfront;

        public Form1()
        {
            this.DoubleBuffered = true;
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            _bodenplatte = new Bodenplatte(8);
            _rueckfront = new Rueckfront(4);

            _bodenplatte.Punkte[0] = new Point(50, 1000);
            _bodenplatte.Punkte[1] = new Point(1850, 1000);
            _bodenplatte.Punkte[2] = new Point(1850, 800);
            _bodenplatte.Punkte[3] = new Point(1500, 700);
            _bodenplatte.Punkte[4] = new Point(1000, 500);
            _bodenplatte.Punkte[5] = new Point(600, 500);
            _bodenplatte.Punkte[6] = new Point(250, 500);
            _bodenplatte.Punkte[7] = new Point(50, 500);

            _rueckfront.Punkte[0] = new Point(50, 500);
            _rueckfront.Punkte[1] = new Point(50, 50);
            _rueckfront.Punkte[2] = new Point(1000, 50);
            _rueckfront.Punkte[3] = new Point(1000, 500);

            _bodenplatte.draw(e.Graphics);
            _rueckfront.draw(e.Graphics);
        }
    }
}
