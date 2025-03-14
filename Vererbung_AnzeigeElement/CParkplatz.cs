namespace Vererbung_AnzeigeElement
{
    public class CParkplatz : CAnzeigeElement
    {
        private string _nummernschild;

        public string Nummernschild
        {
            get => _nummernschild;
            set => _nummernschild = value;
        }

        public CParkplatz() { }

        public CParkplatz(int xStart, int yStart, int breite, int hoehe, string nummernschild)
            : base(hoehe, breite, xStart, yStart, Color.White)
        {
            Nummernschild = nummernschild;
        }

        public override void draw(Graphics g)
        {
            using (Pen pen = new Pen(Color.Black, 2))
            using (Brush brush = new SolidBrush(Farbe))
            {
                g.FillRectangle(brush, XStart, YStart, Breite, Hoehe);
                g.DrawRectangle(pen, XStart, YStart, Breite, Hoehe);
            }

            using (Font font = new Font("Arial", 10, FontStyle.Bold))
            using (Brush brush = new SolidBrush(Color.Black))
            {
                g.DrawString(
                    Nummernschild,
                    font,
                    brush,
                    XStart + Breite / 2 - 30,
                    YStart + Hoehe / 2 - 10
                );
            }
        }
    }
}
