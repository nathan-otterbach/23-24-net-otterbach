namespace Vererbung_AnzeigeElement
{
    public abstract class CAnzeigeElement
    {
        private int _hoehe;
        private int _breite;
        private int _xStart;
        private int _yStart;
        private Color _farbe;

        public int Hoehe
        {
            get => _hoehe;
            set
            {
                if (value >= 0) _hoehe = value;
            }
        }

        public int Breite
        {
            get => _breite;
            set
            {
                if (value >= 0) _breite = value;
            }
        }

        public int XStart
        {
            get => _xStart;
            set => _xStart = value;
        }

        public int YStart
        {
            get => _yStart;
            set => _yStart = value;
        }

        public Color Farbe
        {
            get => _farbe;
            set => _farbe = value;
        }

        protected CAnzeigeElement() { }

        protected CAnzeigeElement(int hoehe, int breite, int xStart, int yStart, Color farbe)
        {
            Hoehe = hoehe;
            Breite = breite;
            XStart = xStart;
            YStart = yStart;
            Farbe = farbe;
        }

        public abstract void draw(Graphics g);
    }
}