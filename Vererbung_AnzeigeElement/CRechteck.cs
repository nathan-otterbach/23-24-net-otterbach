namespace Vererbung_AnzeigeElement
{
    public class CRechteck : CAnzeigeElement
    {
        public CRechteck() : base() { }

        public CRechteck(int hoehe, int breite, int xStart, int yStart, Color farbe)
            : base(hoehe, breite, xStart, yStart, farbe) { }

        public override void draw(Graphics g)
        {
            using (var brush = new SolidBrush(Farbe))
            {
                g.FillRectangle(brush, XStart, YStart, Breite, Hoehe);
            }
        }
    }
}