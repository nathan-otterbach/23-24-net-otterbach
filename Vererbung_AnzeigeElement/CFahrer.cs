namespace Vererbung_AnzeigeElement
{
    public class CFahrer : CAnzeigeElement
    {
        private CEllipse _kopf;
        private CEllipse _linkesAuge;
        private CEllipse _rechtesAuge;
        private CRechteck _nase;
        private CRechteck _mund;

        public CFahrer() :base() { }

        public CFahrer(int hoehe, int breite, int xStart, int yStart, Color hautFarbe, Color augenFarbe, Color mundFarbe)
            : base(hoehe, breite, xStart, yStart, hautFarbe)
        {
            _kopf = new CEllipse(
                hoehe, 
                breite, 
                xStart, 
                yStart, 
                hautFarbe
            );

            int augenBreite = breite / 6;
            int augenHoehe = hoehe / 8;
            _linkesAuge = new CEllipse(
                augenHoehe,
                augenBreite,
                xStart + breite / 4 - augenBreite / 2,
                yStart + hoehe / 3,
                augenFarbe
            );

            _rechtesAuge = new CEllipse(
                augenHoehe,
                augenBreite,
                xStart + 3 * breite / 4 - augenBreite / 2,
                yStart + hoehe / 3,
                augenFarbe
            );

            int nasenBreite = breite / 10;
            int nasenHoehe = hoehe / 6;
            _nase = new CRechteck(
                nasenHoehe,
                nasenBreite,
                xStart + breite / 2 - nasenBreite / 2,
                yStart + hoehe / 2 - nasenHoehe / 2,
                augenFarbe
            );

            int mundBreite = breite / 3;
            int mundHoehe = hoehe / 12;
            _mund = new CRechteck(
                mundHoehe,
                mundBreite,
                xStart + breite / 2 - mundBreite / 2,
                yStart + hoehe * 3 / 4 - mundHoehe / 2,
                mundFarbe
            );
        }

        public override void draw(Graphics g)
        {
            _kopf.draw(g);
            _linkesAuge.draw(g);
            _rechtesAuge.draw(g);
            _nase.draw(g);
            _mund.draw(g);
        }
    }
}