
namespace Perspektivische_Felder
{
    public class Ebene : Flaeche
    {
        public Ebene() {}

        public Ebene(int anzahlPunkte) : this()
        {
            _anzahlPunkte = anzahlPunkte;
        }

        public Ebene(PointF[] punkte, int anzahlPunkte) : this()
        {
            _punkte = punkte;
            _anzahlPunkte = anzahlPunkte;
        }

        public Ebene(PointF[] punkte, int anzahlPunkte, SolidBrush farbe) : this(punkte, anzahlPunkte)
        {
            _farbe = farbe;
        }

        public override void draw(Graphics g)
        {
            for (int i = 0; i < _anzahlPunkte; i++)
            {
                if (_punkte.Length > 0)
                    g.FillPolygon(_farbe, _punkte);
            }
        }

        public override void animate(Graphics g)
        {
            int zufall = _rnd.Next(0, 2);
            switch (zufall)
            {
                case 0:
                    _farbe.Color = Color.Red;
                    break;
                case 1:
                    _farbe.Color = Color.Green;
                    break;
                case 2:
                    _farbe.Color = Color.Yellow;
                    break;
                default:
                    _farbe.Color = Color.Black;
                    break;
            }

            draw(g);
        }

        public override void delete(Graphics g)
        {
            g.Clear(Color.White);
        }
    }
}
