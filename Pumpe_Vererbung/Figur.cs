namespace Pumpe_Vererbung
{
    public abstract class Figur
    {
        protected int _x = 0;
        protected int _y = 0;
        protected int _hoehe = 0;
        protected int _breite = 0;
        protected SolidBrush _farbe = new SolidBrush(Color.Black);

        public abstract void draw(Graphics g);
    }
}
