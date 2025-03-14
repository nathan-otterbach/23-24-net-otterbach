namespace Perspektivische_Wand
{
    public class Bodenplatte
    {
        private Point[] _punkte;
        private int _anzahlPunkte;

        public Point[] Punkte
        {
            get { return _punkte; }
            set { _punkte = value; }
        }

        public int AnzahlPunkte
        {
            get { return _anzahlPunkte; }
            set
            {
                checked
                {
                    _anzahlPunkte = value;
                }
            }
        }

        public Bodenplatte() { }

        public Bodenplatte(int anzahlPunkte) : this()
        {
            AnzahlPunkte = anzahlPunkte;
            Punkte = new Point[anzahlPunkte];
        }

        public Bodenplatte(int anzahlPunkte, Point[] punkte) : this(anzahlPunkte)
        {
            Punkte = punkte;
        }

        public void draw(Graphics g)
        {
            for (int i = 0; i < AnzahlPunkte; i++)
            {
                if (Punkte.Length > 0)
                    g.FillPolygon(Brushes.Black, Punkte);
            }
        }
    }
}
