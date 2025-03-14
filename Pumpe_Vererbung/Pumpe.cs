
namespace Pumpe_Vererbung
{
    public class Pumpe : Figur
    {
        private Kreis[] _kreis;
        private Rechteck[] _rechteck;
        private int anzKreis;
        private int anzRechteck;

        public Pumpe() { }

        public Pumpe(int x, int y, int breite, int hoehe, int anzKreis, int anzRechteck, SolidBrush farbe1, SolidBrush farbe2, SolidBrush farbe3) : this()
        {
            _x = x;
            _y = y;
            _breite = breite;
            _hoehe = hoehe;
            _farbe = farbe1;
            this.anzKreis = anzKreis;
            this.anzRechteck = anzRechteck;

            _kreis = new Kreis[anzKreis];
            _rechteck = new Rechteck[anzRechteck];

            // anpassen
            for (int i = 0; i < _kreis.Length; i++)
            {
                _kreis[i] = new Kreis(_x + _breite / 2, _y + _hoehe / 4, _breite / 2, _hoehe / 2, farbe2);
            }

            // anpassen
            for (int i = 0; i < _rechteck.Length; i++)
            {
                _rechteck[i] = new Rechteck(_x, _y + _hoehe / 4, _breite / 4, _hoehe / 2, farbe3);
            }
        }

        public override void draw(Graphics g)
        {
            for (int i = 0; i < _rechteck.Length; i++)
            {
                _rechteck[i].draw(g);
            }

            for (int i = 0; i < _kreis.Length; i++)
            {
                _kreis[i].draw(g);
            }
        }
    }
}