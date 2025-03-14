namespace Vererbung_AnzeigeElement
{
    public class CAuto : CAnzeigeElement
    {
        private CRechteck _karosserie;
        private CRechteck _fenster;
        private CEllipse _linkesRad;
        private CEllipse _rechtesRad;
        private CFahrer _fahrer;
        private string _nummernschild;

        public bool hatFahrer => _fahrer != null;

        public CAuto() : base() { }

        public CAuto(int xStart, int yStart, int hoehe, int breite, Color autoFarbe, Color fensterFarbe, Color radFarbe, Random rnd)
            : base(hoehe, breite, xStart, yStart, autoFarbe)
        {
            _karosserie = new CRechteck(
                hoehe,
                breite,
                xStart,
                yStart,
                autoFarbe
            );

            _fenster = new CRechteck(
                hoehe / 2,
                breite / 4,
                xStart + breite / 2,
                yStart + hoehe / 5,
                fensterFarbe
            );

            int radDurchmesser = hoehe / 2;
            _linkesRad = new CEllipse(
                radDurchmesser,
                radDurchmesser,
                xStart + breite / 8,
                yStart + hoehe - radDurchmesser / 2,
                radFarbe
            );

            _rechtesRad = new CEllipse(
                radDurchmesser,
                radDurchmesser,
                xStart + breite * 5 / 8,
                yStart + hoehe - radDurchmesser / 2,
                radFarbe
            );

            _nummernschild = GenerateRandomLicensePlate(rnd);
        }

        private string GenerateRandomLicensePlate(Random rnd)
        {
            string letters = $"{(char)rnd.Next('A', 'Z' + 1)}{(char)rnd.Next('A', 'Z' + 1)}";
            int numbers = rnd.Next(10, 1000);
            return $"CR {letters} {numbers}";
        }

        public void FahrerHinzufuegen(Color hautFarbe, Color augenFarbe, Color mundFarbe)
        {
            if (!hatFahrer)
            {
                _fahrer = new CFahrer(
                    _fenster.Hoehe,
                    _fenster.Breite,
                    _fenster.XStart,
                    _fenster.YStart,
                    hautFarbe,
                    augenFarbe,
                    mundFarbe
                );
            }
        }

        public void FahrerEntfernen()
        {
            _fahrer = null;
            GC.Collect();
        }

        public override void draw(Graphics g)
        {
            _karosserie.draw(g);
            _fenster.draw(g);
            _linkesRad.draw(g);
            _rechtesRad.draw(g);
            _fahrer?.draw(g);

            using (Font font = new Font("Arial", 10, FontStyle.Bold))
            using (Brush brush = new SolidBrush(Color.Black))
            {
                int nummernschildX = _fenster.XStart - _fenster.Breite - 30;
                int nummernschildY = _fenster.YStart + _fenster.Hoehe / 2 - 5;
                g.DrawString(
                    _nummernschild,
                    font,
                    brush,
                    nummernschildX,
                    nummernschildY
                );
            }
        }
    }
}