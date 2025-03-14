namespace Pumpe_Vererbung
{
    public partial class Form1 : Form
    {
        private Pumpe _pumpe;

        public Form1()
        {
            this.DoubleBuffered = true;
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            _pumpe = new Pumpe(50, 50, 200, 100, 1, 1, new SolidBrush(Color.Red), new SolidBrush(Color.Green), new SolidBrush(Color.Blue));
            _pumpe.draw(e.Graphics);
        }
    }
}
