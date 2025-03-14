namespace Pumpe_Vererbung
{
    public class Kreis : Figur
    {
        public Kreis() { }

        public Kreis(int x, int y, int breite, int hoehe, SolidBrush farbe) : this()
        {
            _x = x;
            _y = y;
            _breite = breite;
            _hoehe = hoehe;
            _farbe = farbe;
        }

        public override void draw(Graphics g)
        {
            g.FillEllipse(_farbe, _x, _y, _breite, _hoehe);
        }
    }
}
