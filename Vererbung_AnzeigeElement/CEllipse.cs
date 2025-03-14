namespace Vererbung_AnzeigeElement
{
    public class CEllipse : CAnzeigeElement
    {
        public CEllipse() : base() { }

        public CEllipse(int hoehe, int breite, int xStart, int yStart, Color farbe)
            : base(hoehe, breite, xStart, yStart, farbe) { }

        public override void draw(Graphics g)
        {
            using (var brush = new SolidBrush(Farbe))
            {
                g.FillEllipse(brush, XStart, YStart, Breite, Hoehe);
            }
        }
    }
}