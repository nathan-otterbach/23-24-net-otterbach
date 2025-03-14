namespace Pumpe_Vererbung
{
    public class Rechteck : Figur
    {
        public Rechteck() { }

        public Rechteck(int x, int y, int breite, int hoehe, SolidBrush farbe) : this()
        {
            _x = x;
            _y = y;
            _breite = breite;
            _hoehe = hoehe;
            _farbe = farbe;
        }

        public override void draw(Graphics g)
        {
            g.FillRectangle(_farbe, _x, _y, _breite, _hoehe);
        }
    }
}
